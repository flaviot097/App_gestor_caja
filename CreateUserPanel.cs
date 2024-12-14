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
    public partial class CreateUserPanel : Form
    {
        public PanelPrincipal _principal;
        public Login _login;
        private string _panelbefore;
        public CreateUserPanel(string panel)
        {
            InitializeComponent();
            this.CenterToScreen();
            _panelbefore = panel;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string user = userName.Text;
            string passwordUser = password.Text;
            List<User> users = new List<User>();
            users.Add(new User{ Name=user,
                Password=passwordUser,
            });
            BusineesLogicUser busineesLogicUser = new BusineesLogicUser();
            busineesLogicUser.CreateUser(users);

            _principal = new PanelPrincipal(user);
            _principal.Show();
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (_panelbefore == "login")
            {
                LoadPanelLogin();
            }
            else
            {
                LoadPanelPrincipal();
            }
            this.Close();
        }

        private void LoadPanelPrincipal()
        {
            _principal = new PanelPrincipal(null);
            _principal.Show();
        }
        private void LoadPanelLogin()
        {
            _login = new Login();
            _login.Show();
        }
    }
}
