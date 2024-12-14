namespace App_gestor_caja
{
    partial class LoadProductPanel
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
            this.panelText = new System.Windows.Forms.MenuStrip();
            this.textTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stringName = new System.Windows.Forms.TextBox();
            this.stringCodebar = new System.Windows.Forms.TextBox();
            this.decimalStock = new System.Windows.Forms.TextBox();
            this.decimalCost = new System.Windows.Forms.TextBox();
            this.intRevenue = new System.Windows.Forms.TextBox();
            this.intCategory = new System.Windows.Forms.TextBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.stringDescription = new System.Windows.Forms.TextBox();
            this.btnLoadProduct = new FontAwesome.Sharp.IconButton();
            this.btnClean = new FontAwesome.Sharp.IconButton();
            this.imgFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.AutoSize = false;
            this.panelText.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(541, 45);
            this.panelText.TabIndex = 0;
            // 
            // textTitle
            // 
            this.textTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitle.Location = new System.Drawing.Point(167, 95);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(213, 29);
            this.textTitle.TabIndex = 1;
            this.textTitle.Text = "Cargar producto a stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo de barra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ganancia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Descripcion";
            // 
            // stringName
            // 
            this.stringName.Location = new System.Drawing.Point(199, 162);
            this.stringName.Name = "stringName";
            this.stringName.Size = new System.Drawing.Size(297, 20);
            this.stringName.TabIndex = 10;
            // 
            // stringCodebar
            // 
            this.stringCodebar.Location = new System.Drawing.Point(199, 207);
            this.stringCodebar.Name = "stringCodebar";
            this.stringCodebar.Size = new System.Drawing.Size(297, 20);
            this.stringCodebar.TabIndex = 11;
            // 
            // decimalStock
            // 
            this.decimalStock.Location = new System.Drawing.Point(199, 256);
            this.decimalStock.Name = "decimalStock";
            this.decimalStock.Size = new System.Drawing.Size(297, 20);
            this.decimalStock.TabIndex = 12;
            this.decimalStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // decimalCost
            // 
            this.decimalCost.Location = new System.Drawing.Point(199, 304);
            this.decimalCost.Name = "decimalCost";
            this.decimalCost.Size = new System.Drawing.Size(297, 20);
            this.decimalCost.TabIndex = 13;
            // 
            // intRevenue
            // 
            this.intRevenue.Location = new System.Drawing.Point(199, 347);
            this.intRevenue.Name = "intRevenue";
            this.intRevenue.Size = new System.Drawing.Size(297, 20);
            this.intRevenue.TabIndex = 14;
            // 
            // intCategory
            // 
            this.intCategory.Location = new System.Drawing.Point(199, 392);
            this.intCategory.Name = "intCategory";
            this.intCategory.Size = new System.Drawing.Size(297, 20);
            this.intCategory.TabIndex = 15;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(199, 438);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(297, 23);
            this.btnImg.TabIndex = 16;
            this.btnImg.Text = "Cargar imagen";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // stringDescription
            // 
            this.stringDescription.Location = new System.Drawing.Point(199, 478);
            this.stringDescription.Multiline = true;
            this.stringDescription.Name = "stringDescription";
            this.stringDescription.Size = new System.Drawing.Size(297, 60);
            this.stringDescription.TabIndex = 17;
            // 
            // btnLoadProduct
            // 
            this.btnLoadProduct.AutoSize = true;
            this.btnLoadProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProduct.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnLoadProduct.IconColor = System.Drawing.Color.Black;
            this.btnLoadProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadProduct.IconSize = 22;
            this.btnLoadProduct.Location = new System.Drawing.Point(104, 581);
            this.btnLoadProduct.Name = "btnLoadProduct";
            this.btnLoadProduct.Size = new System.Drawing.Size(125, 28);
            this.btnLoadProduct.TabIndex = 18;
            this.btnLoadProduct.Text = "Cargar";
            this.btnLoadProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadProduct.UseVisualStyleBackColor = true;
            this.btnLoadProduct.Click += new System.EventHandler(this.btnLoadProduct_Click);
            // 
            // btnClean
            // 
            this.btnClean.AutoSize = true;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnClean.IconColor = System.Drawing.Color.Black;
            this.btnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClean.IconSize = 22;
            this.btnClean.Location = new System.Drawing.Point(335, 581);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(125, 28);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "Limpiar";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // imgFile
            // 
            this.imgFile.Location = new System.Drawing.Point(495, 439);
            this.imgFile.Name = "imgFile";
            this.imgFile.Size = new System.Drawing.Size(34, 22);
            this.imgFile.TabIndex = 20;
            this.imgFile.TabStop = false;
            // 
            // LoadProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 658);
            this.Controls.Add(this.imgFile);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnLoadProduct);
            this.Controls.Add(this.stringDescription);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.intCategory);
            this.Controls.Add(this.intRevenue);
            this.Controls.Add(this.decimalCost);
            this.Controls.Add(this.decimalStock);
            this.Controls.Add(this.stringCodebar);
            this.Controls.Add(this.stringName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.panelText);
            this.MainMenuStrip = this.panelText;
            this.Name = "LoadProductPanel";
            this.Text = "LoadProductPanel";
            ((System.ComponentModel.ISupportInitialize)(this.imgFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip panelText;
        private System.Windows.Forms.Label textTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stringName;
        private System.Windows.Forms.TextBox stringCodebar;
        private System.Windows.Forms.TextBox decimalStock;
        private System.Windows.Forms.TextBox decimalCost;
        private System.Windows.Forms.TextBox intRevenue;
        private System.Windows.Forms.TextBox intCategory;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.TextBox stringDescription;
        private FontAwesome.Sharp.IconButton btnLoadProduct;
        private FontAwesome.Sharp.IconButton btnClean;
        private System.Windows.Forms.PictureBox imgFile;
    }
}