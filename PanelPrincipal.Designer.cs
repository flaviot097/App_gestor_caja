namespace App_gestor_caja
{
    partial class PanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPrincipal));
            this.textSistem = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnReports = new FontAwesome.Sharp.IconMenuItem();
            this.btnBox = new FontAwesome.Sharp.IconMenuItem();
            this.btnProvider = new FontAwesome.Sharp.IconMenuItem();
            this.btnStock = new FontAwesome.Sharp.IconMenuItem();
            this.btnCreateProd = new FontAwesome.Sharp.IconMenuItem();
            this.btnBuyProduct = new FontAwesome.Sharp.IconMenuItem();
            this.btnCurrentAccount = new FontAwesome.Sharp.IconMenuItem();
            this.welcome = new System.Windows.Forms.Label();
            this.welcomeName = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.siteWeb = new System.Windows.Forms.LinkLabel();
            this.textDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSistem
            // 
            this.textSistem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSistem.AutoSize = false;
            this.textSistem.BackColor = System.Drawing.SystemColors.Highlight;
            this.textSistem.Dock = System.Windows.Forms.DockStyle.None;
            this.textSistem.Location = new System.Drawing.Point(0, 0);
            this.textSistem.Name = "textSistem";
            this.textSistem.Size = new System.Drawing.Size(1131, 41);
            this.textSistem.TabIndex = 0;
            this.textSistem.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Ventas";
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReports,
            this.btnBox,
            this.btnProvider,
            this.btnStock,
            this.btnCreateProd,
            this.btnBuyProduct,
            this.btnCurrentAccount});
            this.menu.Location = new System.Drawing.Point(0, 41);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1131, 72);
            this.menu.TabIndex = 1;
            // 
            // btnReports
            // 
            this.btnReports.AutoSize = false;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnReports.IconColor = System.Drawing.Color.Black;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 50;
            this.btnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReports.Margin = new System.Windows.Forms.Padding(10);
            this.btnReports.Name = "btnReports";
            this.btnReports.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReports.Size = new System.Drawing.Size(62, 62);
            this.btnReports.Text = "Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnBox
            // 
            this.btnBox.AutoSize = false;
            this.btnBox.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnBox.IconColor = System.Drawing.Color.Black;
            this.btnBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBox.IconSize = 50;
            this.btnBox.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBox.Margin = new System.Windows.Forms.Padding(10);
            this.btnBox.Name = "btnBox";
            this.btnBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBox.Size = new System.Drawing.Size(122, 62);
            this.btnBox.Text = "Caja";
            this.btnBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProvider
            // 
            this.btnProvider.AutoSize = false;
            this.btnProvider.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.btnProvider.IconColor = System.Drawing.Color.Black;
            this.btnProvider.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProvider.IconSize = 50;
            this.btnProvider.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProvider.Margin = new System.Windows.Forms.Padding(10);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProvider.Size = new System.Drawing.Size(122, 62);
            this.btnProvider.Text = "Proveedores";
            this.btnProvider.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProvider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnStock
            // 
            this.btnStock.AutoSize = false;
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnStock.IconColor = System.Drawing.Color.Black;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.IconSize = 50;
            this.btnStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStock.Margin = new System.Windows.Forms.Padding(10);
            this.btnStock.Name = "btnStock";
            this.btnStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStock.Size = new System.Drawing.Size(62, 62);
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCreateProd
            // 
            this.btnCreateProd.AutoSize = false;
            this.btnCreateProd.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.btnCreateProd.IconColor = System.Drawing.Color.Black;
            this.btnCreateProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateProd.IconSize = 50;
            this.btnCreateProd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCreateProd.Margin = new System.Windows.Forms.Padding(10);
            this.btnCreateProd.Name = "btnCreateProd";
            this.btnCreateProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreateProd.Size = new System.Drawing.Size(122, 62);
            this.btnCreateProd.Text = "Cargar Producto";
            this.btnCreateProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.AutoSize = false;
            this.btnBuyProduct.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnBuyProduct.IconColor = System.Drawing.Color.Black;
            this.btnBuyProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuyProduct.IconSize = 50;
            this.btnBuyProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuyProduct.Margin = new System.Windows.Forms.Padding(10);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuyProduct.Size = new System.Drawing.Size(122, 62);
            this.btnBuyProduct.Text = "Comprar Productos";
            this.btnBuyProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuyProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCurrentAccount
            // 
            this.btnCurrentAccount.AutoSize = false;
            this.btnCurrentAccount.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btnCurrentAccount.IconColor = System.Drawing.Color.Black;
            this.btnCurrentAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCurrentAccount.IconSize = 50;
            this.btnCurrentAccount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCurrentAccount.Margin = new System.Windows.Forms.Padding(10);
            this.btnCurrentAccount.Name = "btnCurrentAccount";
            this.btnCurrentAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCurrentAccount.Size = new System.Drawing.Size(122, 62);
            this.btnCurrentAccount.Text = "Cuenta corriente";
            this.btnCurrentAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCurrentAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // welcome
            // 
            this.welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(446, 158);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(129, 25);
            this.welcome.TabIndex = 2;
            this.welcome.Text = "Bienvenido";
            this.welcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // welcomeName
            // 
            this.welcomeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeName.Location = new System.Drawing.Point(571, 159);
            this.welcomeName.Name = "welcomeName";
            this.welcomeName.Size = new System.Drawing.Size(174, 27);
            this.welcomeName.TabIndex = 3;
            this.welcomeName.Text = "dasdasdasdas";
            this.welcomeName.Click += new System.EventHandler(this.welcomeName_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreateUser.Location = new System.Drawing.Point(545, 497);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(92, 23);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Crear usuario";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // siteWeb
            // 
            this.siteWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.siteWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteWeb.Location = new System.Drawing.Point(523, 436);
            this.siteWeb.Name = "siteWeb";
            this.siteWeb.Size = new System.Drawing.Size(130, 19);
            this.siteWeb.TabIndex = 5;
            this.siteWeb.TabStop = true;
            this.siteWeb.Text = "www.GeDenS.com.ar";
            // 
            // textDescription
            // 
            this.textDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.Location = new System.Drawing.Point(335, 205);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(510, 112);
            this.textDescription.TabIndex = 6;
            this.textDescription.Text = resources.GetString("textDescription.Text");
            this.textDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nuestro sitio Web:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Cuenta con un usiario?. Sino cree uno.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(506, 62);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cree un usuario si no cuenta con uno y comience a utilizar GeDenS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1131, 641);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.siteWeb);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.welcomeName);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSistem);
            this.Controls.Add(this.menu);
            this.Name = "PanelPrincipal";
            this.Text = "PanelPrincipal";
            this.Load += new System.EventHandler(this.PanelPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip textSistem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem btnBox;
        private FontAwesome.Sharp.IconMenuItem btnStock;
        private FontAwesome.Sharp.IconMenuItem btnReports;
        private FontAwesome.Sharp.IconMenuItem btnCurrentAccount;
        private FontAwesome.Sharp.IconMenuItem btnProvider;
        private FontAwesome.Sharp.IconMenuItem btnCreateProd;
        private FontAwesome.Sharp.IconMenuItem btnBuyProduct;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label welcomeName;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.LinkLabel siteWeb;
        private System.Windows.Forms.Label textDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}