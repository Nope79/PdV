using MySql.Data.MySqlClient;
using pv.Backend;
using System;
using System.Data;
using System.Windows.Forms;

namespace pv.Frontend.Vistas
{
    public partial class VentaHecha : Form
    {
        private Connection c = new Connection();
        public VentaHecha()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private string idVenta;

        private void VentaHecha_Load(object sender, EventArgs e)
        {
        }

        private void CargarDatos()
        {
            try
            {
                if (string.IsNullOrEmpty(idVenta))
                {
                    MessageBox.Show("Por favor, ingresa un ID de venta.");
                    return;
                }

                string query = @"
                            SELECT 
                            v.id AS id_venta,
                            e.id AS id_empleado,
                            p.id AS id_producto,
                            p.nombre AS producto,
                            p.marca AS marca,
                            dv.precio_unitario,
                            dv.cantidad_producto
                            FROM ventas v
                            JOIN detalles_venta dv ON v.id = dv.id_venta
                            JOIN empleados e ON v.id_empleado = e.id
                            JOIN productos p ON dv.id_producto = p.id
                            WHERE v.id = @idVenta";

                c.OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, c.GetConnection()))
                {
                    command.Parameters.AddWithValue("@idVenta", int.Parse(idVenta));

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dtticket.DataSource = table;
                    }
                }

                dtticket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dtticket.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos para este ID de venta.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID de la venta debe ser un número válido.");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
            }
        }
        private void cbopcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbopcion.SelectedItem == "Fecha")
            {
                tbid.Visible = false;
            }

            else if(cbopcion.SelectedItem == "ID")
            {
                tbid.Visible = true;
            }

            else
            {
                tbid.Visible = false;
            }
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {
            idVenta = tbid.Text;
            CargarDatos();
        }
    }
}
