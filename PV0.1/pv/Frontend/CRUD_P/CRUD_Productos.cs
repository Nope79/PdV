using System;
using System.Windows.Forms;
using pv.Backend;


namespace pv.Frontend
{
    public partial class CRUD_Productos : Form
    {
        private Connection c = new Connection();
        private Productos p;
        private int id;
        private double iva;
        private string nombre;
        private double precio;
        private int stock;
        private string marca;
        private string descripcion;
        private double peso;
        private string cod;

        public CRUD_Productos()
        {
            InitializeComponent();
            p = new Productos();
            LoadData();
        }

        private void LoadData()
        {
            // Carga los datos en el DataGridView
            dgvProductos.DataSource = p.select_productos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Create_Productos f = new Create_Productos();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_producto up = new Update_producto(id, nombre, precio.ToString("F2"), iva.ToString("F2"), stock.ToString(), marca, descripcion, peso.ToString("F3"), cod.ToString());
            up.Show();
            this.Hide();
        }

        private void CRUD_Productos_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvProductos.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvProductos.Rows[e.RowIndex];
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    nombre = selectedRow.Cells["Nombre"].Value.ToString();
                    precio = Convert.ToDouble(selectedRow.Cells["Precio"].Value);
                    iva = Convert.ToDouble(selectedRow.Cells["Iva"].Value);
                    stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
                    marca = selectedRow.Cells["Marca"].Value.ToString();
                    descripcion = selectedRow.Cells["Descripcion"].Value.ToString();
                    peso = Convert.ToDouble(selectedRow.Cells["Peso"].Value);
                    cod = selectedRow.Cells["Cod"].Value.ToString();

                    btnborrar.Enabled = true;
                    btneditar.Enabled = true;
                }
                else
                {
                    btnborrar.Enabled = false;
                    btneditar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres eliminar el producto?\nUna vez hecho, no podrás deshacer la acción.");
                if (confirmed)
                {
                    Productos p = new Productos();
                    p.delete_productos(id);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
