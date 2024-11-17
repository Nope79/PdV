using System;
using System.Windows.Forms;
using pv.Frontend.Vistas;
using pv.Frontend.Login;
using pv.Frontend.Registro;
using pv.Frontend.Ventas;

namespace pv.Frontend
{
    public partial class main : Form
    {
        public main()
        {
            var xid = Application.UserAppDataRegistry.GetValue("ID");
            var xuser = Application.UserAppDataRegistry.GetValue("User");
            Console.WriteLine($"{xid} {xuser}");
            InitializeComponent();
            this.Text = $"Bienvenido {xuser} :D!";
        }

        private void btnCRUDP_Click(object sender, EventArgs e)
        {
            CRUD_Productos ce = new CRUD_Productos();
            ce.Show();
            this.Hide();
        }

        private void btnCRUDE_Click(object sender, EventArgs e)
        {
            CRUD_Employees ce = new CRUD_Employees();
            ce.Show();
            this.Hide();
        }

        private void btnventasd_Click(object sender, EventArgs e)
        {
            Ventasx vd = new Ventasx();
            vd.Show();
            this.Hide();
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            Vender v = new Vender();
            v.Show();
            this.Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            VentaHecha v = new VentaHecha();
            v.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres regresar a la ventana principal?.");
                if (confirmed)
                {
                    this.Hide();
                    logmain ce = new logmain();
                    ce.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
