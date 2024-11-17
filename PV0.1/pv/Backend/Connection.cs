using System;
using MySql.Data.MySqlClient;

namespace pv.Backend
{
    public class Connection
    {
        private MySqlConnection connection;
        private readonly string connectionString;
        public Connection()
        {
            connectionString = "server=nope79-t1u2.mysql.database.azure.com; User ID=nope79; password=abcABC1!; Database=puntodeventa; port=3306; sslmode=required;";
            connection = new MySqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
