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
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal(string user)
        {
            InitializeComponent();
            this.CenterToScreen();
            welcomeName.Text = string.Empty;
            welcomeName.Text = user;
        }

        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
            FormClosed += closedPanel;
        }
        public void closedPanel(object sender, FormClosedEventArgs e)
        {
            Login panelLogin = new Login();
            panelLogin.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockPanel panelStock = new StockPanel();
            panelStock.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsPanel panelReports = new ReportsPanel();
            panelReports.Show();
        }

        private void loginClosing() {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void welcomeName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string viewPanel = "principal";
            CreateUserPanel panel = new CreateUserPanel(viewPanel);
            panel.Show();
            this.Hide();
        }
    }
}
