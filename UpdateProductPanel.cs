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
    public partial class UpdateProductPanel : Form
    {
        int id;
        
        // Creo un evento tipo publico de una accion que cuando la llame actualiceo pueda la table ejecutandolo en StockPanel
        public event Action UdateTable;


        public UpdateProductPanel(List<Product> product,int id)
        {
            InitializeComponent();
            this.CenterToScreen();
            loadProduct(product);
            this.id = id;
        }
        

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            List<Product> listItemProduct = new List<Product>();
            listItemProduct.Add(new Product
            {
                price = decimal.Parse(decimalCost.Text) + (decimal.Parse(decimalCost.Text) * decimal.Parse(intRevenue.Text) / 100),
                Code_bar = stringCodebar.Text,
                id_category =int.Parse(intCategory.Text),
                name_product= stringName.Text,
                cost=decimal.Parse(decimalCost.Text),
                margin_revenue= int.Parse(intRevenue.Text),
                stock=decimal.Parse(decimalStock.Text),
                description_product= stringDescription.Text,
            });
            UpdateProductLogig(listItemProduct,id);
        }
        private void loadProduct(List<Product> product) {
            if (product != null) {
                stringCodebar.Text = product[0].Code_bar;
                stringDescription.Text = product[0].description_product;
                intCategory.Text = product[0].id_category.ToString();
                intRevenue.Text = product[0].margin_revenue.ToString();
                decimalCost.Text= product[0].cost.ToString();
                decimalStock.Text= product[0].stock.ToString();
                stringName.Text = product[0].name_product;
            }
        }
        private void UpdateProductLogig(List<Product> itemsProduct, int id)
        {
            BusinesLogic businesLogic = new BusinesLogic();
            businesLogic.UpdateProductLogic(itemsProduct,id);

            // Una vez hecha la actualizacion invoco UdateTable para poder ejecutar la funcion lambda en stockPanel
            UdateTable?.Invoke();
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            stringCodebar.Text = string.Empty;
            stringDescription.Text = string.Empty;
            intCategory.Text = string.Empty;
            intRevenue.Text = string.Empty;
            decimalCost.Text = string.Empty;
            decimalStock.Text = string.Empty;
            stringName.Text = string.Empty;
        }
    }
}
