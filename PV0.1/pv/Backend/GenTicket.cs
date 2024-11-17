using System;
using MySql.Data.MySqlClient;
using System.IO;

namespace pv.Backend
{
    public class GenTicket
    {
        private readonly Connection conexion;

        public GenTicket()
        {
            conexion = new Connection();
        }

        public void GenerarRecibo(int idVenta)
        {
            MySqlConnection conn = null;
            MySqlTransaction tran = null;

            try
            {
                // Abrir la conexión a la base de datos
                conexion.OpenConnection();
                conn = conexion.GetConnection();
                tran = conn.BeginTransaction();

                string query = @"
                    SELECT 
                        v.id AS id_venta,
                        e.id AS id_empleado,
                        p.id AS id_producto,
                        p.nombre AS producto,
                        p.marca AS marca,
                        dv.precio_unitario,
                        dv.cantidad_producto,
                        v.fecha,
                        v.subtotal,
                        v.total,
                        e.nombre AS empleado
                    FROM ventas v
                    JOIN detalles_venta dv ON v.id = dv.id_venta
                    JOIN empleados e ON v.id_empleado = e.id
                    JOIN productos p ON dv.id_producto = p.id
                    WHERE v.id = @idVenta";

                MySqlCommand cmd = new MySqlCommand(query, conn, tran);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Crear la ruta de la carpeta 'tickets'
                    string directorioTickets = Path.Combine(Directory.GetCurrentDirectory(), "tickets");
                    if (!Directory.Exists(directorioTickets))
                    {
                        Directory.CreateDirectory(directorioTickets); // Crear la carpeta si no existe
                    }

                    // Nombre del archivo
                    string archivoTxt = Path.Combine(directorioTickets, $"Ticket_Venta_{idVenta}.txt");

                    // Escribir el contenido del ticket
                    using (StreamWriter escritor = new StreamWriter(archivoTxt))
                    {
                        escritor.WriteLine("****************************************");
                        escritor.WriteLine("         TICKET DE VENTA");
                        escritor.WriteLine("****************************************");

                        DateTime fechaVenta = DateTime.MinValue;
                        decimal subtotal = 0, total = 0;
                        string empleado = "";

                        while (reader.Read())
                        {
                            if (fechaVenta == DateTime.MinValue)
                            {
                                // Obtener datos generales de la venta
                                fechaVenta = reader.GetDateTime("fecha");
                                subtotal = reader.GetDecimal("subtotal");
                                total = reader.GetDecimal("total");
                                empleado = reader.GetString("empleado");

                                escritor.WriteLine($"Fecha: {fechaVenta}");
                                escritor.WriteLine($"Vendedor: {empleado}");
                                escritor.WriteLine("****************************************");
                            }

                            // Detalles de los productos
                            string nombreProducto = reader.GetString("producto");
                            string marca = reader.GetString("marca");
                            decimal precioUnitario = reader.GetDecimal("precio_unitario");
                            int cantidad = reader.GetInt32("cantidad_producto");

                            escritor.WriteLine($"{nombreProducto} ({marca}) x {cantidad} - ${precioUnitario * cantidad:F2}");
                        }

                        // Mostrar totales y cierre del ticket
                        escritor.WriteLine("****************************************");
                        escritor.WriteLine($"Subtotal: ${subtotal:F2}");
                        escritor.WriteLine($"Total: ${total:F2}");
                        escritor.WriteLine("****************************************");
                        escritor.WriteLine("¡Gracias por su compra!");
                        escritor.WriteLine("****************************************");
                    }

                    Console.WriteLine($"Ticket generado: {archivoTxt}");
                }
                else
                {
                    Console.WriteLine("No se encontró la venta especificada.");
                }

                reader.Close();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran?.Rollback();
                Console.WriteLine($"Error al generar el ticket: {ex.Message}");
            }
            finally
            {
                conexion.CloseConnection();
            }
        }
    }
}
