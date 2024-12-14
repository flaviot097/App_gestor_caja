namespace App_gestor_caja
{
    partial class StockPanel
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
            this.components = new System.ComponentModel.Container();
            this.tableStock = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.stringName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stringCodebar = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codebarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marginrevenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableStock
            // 
            this.tableStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableStock.AutoGenerateColumns = false;
            this.tableStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.nameproductDataGridViewTextBoxColumn,
            this.codebarDataGridViewTextBoxColumn,
            this.descriptionproductDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.marginrevenueDataGridViewTextBoxColumn,
            this.idcategoryDataGridViewTextBoxColumn});
            this.tableStock.DataSource = this.productBindingSource;
            this.tableStock.Location = new System.Drawing.Point(12, 127);
            this.tableStock.Name = "tableStock";
            this.tableStock.ReadOnly = true;
            this.tableStock.Size = new System.Drawing.Size(1054, 459);
            this.tableStock.TabIndex = 0;
            this.tableStock.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableStock_CellMouseClick);
            this.tableStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableStock_MouseClick);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(243, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(79, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Nombre";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // stringName
            // 
            this.stringName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stringName.Location = new System.Drawing.Point(328, 36);
            this.stringName.Name = "stringName";
            this.stringName.Size = new System.Drawing.Size(236, 20);
            this.stringName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(408, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(177, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClean.Location = new System.Drawing.Point(641, 83);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(177, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // stringCodebar
            // 
            this.stringCodebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stringCodebar.Location = new System.Drawing.Point(664, 36);
            this.stringCodebar.Name = "stringCodebar";
            this.stringCodebar.Size = new System.Drawing.Size(236, 20);
            this.stringCodebar.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreate.Location = new System.Drawing.Point(1072, 239);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 33);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Cargar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Location = new System.Drawing.Point(1072, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(1072, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "Id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "Id_product";
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameproductDataGridViewTextBoxColumn
            // 
            this.nameproductDataGridViewTextBoxColumn.DataPropertyName = "name_product";
            this.nameproductDataGridViewTextBoxColumn.HeaderText = "name_product";
            this.nameproductDataGridViewTextBoxColumn.Name = "nameproductDataGridViewTextBoxColumn";
            this.nameproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codebarDataGridViewTextBoxColumn
            // 
            this.codebarDataGridViewTextBoxColumn.DataPropertyName = "Code_bar";
            this.codebarDataGridViewTextBoxColumn.HeaderText = "Code_bar";
            this.codebarDataGridViewTextBoxColumn.Name = "codebarDataGridViewTextBoxColumn";
            this.codebarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionproductDataGridViewTextBoxColumn
            // 
            this.descriptionproductDataGridViewTextBoxColumn.DataPropertyName = "description_product";
            this.descriptionproductDataGridViewTextBoxColumn.HeaderText = "description_product";
            this.descriptionproductDataGridViewTextBoxColumn.Name = "descriptionproductDataGridViewTextBoxColumn";
            this.descriptionproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marginrevenueDataGridViewTextBoxColumn
            // 
            this.marginrevenueDataGridViewTextBoxColumn.DataPropertyName = "margin_revenue";
            this.marginrevenueDataGridViewTextBoxColumn.HeaderText = "margin_revenue";
            this.marginrevenueDataGridViewTextBoxColumn.Name = "marginrevenueDataGridViewTextBoxColumn";
            this.marginrevenueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcategoryDataGridViewTextBoxColumn
            // 
            this.idcategoryDataGridViewTextBoxColumn.DataPropertyName = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.HeaderText = "id_category";
            this.idcategoryDataGridViewTextBoxColumn.Name = "idcategoryDataGridViewTextBoxColumn";
            this.idcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(App_gestor_caja.Product);
            // 
            // StockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 678);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.stringCodebar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.stringName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tableStock);
            this.Name = "StockPanel";
            this.Text = "StockPanel";
            this.Load += new System.EventHandler(this.StockPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableStock;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox stringName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringCodebar;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codebarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marginrevenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoryDataGridViewTextBoxColumn;
    }
}