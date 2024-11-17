namespace pv.Frontend.Ventas
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.btnback = new System.Windows.Forms.Button();
            this.dtventa = new System.Windows.Forms.DataGridView();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tbcod = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpaga = new System.Windows.Forms.Label();
            this.btnventa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblimpuestos = new System.Windows.Forms.Label();
            this.lblcajero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbpago = new System.Windows.Forms.ComboBox();
            this.tbpaga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtventa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(72, 22);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 31);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dtventa
            // 
            this.dtventa.AllowUserToAddRows = false;
            this.dtventa.AllowUserToDeleteRows = false;
            this.dtventa.AllowUserToOrderColumns = true;
            this.dtventa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtventa.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtventa.Location = new System.Drawing.Point(280, 94);
            this.dtventa.MultiSelect = false;
            this.dtventa.Name = "dtventa";
            this.dtventa.RowHeadersWidth = 62;
            this.dtventa.RowTemplate.Height = 28;
            this.dtventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtventa.Size = new System.Drawing.Size(992, 445);
            this.dtventa.TabIndex = 2;
            this.dtventa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtventa_CellClick);
            this.dtventa.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtventa_CellValidating);
            this.dtventa.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtventa_RowsAdded);
            this.dtventa.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtventa_RowsRemoved);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfecha.Location = new System.Drawing.Point(986, 38);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(210, 20);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "Fecha: 0000-00-00 00:00:00";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltotal.Location = new System.Drawing.Point(949, 22);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(59, 20);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "TOTAL";
            // 
            // tbcod
            // 
            this.tbcod.Location = new System.Drawing.Point(32, 103);
            this.tbcod.MaxLength = 13;
            this.tbcod.Name = "tbcod";
            this.tbcod.Size = new System.Drawing.Size(115, 26);
            this.tbcod.TabIndex = 6;
            this.tbcod.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(180, 94);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 35);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Añadir";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(32, 279);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 32);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo del producto";
            // 
            // lblpaga
            // 
            this.lblpaga.AutoSize = true;
            this.lblpaga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblpaga.Location = new System.Drawing.Point(209, 22);
            this.lblpaga.Name = "lblpaga";
            this.lblpaga.Size = new System.Drawing.Size(46, 20);
            this.lblpaga.TabIndex = 11;
            this.lblpaga.Text = "Paga";
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnventa.Enabled = false;
            this.btnventa.Location = new System.Drawing.Point(32, 151);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(115, 56);
            this.btnventa.TabIndex = 13;
            this.btnventa.Text = "Realizar venta";
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblcajero);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtventa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.tbcod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbpago);
            this.panel1.Controls.Add(this.tbpaga);
            this.panel1.Controls.Add(this.btnventa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 628);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.btnback);
            this.panel3.Controls.Add(this.lblpaga);
            this.panel3.Controls.Add(this.lblsubtotal);
            this.panel3.Controls.Add(this.lblimpuestos);
            this.panel3.Controls.Add(this.lbltotal);
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 76);
            this.panel3.TabIndex = 22;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(397, 22);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(69, 20);
            this.lblsubtotal.TabIndex = 17;
            this.lblsubtotal.Text = "Subtotal";
            // 
            // lblimpuestos
            // 
            this.lblimpuestos.AutoSize = true;
            this.lblimpuestos.Location = new System.Drawing.Point(628, 22);
            this.lblimpuestos.Name = "lblimpuestos";
            this.lblimpuestos.Size = new System.Drawing.Size(84, 20);
            this.lblimpuestos.TabIndex = 18;
            this.lblimpuestos.Text = "Impuestos";
            // 
            // lblcajero
            // 
            this.lblcajero.AutoSize = true;
            this.lblcajero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcajero.Font = new System.Drawing.Font("Onyx", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcajero.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblcajero.Location = new System.Drawing.Point(12, 506);
            this.lblcajero.Name = "lblcajero";
            this.lblcajero.Size = new System.Drawing.Size(66, 33);
            this.lblcajero.TabIndex = 21;
            this.lblcajero.Text = "Cajero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Onyx", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Elije los elementos de la tabla";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 78);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Realizado en el ITSUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Punto de Venta";
            // 
            // cbpago
            // 
            this.cbpago.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbpago.FormattingEnabled = true;
            this.cbpago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito",
            "Tarjeta de Débito",
            "Transferencia Bancaria",
            "Otro"});
            this.cbpago.Location = new System.Drawing.Point(18, 359);
            this.cbpago.Name = "cbpago";
            this.cbpago.Size = new System.Drawing.Size(183, 28);
            this.cbpago.TabIndex = 16;
            this.cbpago.Text = "Método Pago";
            this.cbpago.Visible = false;
            this.cbpago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbpaga
            // 
            this.tbpaga.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbpaga.Location = new System.Drawing.Point(32, 407);
            this.tbpaga.MaxLength = 11;
            this.tbpaga.Name = "tbpaga";
            this.tbpaga.Size = new System.Drawing.Size(143, 26);
            this.tbpaga.TabIndex = 15;
            this.tbpaga.Text = "Ingrese la cantidad";
            this.tbpaga.Visible = false;
            this.tbpaga.TextChanged += new System.EventHandler(this.tbpaga_TextChanged_1);
            this.tbpaga.Enter += new System.EventHandler(this.tbpaga_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(442, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(818, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(715, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pv.Properties.Resources.logo_4;
            this.pictureBox2.Location = new System.Drawing.Point(573, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 617);
            this.Controls.Add(this.panel1);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola!";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtventa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dtventa;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox tbcod;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpaga;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbpaga;
        private System.Windows.Forms.ComboBox cbpago;
        private System.Windows.Forms.Label lblimpuestos;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblcajero;
        private System.Windows.Forms.Panel panel3;
    }
}