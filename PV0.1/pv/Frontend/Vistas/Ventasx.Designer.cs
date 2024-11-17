using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using pv.Backend;

namespace pv.Frontend.Vistas
{
    partial class Ventasx
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnback = new System.Windows.Forms.Button();
            this.dtventas = new System.Windows.Forms.DataGridView();
            this.lblhello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtventas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(25, 479);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 35);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // dtventas
            // 
            this.dtventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtventas.Location = new System.Drawing.Point(56, 98);
            this.dtventas.Name = "dtventas";
            this.dtventas.RowHeadersWidth = 62;
            this.dtventas.RowTemplate.Height = 28;
            this.dtventas.Size = new System.Drawing.Size(1146, 331);
            this.dtventas.TabIndex = 4;
            this.dtventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtventas_CellContentClick);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Font = new System.Drawing.Font("Wide Latin", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhello.Location = new System.Drawing.Point(-11, 14);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(835, 64);
            this.lblhello.TabIndex = 5;
            this.lblhello.Text = "Ventas Realizadas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.dtventas);
            this.panel1.Location = new System.Drawing.Point(0, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 618);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 543);
            this.Controls.Add(this.panel1);
            this.Name = "VentasDiarias";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentasDiarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtventas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView dtventas;
        private System.Windows.Forms.Label lblhello;
        private Panel panel1;
    }
}
