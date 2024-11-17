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

        public Venta(string met_pago, double importe, double subtotal, double total)
        {
            this.met_pago = met_pago;
            this.importe = importe;
            this.subtotal = subtotal;
            this.total = total;
            c = new Connection();
        }

        public bool GuardarVentaConDetalles(DataGridView dtVenta, Venta venta)
        {
            bool x = false;
            MySqlTransaction transaction = null;
            try
            {

                var xid = Application.UserAppDataRegistry.GetValue("ID");
                var xuser = Application.UserAppDataRegistry.GetValue("User");
                venta.id_empleado = Convert.ToInt32(xid);

                c.OpenConnection();
                transaction = c.GetConnection().BeginTransaction();

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
                    idVenta = (int)cmdVenta.LastInsertedId;
                }

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

                            cmdDetalles.ExecuteNonQuery();
                        }
                    }
                }

                transaction.Commit();
                x = true;
                GenTicket g = new GenTicket();
                g.GenerarRecibo(idVenta);
                Console.WriteLine("Venta y detalles registrados correctamente.");
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                Console.WriteLine("Error al registrar la venta y los detalles: " + ex.Message);
            }
            finally
            {
                c.CloseConnection();
            }

            return x;
        }

        public DataTable select_ventas_fecha(DateTime startDate, DateTime endDate)
        {
            string query = @"
                    SELECT * from ventas
                    WHERE fecha BETWEEN @startDate AND @endDate";

            DataTable tabla = new DataTable();
            try
            {
                c.OpenConnection();
                using (var command = new MySqlCommand(query, c.GetConnection()))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return tabla;
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
