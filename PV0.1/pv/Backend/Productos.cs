using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace pv.Backend
{
    internal class Productos
    {
        private int id;
        private string nombre;
        private double precio;
        private double iva;
        private int stock;
        private string marca;
        private string descripcion;
        private double peso;
        private string cod;
        private Connection c;

        public Productos()
        {
            c = new Connection();
        }
        public DataRow select_productos(string cod)
        {
            DataRow row = null;
            DataTable table = new DataTable();

            try
            {
                c.OpenConnection();
                string query = "select id, nombre, precio, 1 as cantidad, (precio * 1) as subtotal, iva, round((precio * iva / 100), 2) as impuesto, cod from productos where cod = @cod";

                using (MySqlCommand command = new MySqlCommand(query, c.GetConnection()))
                {
                    command.Parameters.AddWithValue("@cod", cod);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }

                if (table.Rows.Count > 0)
                {
                    row = table.Rows[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el producto: " + ex.Message);
            }
            finally
            {
                c.CloseConnection();
            }

            return row;
        }
        public DataTable select_productos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "SELECT * FROM productos";
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
                Console.WriteLine("Error al obtener los productos: " + ex.Message);
            }
            finally
            {
                c.CloseConnection();
            }

            return dataTable;
        }
        public void insert_productos(string nombre, double precio, double iva, int stock, string marca, string descripcion, double peso, string cod)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();

                string query = "Insert into productos(nombre, precio, iva, stock, marca, descripcion, peso, cod) values (@nombre, @precio, @iva, @stock, @marca, @descripcion, @peso, @cod)";

                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());
                cmd.Transaction = tran;

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@iva", iva);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@peso", peso);
                cmd.Parameters.AddWithValue("@cod", cod);

                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                Console.WriteLine("Error en la inserción: " + ex.Message);
            }
            finally
            {
                c.CloseConnection();
            }
        }
        public string validar_insersion(int id, string nombre, string precio, string iva, string stock, string marca, string descripcion, string peso, string cod)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(iva) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(peso) || string.IsNullOrEmpty(cod))
            {
                return "Debe llenar todos los campos de texto.";
            }

            if (nombre == select_product(nombre, id))
            {
                return "Este producto ya existe.";
            }

            // precio (dos decimales)
            if (!Regex.Match(precio, @"^\d+(\.\d{2})$").Success)
            {
                return "El precio solo debe contener números con dos decimales (por ejemplo, 123.45).";
            }

            // iva (dos decimales)
            if (!Regex.Match(iva, @"^\d+(\.\d{2})$").Success)
            {
                return "El iva solo debe contener números con dos decimales (por ejemplo, 12.45).";
            }

            // stock (solo números)
            if (!Regex.Match(stock, @"^\d+$").Success)
            {
                return "El stock solo debe contener números.";
            }

            // descripción (solo letras, espacios, tildes y ñ)
            if (!Regex.Match(descripcion, @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑ\s.,!?\-():]+$").Success)
            {
                return "La descripción solo debe contener letras, números, espacios, tildes y ñ.";
            }

            // peso (tres decimales)
            if (!Regex.Match(peso, @"^\d+(\.\d{3})$").Success)
            {
                return "El peso solo debe contener números con tres decimales (por ejemplo, 123.456).";
            }

            // cod (13 digitos y solo digitos)
            if (!Regex.Match(cod, @"^\d{13}$").Success)
            {
                return "El código debe contener solo dígitos y 13 exactamente.";
            }

            return "OK";
        }
        public bool update_productos(int id, string nombre, double precio, double iva, int stock, string marca, string descripcion, double peso, string cod)
        {
            bool res = true;
            string query = "UPDATE productos SET nombre = @nombre, precio = @precio, iva = @iva, stock = @stock, marca = @marca, descripcion = @descripcion, peso = @peso, cod = @cod where id = @id";
            MySqlTransaction tran = null;

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();

                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Transaction = tran;

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@iva", iva);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@peso", peso);
                    cmd.Parameters.AddWithValue("@cod", cod);
                    int filas = cmd.ExecuteNonQuery();
                    res = filas > 0;
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                Console.WriteLine("Error en la actualización: " + ex.Message);
                res = false;
            }
            finally
            {
                c.CloseConnection();
            }

            return res;
        }
        public bool delete_productos(int id)
        {
            bool res = true;
            string query = "delete from productos where id = @id";
            MySqlTransaction tran = null;

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();

                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Transaction = tran;

                    cmd.Parameters.AddWithValue("@id", id);
                    int filas = cmd.ExecuteNonQuery();
                    res = filas > 0;
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                Console.WriteLine("Error en la eliminación: " + ex.Message);
                res = false;
            }
            finally
            {
                c.CloseConnection();
            }

            return res;
        }
        public string select_product(string nombre, int id)
        {
            string u = null;
            string query = "select nombre from productos where nombre = @nombre and id != @id";

            try
            {
                c.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@id", id);

                    var resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        u = resultado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                c.CloseConnection();
            }

            return u;
        }
    }
}
