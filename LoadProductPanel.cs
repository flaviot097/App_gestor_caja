using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_gestor_caja
{
    public partial class LoadProductPanel : Form
    {
        private BusinesLogic _BusinesLogic;
        public LoadProductPanel()
        {
            InitializeComponent();
            this.CenterToScreen();
            _BusinesLogic = new BusinesLogic();
        }
        public bool status=false;
        public string uniqueFileName;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            createFolder();
            string productPath = Application.StartupPath + @"\imgProducts";
            System.Windows.Forms.OpenFileDialog saveFileDialog = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog.Filter = "Archivos de imagen (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar imagen de producto";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Carga la imagen seleccionada en el PictureBox
                imgFile.Image = Image.FromFile(saveFileDialog.FileName);

                //Consulto el nombre de la imagen
                string fileName = Path.GetFileName(saveFileDialog.FileName);
                // Generar un nombre único para el archivo
                uniqueFileName = Path.Combine(productPath, Guid.NewGuid() + "_" + fileName);

                // Guarda la imagen en la carpeta
                //imgFile.Image.Save(uniqueFileName);
                try { 
                    MessageBox.Show("Se cargo correctamente la imagen"); 
                    status = true;
                }
                catch(Exception exs) {
                    MessageBox.Show("Error:" +exs);
                }
            }

            //imgFile.Image.Save(stream, ImageFormat.Jpeg);
            //byte[] data = stream.ToArray();

        }

        private void btnLoadProduct_Click(object sender, EventArgs e)
        {
            if (status == false && stringName.Text == "" && intCategory.Text == "" && stringCodebar.Text == "" && intRevenue.Text == "" && decimalCost.Text == "" && decimalStock.Text == "")
            {
                MessageBox.Show("Debe complentar todos los campos son obligatrorios ,excepto el campo 'descricion'");
            }
            else
            { 
                saveProductPesentation();

            }
            
        }

        private void saveProductPesentation()
        {
                Product product = new Product();
                product.cost = (decimal)float.Parse(decimalCost.Text);
                product.margin_revenue = int.Parse(intRevenue.Text);
                product.price = decimal.Parse(decimalCost.Text) + (decimal.Parse(decimalCost.Text) * decimal.Parse(intRevenue.Text)/100);
                product.name_product = stringName.Text;
                product.Code_bar = stringCodebar.Text;
                product.id_category = int.Parse(intCategory.Text);
                product.description_product = stringDescription.Text;
                product.RouteImg = uniqueFileName;
                product.stock = decimal.Parse(decimalStock.Text);
                // Guarda la imagen en la carpeta
                imgFile.Image.Save(uniqueFileName);

                // Pasa los datos a la capa Business
                _BusinesLogic.save(product);
        }

        public void createFolder()
        {
            string imgProduct = Application.StartupPath + @"\imgProducts";
            try
            {
                if (!Directory.Exists(imgProduct)) {
                    MessageBox.Show("Se ha creado una carpeta para almacenar las imagenes");
                    Directory.CreateDirectory(imgProduct);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("se produjo un error. Error: "+e);
            }
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
