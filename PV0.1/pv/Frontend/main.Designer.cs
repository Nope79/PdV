namespace pv.Frontend
{
    partial class main
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
            this.btnCRUDP = new System.Windows.Forms.Button();
            this.btnCRUDE = new System.Windows.Forms.Button();
            this.btnventasd = new System.Windows.Forms.Button();
            this.btnvender = new System.Windows.Forms.Button();
            this.btnticket = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCRUDP
            // 
            this.btnCRUDP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCRUDP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCRUDP.Location = new System.Drawing.Point(409, 234);
            this.btnCRUDP.Name = "btnCRUDP";
            this.btnCRUDP.Size = new System.Drawing.Size(170, 42);
            this.btnCRUDP.TabIndex = 2;
            this.btnCRUDP.Text = "CRUD_Productos";
            this.btnCRUDP.UseVisualStyleBackColor = false;
            this.btnCRUDP.Click += new System.EventHandler(this.btnCRUDP_Click);
            // 
            // btnCRUDE
            // 
            this.btnCRUDE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCRUDE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCRUDE.Location = new System.Drawing.Point(94, 234);
            this.btnCRUDE.Name = "btnCRUDE";
            this.btnCRUDE.Size = new System.Drawing.Size(170, 42);
            this.btnCRUDE.TabIndex = 3;
            this.btnCRUDE.Text = "CRUD_Empleados";
            this.btnCRUDE.UseVisualStyleBackColor = false;
            this.btnCRUDE.Click += new System.EventHandler(this.btnCRUDE_Click);
            // 
            // btnventasd
            // 
            this.btnventasd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnventasd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnventasd.Location = new System.Drawing.Point(409, 385);
            this.btnventasd.Name = "btnventasd";
            this.btnventasd.Size = new System.Drawing.Size(170, 40);
            this.btnventasd.TabIndex = 4;
            this.btnventasd.Text = "Ventas";
            this.btnventasd.UseVisualStyleBackColor = false;
            this.btnventasd.Click += new System.EventHandler(this.btnventasd_Click);
            // 
            // btnvender
            // 
            this.btnvender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvender.Location = new System.Drawing.Point(94, 87);
            this.btnvender.Name = "btnvender";
            this.btnvender.Size = new System.Drawing.Size(170, 34);
            this.btnvender.TabIndex = 5;
            this.btnvender.Text = "Vender";
            this.btnvender.UseVisualStyleBackColor = false;
            this.btnvender.Click += new System.EventHandler(this.btnvender_Click);
            // 
            // btnticket
            // 
            this.btnticket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnticket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnticket.Location = new System.Drawing.Point(409, 87);
            this.btnticket.Name = "btnticket";
            this.btnticket.Size = new System.Drawing.Size(170, 34);
            this.btnticket.TabIndex = 6;
            this.btnticket.Text = "Tickets";
            this.btnticket.UseVisualStyleBackColor = false;
            this.btnticket.Click += new System.EventHandler(this.btnticket_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnticket);
            this.panel1.Controls.Add(this.btnvender);
            this.panel1.Controls.Add(this.btnCRUDP);
            this.panel1.Controls.Add(this.btnventasd);
            this.panel1.Controls.Add(this.btnCRUDE);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 489);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(16, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCRUDP;
        private System.Windows.Forms.Button btnCRUDE;
        private System.Windows.Forms.Button btnventasd;
        private System.Windows.Forms.Button btnvender;
        private System.Windows.Forms.Button btnticket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}