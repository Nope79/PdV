using pv.Frontend.Login;
using pv.Frontend.Registro;
using System;
using System.Windows.Forms;

namespace pv.Frontend
{
    public partial class logmain : Form
    {
        public logmain()
        {
            InitializeComponent();
        }

        private void logmain_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.Show();
            this.Hide();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
