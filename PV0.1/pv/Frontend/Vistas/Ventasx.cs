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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtventas.DataSource = v.select_ventas();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Hide();
        }

        private void Ventasx_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpinicio.Value.Date;
            DateTime endDate = dtpfin.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.");
            }
            else
            {
                dtventas.DataSource = v.select_ventas_fecha(startDate, endDate);
            }
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            dtventas.DataSource = v.select_ventas();
        }
    }
}
