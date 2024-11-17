using pv.Backend;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pv.Frontend.Login
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            tbusuario.KeyUp += new KeyEventHandler(tbuser_KeyUp);
            tbcontra.KeyUp += new KeyEventHandler(tbcontra_KeyUp);
            this.tbusuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            logmain m = new logmain();
            m.Show();
        }

        private void tbuser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbcontra.Focus();
            }
        }

        private void tbcontra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogearse.Focus();
            }
        }

        private void btlogearse_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbusuario.Text == "" || tbcontra.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos de texto.");
                }
                // validar contraseña (min 8 caracteres, al menos 1 mayúscula, 1 minúscula, 1 número y 1 carácter especial)
                else if (!Regex.Match(tbcontra.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas, números y caracteres especiales.");
                }
                else
                {
                    Employees ee = new Employees();
                    var x = ee.validar_login(tbusuario.Text, tbcontra.Text);

                    if (x.Item2 == "Usuario o contraseña incorrectos.")
                    {
                        MessageBox.Show(x.Item2);
                    }
                    else
                    {
                        Application.UserAppDataRegistry.SetValue("ID", x.Item1);
                        Application.UserAppDataRegistry.SetValue("User", x.Item2);
                        this.Hide();
                        main m = new main();
                        m.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
