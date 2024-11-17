using System;
using System.Drawing;
using System.Windows.Forms;

namespace pv.Frontend
{
    public partial class Confirmar : Form
    {
        public Confirmar(string message)
        {
            InitializeComponent();
            lbmessage.Text = message;
            CenterLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Confirmar_Load(object sender, EventArgs e)
        {

        }

        public static bool Show(string message)
        {
            using (var confirmDialog = new Confirmar(message))
            {
                var result = confirmDialog.ShowDialog();
                return result == DialogResult.Yes;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void CenterLabel()
        {
            int xPos = (this.ClientSize.Width - lbmessage.Width) / 2;
            int yPos = (this.ClientSize.Height - lbmessage.Height) / 3;

            lbmessage.Location = new Point(xPos, yPos);
        }
    }
}
