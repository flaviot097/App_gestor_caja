namespace App_gestor_caja
{
    partial class ReportsPanel
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
            this.btnDownloandReports = new System.Windows.Forms.Button();
            this.btnReportsRead = new System.Windows.Forms.Button();
            this.dateGridviewProd = new System.Windows.Forms.DataGridView();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridviewProd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloandReports
            // 
            this.btnDownloandReports.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDownloandReports.Location = new System.Drawing.Point(12, 587);
            this.btnDownloandReports.Name = "btnDownloandReports";
            this.btnDownloandReports.Size = new System.Drawing.Size(186, 37);
            this.btnDownloandReports.TabIndex = 0;
            this.btnDownloandReports.Text = "Descargar Reporte";
            this.btnDownloandReports.UseVisualStyleBackColor = true;
            this.btnDownloandReports.Click += new System.EventHandler(this.btnDownloandReports_Click);
            // 
            // btnReportsRead
            // 
            this.btnReportsRead.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReportsRead.Location = new System.Drawing.Point(411, 587);
            this.btnReportsRead.Name = "btnReportsRead";
            this.btnReportsRead.Size = new System.Drawing.Size(169, 37);
            this.btnReportsRead.TabIndex = 1;
            this.btnReportsRead.Text = "leer Reporte";
            this.btnReportsRead.UseVisualStyleBackColor = true;
            this.btnReportsRead.Click += new System.EventHandler(this.btnReportsRead_Click);
            // 
            // dateGridviewProd
            // 
            this.dateGridviewProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateGridviewProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dateGridviewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateGridviewProd.Location = new System.Drawing.Point(90, 77);
            this.dateGridviewProd.Name = "dateGridviewProd";
            this.dateGridviewProd.Size = new System.Drawing.Size(426, 420);
            this.dateGridviewProd.TabIndex = 2;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(222, 587);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(163, 37);
            this.btnCreateProduct.TabIndex = 3;
            this.btnCreateProduct.Text = "Cargar Productos";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // ReportsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 677);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.dateGridviewProd);
            this.Controls.Add(this.btnReportsRead);
            this.Controls.Add(this.btnDownloandReports);
            this.Name = "ReportsPanel";
            this.Text = "ReportsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dateGridviewProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloandReports;
        private System.Windows.Forms.Button btnReportsRead;
        private System.Windows.Forms.DataGridView dateGridviewProd;
        private System.Windows.Forms.Button btnCreateProduct;
    }
}