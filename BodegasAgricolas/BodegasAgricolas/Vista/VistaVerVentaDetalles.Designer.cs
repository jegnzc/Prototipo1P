
namespace BodegasAgricolas.Vista
{
    partial class VistaVerVentaDetalles
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
            this.tablaVerDetalles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVerDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVerDetalles
            // 
            this.tablaVerDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVerDetalles.Location = new System.Drawing.Point(12, 70);
            this.tablaVerDetalles.Name = "tablaVerDetalles";
            this.tablaVerDetalles.Size = new System.Drawing.Size(544, 263);
            this.tablaVerDetalles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalles de ventas";
            // 
            // VistaVerVentaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaVerDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaVerVentaDetalles";
            this.Text = "VistaVerVentaDetalles";
            this.Load += new System.EventHandler(this.VistaVerVentaDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVerDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVerDetalles;
        private System.Windows.Forms.Label label1;
    }
}