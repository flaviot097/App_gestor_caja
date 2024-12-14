using SpreadsheetLight;
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
    public partial class ReportsPanel : Form
    {
        public ReportsPanel()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void btnDownloandReports_Click(object sender, EventArgs e)
        {
            Reports_Load();
        }
        public void Reports_Load()
        {
            // ruta de mi proyecto para guardar exel
            string routePathFile = AppDomain.CurrentDomain.BaseDirectory + "reporte.xlsx";

            BusinesLogic _businesLogic = new BusinesLogic();
            //creo una lista de productos
            List<Product> products = new List<Product>();
            products = _businesLogic.getAllProduct();

            SLDocument sLDocument = new SLDocument();
            DataTable table = new DataTable();

            table.Columns.Add("Productos",typeof(string));
            table.Columns.Add("Codigo de Barra", typeof(string));
            table.Columns.Add("price",typeof(decimal));

            foreach (var product in products)
            {
                table.Rows.Add(product.name_product, product.Code_bar, product.price);
            }
            sLDocument.ImportDataTable(1,1,table,true);
            sLDocument.SaveAs(routePathFile);

        }


        private void btnReportsRead_Click(object sender, EventArgs e)
        {
            CreateReportToDB();
        }




        public void CreateReportToDB()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DataTable table = new DataTable();

            fileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            fileDialog.Multiselect = false;
            fileDialog.Title = "Seleccione Reporte";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileDialog.FileName;

                try
                {
                    SLDocument sl = new SLDocument(filePath);
                    string sheetName = sl.GetSheetNames().FirstOrDefault();
                    sl.SelectWorksheet(sheetName);

                    int colIndex = 1;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(1, colIndex)))
                    {
                        table.Columns.Add(sl.GetCellValueAsString(1, colIndex));
                        colIndex++;
                    }

                    int rowIndex = 2;
                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(rowIndex, 1)))
                    {
                        DataRow rowData = table.NewRow();
                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            rowData[i] = sl.GetCellValueAsString(rowIndex, i + 1);
                        }
                        table.Rows.Add(rowData);
                        rowIndex++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el archivo: {ex.Message}", "Error");
                }

                // Asignar la tabla al DataGridView
                if (table.Rows.Count > 0)
                {
                    dateGridviewProd.DataSource = table;
                }
                else
                {
                    MessageBox.Show("El archivo esta vacio.", "Advertencia");
                }
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            // Funcionalidad cargar los productos de el exel abierto a una base de datos
        }
    }
}
