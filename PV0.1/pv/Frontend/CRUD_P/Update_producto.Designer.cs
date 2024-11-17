namespace pv.Frontend
{
    partial class Update_producto
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
            this.tbpeso = new System.Windows.Forms.TextBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.tbmarca = new System.Windows.Forms.TextBox();
            this.tbstock = new System.Windows.Forms.TextBox();
            this.tbprecio = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbiva = new System.Windows.Forms.TextBox();
            this.lbliva = new System.Windows.Forms.Label();
            this.tbcod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpeso
            // 
            this.tbpeso.Location = new System.Drawing.Point(111, 372);
            this.tbpeso.MaxLength = 11;
            this.tbpeso.Name = "tbpeso";
            this.tbpeso.Size = new System.Drawing.Size(229, 26);
            this.tbpeso.TabIndex = 49;
            this.tbpeso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbpeso_KeyUp);
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(111, 328);
            this.tbdescripcion.MaxLength = 65534;
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(229, 26);
            this.tbdescripcion.TabIndex = 48;
            this.tbdescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbdescripcion_KeyUp);
            // 
            // tbmarca
            // 
            this.tbmarca.Location = new System.Drawing.Point(111, 282);
            this.tbmarca.MaxLength = 30;
            this.tbmarca.Name = "tbmarca";
            this.tbmarca.Size = new System.Drawing.Size(229, 26);
            this.tbmarca.TabIndex = 47;
            this.tbmarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbmarca_KeyUp);
            // 
            // tbstock
            // 
            this.tbstock.Location = new System.Drawing.Point(111, 233);
            this.tbstock.MaxLength = 9;
            this.tbstock.Name = "tbstock";
            this.tbstock.Size = new System.Drawing.Size(229, 26);
            this.tbstock.TabIndex = 46;
            this.tbstock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbstock_KeyUp);
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(111, 128);
            this.tbprecio.MaxLength = 11;
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(229, 26);
            this.tbprecio.TabIndex = 45;
            this.tbprecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbprecio_KeyUp);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(111, 79);
            this.tbnombre.MaxLength = 40;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(229, 26);
            this.tbnombre.TabIndex = 44;
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(184, 459);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(156, 55);
            this.btnupdate.TabIndex = 50;
            this.btnupdate.Text = "Modificar";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            this.btnupdate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(8, 480);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(137, 34);
            this.btnback.TabIndex = 51;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 639);
            this.panel1.TabIndex = 52;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbiva
            // 
            this.tbiva.Location = new System.Drawing.Point(111, 182);
            this.tbiva.MaxLength = 5;
            this.tbiva.Name = "tbiva";
            this.tbiva.Size = new System.Drawing.Size(229, 26);
            this.tbiva.TabIndex = 54;
            this.tbiva.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbiva_KeyUp);
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbliva.Location = new System.Drawing.Point(13, 182);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(30, 20);
            this.lbliva.TabIndex = 53;
            this.lbliva.Text = "Iva";
            // 
            // tbcod
            // 
            this.tbcod.Location = new System.Drawing.Point(111, 413);
            this.tbcod.MaxLength = 13;
            this.tbcod.Name = "tbcod";
            this.tbcod.Size = new System.Drawing.Size(229, 26);
            this.tbcod.TabIndex = 56;
            this.tbcod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbcod_KeyU);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.tbcod);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbiva);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbliva);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbpeso);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbdescripcion);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbmarca);
            this.panel2.Controls.Add(this.tbnombre);
            this.panel2.Controls.Add(this.tbstock);
            this.panel2.Controls.Add(this.tbprecio);
            this.panel2.Location = new System.Drawing.Point(36, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 529);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 30);
            this.label8.TabIndex = 57;
            this.label8.Text = "Modificación de productos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Update_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 629);
            this.Controls.Add(this.panel1);
            this.Name = "Update_producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.Create_Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbpeso;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.TextBox tbmarca;
        private System.Windows.Forms.TextBox tbstock;
        private System.Windows.Forms.TextBox tbprecio;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbiva;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.TextBox tbcod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}