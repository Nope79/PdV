namespace pv.Frontend.Vistas
{
    partial class VentaHecha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.dtticket = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.cbopcion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.dtticket);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.cbopcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 460);
            this.panel1.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(15, 403);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(174, 36);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dtticket
            // 
            this.dtticket.AllowUserToAddRows = false;
            this.dtticket.AllowUserToDeleteRows = false;
            this.dtticket.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtticket.Location = new System.Drawing.Point(242, 46);
            this.dtticket.Name = "dtticket";
            this.dtticket.ReadOnly = true;
            this.dtticket.RowHeadersWidth = 62;
            this.dtticket.RowTemplate.Height = 28;
            this.dtticket.Size = new System.Drawing.Size(1001, 363);
            this.dtticket.TabIndex = 4;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(70, 178);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 26);
            this.tbid.TabIndex = 3;
            this.tbid.Visible = false;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // cbopcion
            // 
            this.cbopcion.FormattingEnabled = true;
            this.cbopcion.Items.AddRange(new object[] {
            "ID"});
            this.cbopcion.Location = new System.Drawing.Point(25, 93);
            this.cbopcion.Name = "cbopcion";
            this.cbopcion.Size = new System.Drawing.Size(188, 28);
            this.cbopcion.TabIndex = 1;
            this.cbopcion.SelectedIndexChanged += new System.EventHandler(this.cbopcion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por...";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::pv.Properties.Resources._9004860_arrow_direction_left_back_icon;
            this.pictureBox7.Location = new System.Drawing.Point(70, 337);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(67, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // VentaHecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VentaHecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentaHecha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtticket;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.ComboBox cbopcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}