namespace pv.Frontend
{
    partial class Create_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Employee));
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.tbpassc = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(195, 337);
            this.tbphone.MaxLength = 10;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(209, 26);
            this.tbphone.TabIndex = 27;
            this.tbphone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbphone_KeyUp);
            // 
            // tbmail
            // 
            this.tbmail.Location = new System.Drawing.Point(195, 291);
            this.tbmail.MaxLength = 50;
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(209, 26);
            this.tbmail.TabIndex = 26;
            this.tbmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbmail_KeyUp);
            // 
            // tbpassc
            // 
            this.tbpassc.Location = new System.Drawing.Point(195, 244);
            this.tbpassc.MaxLength = 64;
            this.tbpassc.Name = "tbpassc";
            this.tbpassc.PasswordChar = '*';
            this.tbpassc.Size = new System.Drawing.Size(209, 26);
            this.tbpassc.TabIndex = 25;
            this.tbpassc.UseSystemPasswordChar = true;
            this.tbpassc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbpassc_KeyUp);
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(195, 189);
            this.tbpass.MaxLength = 64;
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(209, 26);
            this.tbpass.TabIndex = 24;
            this.tbpass.UseSystemPasswordChar = true;
            this.tbpass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbpass_KeyUp);
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(195, 132);
            this.tbuser.MaxLength = 50;
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(209, 26);
            this.tbuser.TabIndex = 23;
            this.tbuser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbuser_KeyUp);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(195, 86);
            this.tbname.MaxLength = 80;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(209, 26);
            this.tbname.TabIndex = 0;
            this.tbname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbname_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(19, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirmar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(195, 397);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(209, 51);
            this.btnadd.TabIndex = 15;
            this.btnadd.TabStop = false;
            this.btnadd.Text = "Crear";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(12, 413);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(137, 35);
            this.btnback.TabIndex = 14;
            this.btnback.TabStop = false;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 642);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.tbphone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbpass);
            this.panel2.Controls.Add(this.tbuser);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbmail);
            this.panel2.Controls.Add(this.tbpassc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbname);
            this.panel2.Location = new System.Drawing.Point(39, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 460);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(399, 40);
            this.label7.TabIndex = 28;
            this.label7.Text = "Creación de Usuarios";
            // 
            // Create_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 637);
            this.Controls.Add(this.panel1);
            this.Name = "Create_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.Update_Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.TextBox tbpassc;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}