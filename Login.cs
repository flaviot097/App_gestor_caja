using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_gestor_caja
{
    public partial class Login : Form
    {
        public event Action CloseWindows;
        BusineesLogicUser _busineesLogicUser;
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user= stringUser.Text;
            
            _busineesLogicUser = new BusineesLogicUser();
            string password = _busineesLogicUser.GetUserLogicName(stringUser.Text);
            
            if(password != "" && password == stringPasword.Text)
            {
                PanelPrincipal panel = new PanelPrincipal(user);
                this.Hide();
                panel.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorectos", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
         }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createUserLabelBTN_Click(object sender, EventArgs e)
        {
            string panel = "login";
            CreateUserPanel userPanelCrate= new CreateUserPanel(panel);
            userPanelCrate.Show();
            this.Hide();
        }
    }
}
