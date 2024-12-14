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
    public partial class StockPanel : Form
    {
        private BusinesLogic _BusinessLogic;
        private int id_product;
        public StockPanel()
        {
            InitializeComponent();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            LoadProductPanel loadProductPanel = new LoadProductPanel();
            loadProductPanel.Show();
            this.Hide();
        }

        private void StockPanel_Load(object sender, EventArgs e)
        {
            LoadAllProductPanel();
            this.CenterToScreen();
            //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            //this.WindowState = FormWindowState.Maximized;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProduct(stringName.Text);
        }



        public void tableStock_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {

                DataGridViewRow selectData = tableStock.Rows[e.RowIndex];
                this.id_product = Convert.ToInt32(selectData.Cells[0].Value);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProdcut(id_product);

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct(id_product);
            LoadAllProductPanel();
        }

        private void tableStock_MouseClick(object sender, MouseEventArgs e)
        {
           
            //MessageBox.Show("hola la celda seleccionada es ");
        }

        public void LoadAllProductPanel() {
            _BusinessLogic = new BusinesLogic();
            List<Product> products = _BusinessLogic.getAllProduct();
            tableStock.DataSource = products;
        }

        public void LoadProduct(string name)
        {
            _BusinessLogic = new BusinesLogic();
            List<Product> product = _BusinessLogic.getProduct(name);
            tableStock.DataSource = product;
        }

        public void UpdateProdcut(int idProduct)
        {
            if (idProduct != 0) { 
            _BusinessLogic=new BusinesLogic();
            List<Product> productSelectionate = _BusinessLogic.UpdateSelectProductLogic(id_product);
            UpdateProductPanel panelProductUpdate= new UpdateProductPanel(productSelectionate, id_product);
                
                // Si este se utilizo el evento Udatetable en algun momento se utilizara la tabla
             panelProductUpdate.UdateTable += () =>
             {
                    LoadAllProductPanel(); 
             };

                panelProductUpdate.Show();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //this.Close();
        }
        public void DeleteProduct(int idProduct)
        {
            if (idProduct != 0) { 
            _BusinessLogic = new BusinesLogic();
            _BusinessLogic.DeleteProductID(idProduct);
            }
            else
            {
                MessageBox.Show("Por favor slecciona un producto para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
