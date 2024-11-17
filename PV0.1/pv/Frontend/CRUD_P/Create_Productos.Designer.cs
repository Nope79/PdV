namespace pv.Frontend
{
    partial class Create_Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncrear = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbprecio = new System.Windows.Forms.TextBox();
            this.tbstock = new System.Windows.Forms.TextBox();
            this.tbmarca = new System.Windows.Forms.TextBox();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.tbpeso = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbiva = new System.Windows.Forms.TextBox();
            this.lbliva = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(34, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(34, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(34, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(34, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio";
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncrear.Location = new System.Drawing.Point(227, 485);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(147, 48);
            this.btncrear.TabIndex = 31;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(166, 64);
            this.tbnombre.MaxLength = 40;
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(229, 26);
            this.tbnombre.TabIndex = 0;
            this.tbnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(166, 122);
            this.tbprecio.MaxLength = 11;
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(229, 26);
            this.tbprecio.TabIndex = 33;
            this.tbprecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbprecio_KeyUp);
            // 
            // tbstock
            // 
            this.tbstock.Location = new System.Drawing.Point(166, 237);
            this.tbstock.MaxLength = 9;
            this.tbstock.Name = "tbstock";
            this.tbstock.Size = new System.Drawing.Size(229, 26);
            this.tbstock.TabIndex = 34;
            this.tbstock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbstock_KeyUp);
            // 
            // tbmarca
            // 
            this.tbmarca.Location = new System.Drawing.Point(166, 286);
            this.tbmarca.MaxLength = 30;
            this.tbmarca.Name = "tbmarca";
            this.tbmarca.Size = new System.Drawing.Size(229, 26);
            this.tbmarca.TabIndex = 35;
            this.tbmarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbmarca_KeyUp);
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(166, 338);
            this.tbdescripcion.MaxLength = 65534;
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(229, 26);
            this.tbdescripcion.TabIndex = 36;
            this.tbdescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbdescripcion_KeyUp);
            // 
            // tbpeso
            // 
            this.tbpeso.Location = new System.Drawing.Point(166, 388);
            this.tbpeso.MaxLength = 11;
            this.tbpeso.Name = "tbpeso";
            this.tbpeso.Size = new System.Drawing.Size(229, 26);
            this.tbpeso.TabIndex = 37;
            this.tbpeso.TextChanged += new System.EventHandler(this.tbpeso_TextChanged);
            this.tbpeso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbpeso_KeyUp);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(19, 498);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(109, 35);
            this.btnback.TabIndex = 38;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 634);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbiva
            // 
            this.tbiva.Location = new System.Drawing.Point(166, 184);
            this.tbiva.MaxLength = 5;
            this.tbiva.Name = "tbiva";
            this.tbiva.Size = new System.Drawing.Size(229, 26);
            this.tbiva.TabIndex = 41;
            this.tbiva.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbiva_KeyUp);
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbliva.Location = new System.Drawing.Point(34, 184);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(30, 20);
            this.lbliva.TabIndex = 40;
            this.lbliva.Text = "Iva";
            this.lbliva.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(166, 432);
            this.tbcodigo.MaxLength = 13;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(229, 26);
            this.tbcodigo.TabIndex = 43;
            this.tbcodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbcodigo_KeyUp);
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbcodigo.Location = new System.Drawing.Point(34, 432);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(59, 20);
            this.lbcodigo.TabIndex = 42;
            this.lbcodigo.Text = "Codigo";
            this.lbcodigo.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbnombre);
            this.panel2.Controls.Add(this.btncrear);
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbcodigo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbliva);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbpeso);
            this.panel2.Controls.Add(this.tbprecio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbcodigo);
            this.panel2.Controls.Add(this.tbdescripcion);
            this.panel2.Controls.Add(this.tbmarca);
            this.panel2.Controls.Add(this.tbiva);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbstock);
            this.panel2.Location = new System.Drawing.Point(51, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 547);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 40);
            this.label2.TabIndex = 44;
            this.label2.Text = "Creación de Productos";
            // 
            // Create_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 615);
            this.Controls.Add(this.panel1);
            this.Name = "Create_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.Create_Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbprecio;
        private System.Windows.Forms.TextBox tbstock;
        private System.Windows.Forms.TextBox tbmarca;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.TextBox tbpeso;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbiva;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}