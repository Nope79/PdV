using System;
using System.Windows.Forms;
using pv.Backend;

namespace pv.Frontend
{
    public partial class Update_Employee : Form
    {
        private Connection c = new Connection();
        private Employees e;
        private int id;

        public Update_Employee(int id, string nombre, string usuario, /*string contra*/ string correo, string telefono)
        {
            InitializeComponent();

            tbname.Text = nombre;
            tbuser.Text = usuario;
            tbpass.Text = "";
            tbpassc.Text = "";
            tbmail.Text = correo;
            tbphone.Text = telefono;
            this.id = id;
            this.Load += new EventHandler(Update_Employee_Load);

            tbname.KeyUp += new KeyEventHandler(tbname_KeyUp);
            tbuser.KeyUp += new KeyEventHandler(tbuser_KeyUp);
            tbpass.KeyUp += new KeyEventHandler(tbpass_KeyUp);
            tbpassc.KeyUp += new KeyEventHandler(tbpassc_KeyUp);
            tbmail.KeyUp += new KeyEventHandler(tbmail_KeyUp);
            tbphone.KeyUp += new KeyEventHandler(tbphone_KeyUp);
        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            tbname.Focus();
        }

        private void tbname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbuser.Focus();
            }
        }

        private void tbuser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbpass.Focus();
            }
        }

        private void tbpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbpassc.Focus();
            }
        }

        private void tbpassc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbmail.Focus();
            }
        }

        private void tbmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbphone.Focus();
            }
        }

        private void tbphone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnupdate.Focus(); // Opcionalmente, enfocar el botón "Crear" al final
            }
        }


        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Avanzar al siguiente control
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employees ee = new Employees();
                string res = ee.validar_insersion(id, tbname.Text, tbuser.Text, tbpass.Text, tbpassc.Text, tbmail.Text, tbphone.Text);

                if (res == "OK")
                {
                    bool confirmed = Confirmar.Show("¿Estás seguro de que quieres modificar el usuario?\nUna vez hecho, no podrás deshacer los cambios.");
                    if (confirmed)
                    {
                        ee.update_employees(id, tbname.Text, tbuser.Text, tbpass.Text, tbmail.Text, tbphone.Text);

                        this.Hide();
                        CRUD_Employees ce = new CRUD_Employees();
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
            CRUD_Employees ce = new CRUD_Employees();
            ce.Show();
            this.Hide();
        }

        private void Update_Employee_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
