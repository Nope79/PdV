using pv.Backend;
using System;
using System.Windows.Forms;


namespace pv.Frontend
{
    public partial class Create_Productos : Form
    {
        public Create_Productos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos pp = new Productos();

            string nombre = tbnombre.Text.Trim();
            string precio = tbprecio.Text.Trim();
            string iva = tbiva.Text.Trim();
            string stock = tbstock.Text.Trim();
            string marca = tbmarca.Text.Trim();
            string descripcion = tbdescripcion.Text.Trim();
            string peso = tbpeso.Text.Trim();
            string cod = tbcodigo.Text.Trim();

            string res = pp.validar_insersion(0, nombre, precio, iva, stock, marca, descripcion, peso, cod);
            if (res == "OK")
            {
                pp.insert_productos(nombre, double.Parse(tbprecio.Text), double.Parse(tbiva.Text), int.Parse(tbstock.Text), marca, descripcion, double.Parse(tbprecio.Text), cod);

                CRUD_Productos ce = new CRUD_Productos();
                ce.Show();
                this.Hide();

                res = "Producto añadido.";
            }

            MessageBox.Show(res);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            if (e.KeyCode == Keys.Enter) tbcodigo.Focus();
        }

        private void tbcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btncrear.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres regresar a la página anterior?\nSe perderá la información no guardada.");
                if (confirmed)
                {
                    this.Hide();
                    CRUD_Productos ce = new CRUD_Productos();
                    ce.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tbpeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
