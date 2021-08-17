
namespace BodegasAgricolas.Vista
{
    partial class VistaVerVentasEnca
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
            this.tablaVentasEnca = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentasEnca)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentasEnca
            // 
            this.tablaVentasEnca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentasEnca.Location = new System.Drawing.Point(12, 55);
            this.tablaVentasEnca.Name = "tablaVentasEnca";
            this.tablaVentasEnca.Size = new System.Drawing.Size(544, 278);
            this.tablaVentasEnca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ver encabezado de ventas";
            // 
            // VistaVerVentasEnca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaVentasEnca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaVerVentasEnca";
            this.Text = "VistaVerVentasEnca";
            this.Load += new System.EventHandler(this.VistaVerVentasEnca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentasEnca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVentasEnca;
        private System.Windows.Forms.Label label1;
    }
}