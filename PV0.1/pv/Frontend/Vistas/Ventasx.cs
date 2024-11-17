using System;
using System.Windows.Forms;
using pv.Backend;

namespace pv.Frontend.Vistas
{
    public partial class Ventasx : Form
    {
        
        private Connection c = new Connection();
        private Backend.Venta v;

        public Ventasx()
        {
            InitializeComponent();
            v = new Backend.Venta();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentasDiarias_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtventas.DataSource = v.select_ventas();
        }

        private void dtventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void VentasDiarias_Load_1(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
