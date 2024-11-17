using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace pv.Backend
{
    public class Venta
    {
        private int id;
        private int id_empleado;
        private string fecha;
        private string descripcion;
        private string met_pago;
        private double importe;
        private double subtotal;
        private double iva;
        private double total;
        private Connection c;

        public Venta()
        {
            c = new Connection();
        }

        public Venta(int id_empleado, string met_pago, double importe, double subtotal, double total)
        {
            this.id = id_empleado;
            this.met_pago = met_pago;
            this.importe = importe;
            this.subtotal = subtotal;
            this.total = total;
            c = new Connection();
        }

        public bool GuardarVentaConDetalles(DataGridView dtVenta, Venta venta)
        {
            bool x = false;
            Console.WriteLine(venta.id_empleado + venta.met_pago + venta.importe + venta.subtotal + venta.total);
            MySqlTransaction transaction = null;
            try
            {
                venta.id_empleado = 1;
                // Abrir conexión
                c.OpenConnection();

                // Iniciar transacción
                transaction = c.GetConnection().BeginTransaction();

                // Insertar la venta principal y obtener el ID
                string queryVenta = @"INSERT INTO ventas (id_empleado, importe, subtotal, total, metodo_pago, descripcion) 
                                  VALUES (@idEmpleado, @importe, @subtotal, @total, @metodoPago, '')";
                int idVenta;
                using (MySqlCommand cmdVenta = new MySqlCommand(queryVenta, c.GetConnection(), transaction))
                {
                    cmdVenta.Parameters.AddWithValue("@idEmpleado", venta.id_empleado);
                    cmdVenta.Parameters.AddWithValue("@importe", venta.importe);
                    cmdVenta.Parameters.AddWithValue("@subtotal", venta.subtotal);
                    cmdVenta.Parameters.AddWithValue("@total", venta.total);
                    cmdVenta.Parameters.AddWithValue("@metodoPago", venta.met_pago);

                    cmdVenta.ExecuteNonQuery();
                    // Obtener el ID de la última venta
                    idVenta = (int)cmdVenta.LastInsertedId;
                }

                // Insertar los detalles de la venta
                foreach (DataGridViewRow row in dtVenta.Rows)
                {
                    if (row.Cells["ID"].Value != null)
                    {
                        int idProducto = Convert.ToInt32(row.Cells["ID"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        double precio = Convert.ToDouble(row.Cells["PrecioU"].Value);

                        string queryDetalles = @"INSERT INTO detalles_venta 
                                              (id_venta, id_producto, cantidad_producto, precio_unitario) 
                                              VALUES (@idVenta, @idProducto, @cantidad, @precio)";

                        using (MySqlCommand cmdDetalles = new MySqlCommand(queryDetalles, c.GetConnection(), transaction))
                        {
                            cmdDetalles.Parameters.AddWithValue("@idVenta", idVenta);
                            cmdDetalles.Parameters.AddWithValue("@idProducto", idProducto);
                            cmdDetalles.Parameters.AddWithValue("@cantidad", cantidad);
                            cmdDetalles.Parameters.AddWithValue("@precio", precio);

                            Console.WriteLine("FUNCIONA");
                            cmdDetalles.ExecuteNonQuery();
                            Console.WriteLine("FUNCIONA");
                        }
                    }
                }

                // Confirmar transacción
                transaction.Commit();
                x = true;
                Console.WriteLine("Venta y detalles registrados correctamente.");
            }
            catch (Exception ex)
            {
                // Revertir cambios si ocurre un error
                transaction?.Rollback();
                Console.WriteLine("Error al registrar la venta y los detalles: " + ex.Message);
            }
            finally
            {
                // Cerrar conexión
                c.CloseConnection();
            }

            return x;
        }

        public DataTable select_ventas()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "SELECT * FROM ventas";
                using (MySqlCommand command = new MySqlCommand(query, c.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                c.CloseConnection();
            }
            return dataTable;
        }
    }
}
