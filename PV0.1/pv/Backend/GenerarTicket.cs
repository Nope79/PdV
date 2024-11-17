using System;
using MySql.Data.MySqlClient;
using System.IO;

namespace pv.Backend
{
    public class GenerarTicket
    {
        private readonly Connection conexion;

        public GenerarTicket()
        {
            conexion = new Connection();  // Usamos la clase Connection tal como está
        }

        // Método para generar el recibo de la venta
        public void GenerarRecibo(int idVenta)
        {
            // Abrir la conexión a la base de datos
            MySqlConnection conn = null;
            MySqlTransaction tran = null;
            try
            {
                conexion.OpenConnection();
                conn = conexion.GetConnection();
                tran = conn.BeginTransaction();  // Iniciar una transacción

                // Obtener información de la venta
                string consultaVenta = "SELECT v.fecha, v.importe, v.subtotal, v.iva, v.total, e.nombre " +
                                       "FROM ventas v JOIN empleados e ON v.id_empleado = e.id " +
                                       "WHERE v.id = @idVenta";
                MySqlCommand cmdVenta = new MySqlCommand(consultaVenta, conn, tran);
                cmdVenta.Parameters.AddWithValue("@idVenta", idVenta);

                MySqlDataReader readerVenta = cmdVenta.ExecuteReader();

                if (readerVenta.Read())
                {
                    DateTime fechaVenta = readerVenta.GetDateTime(0);
                    decimal importe = readerVenta.GetDecimal(1);
                    decimal subtotal = readerVenta.GetDecimal(2);
                    decimal iva = readerVenta.GetDecimal(3);
                    decimal total = readerVenta.GetDecimal(4);
                    string empleado = readerVenta.GetString(5);

                    // Cerramos el lector de la venta para proceder con los detalles
                    readerVenta.Close();

                    // Generar el archivo de texto con la información de la venta
                    GenerarTXT(idVenta, fechaVenta, empleado, subtotal, iva, total, conn, tran);

                    // Confirmamos la transacción si todo está correcto
                    tran.Commit();
                    Console.WriteLine($"Ticket generado correctamente para la venta {idVenta}.");
                }
                else
                {
                    Console.WriteLine("Venta no encontrada.");
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, hacemos rollback de la transacción
                if (tran != null)
                {
                    Console.WriteLine("Error en la transacción, realizando rollback.");
                    tran.Rollback();
                }
                Console.WriteLine($"Error al generar el ticket: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión después de obtener la información
                conexion.CloseConnection();
            }
        }

        // Método para generar el archivo de texto (TXT) del ticket
        private void GenerarTXT(int idVenta, DateTime fechaVenta, string empleado, decimal subtotal, decimal iva, decimal total, MySqlConnection conexion, MySqlTransaction tran)
        {
            // Crear el archivo de texto
            string archivoTxt = $"Ticket_Venta_{idVenta}.txt";

            // Abrir un StreamWriter para escribir en el archivo
            using (StreamWriter escritor = new StreamWriter(archivoTxt))
            {
                // Escribir los encabezados y detalles de la venta
                escritor.WriteLine("****************************************");
                escritor.WriteLine("         TICKET DE VENTA");
                escritor.WriteLine("****************************************");
                escritor.WriteLine($"Fecha: {fechaVenta}");
                escritor.WriteLine($"Vendedor: {empleado}");
                escritor.WriteLine("****************************************");

                // Obtener los detalles de los productos vendidos
                string consultaDetalles = "SELECT p.nombre, dv.cantidad_producto, dv.precio_unitario " +
                                          "FROM detalles_venta dv " +
                                          "JOIN productos p ON dv.id_productos = p.id " +
                                          "WHERE dv.id_venta = @idVenta";
                MySqlCommand cmdDetalles = new MySqlCommand(consultaDetalles, conexion, tran);
                cmdDetalles.Parameters.AddWithValue("@idVenta", idVenta);

                MySqlDataReader readerDetalles = cmdDetalles.ExecuteReader();

                while (readerDetalles.Read())
                {
                    string nombreProducto = readerDetalles.GetString(0);
                    int cantidad = readerDetalles.GetInt32(1);
                    decimal precioUnitario = readerDetalles.GetDecimal(2);

                    // Escribir cada producto y su precio total al archivo TXT
                    escritor.WriteLine($"{nombreProducto} x {cantidad} - ${precioUnitario * cantidad}");
                }

                readerDetalles.Close();

                // Escribir el subtotal, IVA y total de la venta
                escritor.WriteLine("****************************************");
                escritor.WriteLine($"Subtotal: ${subtotal}");
                escritor.WriteLine($"IVA: ${iva}");
                escritor.WriteLine($"Total: ${total}");
                escritor.WriteLine("****************************************");
                escritor.WriteLine("¡Gracias por su compra!");
                escritor.WriteLine("****************************************");
            }

            Console.WriteLine($"Ticket generado: {archivoTxt}");
        }
    }
}
