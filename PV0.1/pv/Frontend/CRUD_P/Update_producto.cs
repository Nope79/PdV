using pv.Backend;
using System;
using System.Windows.Forms;

namespace pv.Frontend
{
    public partial class Update_producto : Form
    {
        private Connection c = new Connection();
        private Productos p;
        private int id;
        private string nombre;
        double precio;
        double iva;
        int stock;
        string marca;
        string descripcion;
        double peso;
        string cod;

        public Update_producto(int id, string nombre, string precio, string iva, string stock, string marca, string descripcion, string peso, string cod)
        {
            InitializeComponent();
            tbnombre.Text = nombre;
            tbprecio.Text = precio;
            tbiva.Text = iva;
            tbstock.Text = stock;
            tbmarca.Text = marca;
            tbdescripcion.Text = descripcion;
            tbpeso.Text = peso;
            tbcod.Text = cod;

            this.id = id;
            this.cod = cod;
        }

        private void Create_Productos_Load(object sender, EventArgs e)
        {
            tbnombre.Focus(); // Foco inicial en el primer TextBox
        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbprecio.Focus();
        }

        private void tbprecio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbiva.Focus();
        }

        private void tbiva_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbstock.Focus();
        }

        private void tbstock_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbmarca.Focus();
        }

        private void tbmarca_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbdescripcion.Focus();
        }

        private void tbdescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbpeso.Focus();
        }

        private void tbpeso_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) tbcod.Focus();
        }

        private void tbcod_KeyU(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnupdate.Focus();
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnupdate.PerformClick(); // Activa el botón con Enter
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.nombre = tbnombre.Text;
                this.precio = double.Parse(tbprecio.Text);
                this.iva = double.Parse(tbiva.Text);
                this.stock = int.Parse(tbstock.Text);
                this.marca = tbmarca.Text;
                this.descripcion = tbdescripcion.Text;
                this.peso = double.Parse(tbpeso.Text);
                this.cod = tbcod.Text;
                Productos p = new Productos();
                string res = p.validar_insersion(id, nombre, precio.ToString("F2"), iva.ToString("F2"), stock.ToString(), marca, descripcion, peso.ToString("F3"), cod);
                if (res == "OK")
                {
                    bool confirmed = Confirmar.Show("¿Estás seguro de que quieres modificar el producto?\nUna vez hecho, no podrás deshacer los cambios.");

                    if (confirmed)
                    {
                        p.update_productos(id, tbnombre.Text, double.Parse(tbprecio.Text), double.Parse(tbiva.Text), int.Parse(tbstock.Text), tbmarca.Text, tbdescripcion.Text, double.Parse(tbpeso.Text), cod);

                        this.Hide();
                        CRUD_Productos ce = new CRUD_Productos();
                        ce.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos no válidos.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CRUD_Productos cp = new CRUD_Productos();
            this.Hide();
            cp.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
