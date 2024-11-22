using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace pv.Backend
{
    internal class Employees
    {
        private int id;
        private string nombre;
        private string usuario { get; set; }
        private string pass { get; set; }
        private string correo;
        private string tel;
        private Connection c;
        public Employees()
        {
            c = new Connection();
        }

        public Employees(string Usuario, string Pass)
        {
            usuario = Usuario;
            pass = Pass;
        }

        public (int, string) validar_login(string usuario, string pass)
        {
            string res = "Usuario o contraseña incorrectos.";
            int id = 0;
            try
            {
                string query = "select id, usuario from empleados where usuario = @usuario and contrasena = sha2(@pass, 256)";

                c.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader.GetInt32("id");
                            res = reader.GetString("usuario");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return (id, res);
        }

        public DataTable select_employees()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "SELECT id, nombre, usuario, correo, telefono FROM empleados";
                using (MySqlCommand command = new MySqlCommand(query, c.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                Console.WriteLine("Datos cargados correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                c.CloseConnection();
            }

            return dataTable;
        }
        public bool insert_employees(string nombre, string usuario, string pass, string correo, string telefono)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                MySqlConnection connection = c.GetConnection();
                string query = "insert into empleados(nombre, usuario, contrasena, correo, telefono) values (@nombre, @usuario, sha2(@pass, 256), @correo, @telefono)";

                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    Console.WriteLine("Transacción no completada. Rollback.");
                    tran.Rollback();
                }
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                c.CloseConnection();
            }
        }
        public string validar_insersion(int id, string nombre, string user, string pass, string passc, string correo, string tel)
        {
            try
            {
                if (nombre == "" || user == "" || pass == "" || correo == "" || tel == "")
                {
                    return "Debe llenar todos los campos de texto.";
                }

                if (user == select_user(user, id))
                {
                    return "Este usuario ya existe.";
                }

                if (pass != passc)
                {
                    return "Las contraseñas deben coincidir.";
                }

                // Matches

                // Validación del nombre (solo letras, espacios, tildes y ñ)
                if (!Regex.Match(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success)
                {
                    return "El nombre solo debe contener letras, espacios, tildes y ñ.";
                }

                // Validación de la contraseña (min 8 caracteres, al menos 1 mayúscula, 1 minúscula, 1 número y 1 carácter especial)
                if (!Regex.Match(pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
                {
                    return "La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas, números y caracteres especiales.";
                }

                // Validación del correo
                if (!Regex.Match(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$").Success)
                {
                    return "El correo no tiene un formato válido.";
                }

                // Validación del teléfono (solo números)
                if (!Regex.Match(tel, @"^\d+$").Success)
                {
                    return "El teléfono solo debe contener números.";
                }

                else
                {
                    return "OK";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "Error.";
            }
        }
        public bool update_employees(int id, string nombre, string usuario, string pass, string correo, string telefono)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "update empleados set nombre = @nombre, usuario = @usuario, contrasena = sha2(@pass, 256), correo = @correo, telefono = @telefono where id = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    int filas = cmd.ExecuteNonQuery();
                    res = filas > 0;
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    Console.WriteLine("Transacción no completada. Rollback.");
                    tran.Rollback();
                }
                Console.WriteLine(ex);
                res = false;
            }
            finally
            {
                c.CloseConnection();
            }

            return res;
        }
        public bool delete_employees(int id)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "delete from empleados where id = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
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
                    Console.WriteLine("Transacción no completada. Rollback.");
                    tran.Rollback();
                }
                Console.WriteLine(ex);
                res = false;
            }
            finally
            {
                c.CloseConnection();
            }

            return res;
        }
        public string select_user(string usuario, int id)
        {
            string u = null;
            string query = "select usuario from empleados where usuario = @usuario and id != @id";

            try
            {
                c.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
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
                Console.WriteLine(ex);
            }
            finally
            {
                c.CloseConnection();
            }

            return u;
        }
    }
}
