namespace App_gestor_caja
{
    partial class Login
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
            this.iconButton = new FontAwesome.Sharp.IconButton();
            this.labelName = new System.Windows.Forms.Label();
            this.stringUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.stringPasword = new System.Windows.Forms.TextBox();
            this.labelTxt = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.createUserLabelBTN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButton
            // 
            this.iconButton.AutoSize = true;
            this.iconButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconButton.CausesValidation = false;
            this.iconButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconButton.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconButton.IconColor = System.Drawing.Color.Black;
            this.iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton.IconSize = 200;
            this.iconButton.Location = new System.Drawing.Point(-3, -1);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(213, 451);
            this.iconButton.TabIndex = 0;
            this.iconButton.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(229, 170);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 23);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Usuario";
            // 
            // stringUser
            // 
            this.stringUser.Location = new System.Drawing.Point(337, 173);
            this.stringUser.Name = "stringUser";
            this.stringUser.Size = new System.Drawing.Size(166, 20);
            this.stringUser.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(229, 240);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(102, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Contraseña";
            this.labelPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // stringPasword
            // 
            this.stringPasword.Location = new System.Drawing.Point(337, 241);
            this.stringPasword.Name = "stringPasword";
            this.stringPasword.PasswordChar = '*';
            this.stringPasword.Size = new System.Drawing.Size(166, 20);
            this.stringPasword.TabIndex = 4;
            this.stringPasword.Tag = "";
            // 
            // labelTxt
            // 
            this.labelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxt.Location = new System.Drawing.Point(271, 97);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(188, 26);
            this.labelTxt.TabIndex = 5;
            this.labelTxt.Text = "Ingresar al Sistema";
            this.labelTxt.UseCompatibleTextRendering = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Location = new System.Drawing.Point(232, 304);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(119, 27);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Ingresar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.BackColor = System.Drawing.Color.Red;
            this.ButtonCancelar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ButtonCancelar.Location = new System.Drawing.Point(381, 304);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(122, 27);
            this.ButtonCancelar.TabIndex = 7;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // createUserLabelBTN
            // 
            this.createUserLabelBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserLabelBTN.AutoSize = true;
            this.createUserLabelBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createUserLabelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabelBTN.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createUserLabelBTN.Location = new System.Drawing.Point(323, 356);
            this.createUserLabelBTN.Name = "createUserLabelBTN";
            this.createUserLabelBTN.Size = new System.Drawing.Size(83, 15);
            this.createUserLabelBTN.TabIndex = 8;
            this.createUserLabelBTN.Text = "Crear Usuario";
            this.createUserLabelBTN.Click += new System.EventHandler(this.createUserLabelBTN_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(517, 448);
            this.Controls.Add(this.createUserLabelBTN);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.stringPasword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.stringUser);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.iconButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox stringPassword;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonIN;
        private System.Windows.Forms.Button buttonCancel;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconButton iconButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox stringUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox stringPasword;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Label createUserLabelBTN;
    }
}