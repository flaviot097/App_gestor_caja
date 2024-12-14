using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    public class BusinesLogic
    {
        private DataAccessLayer dataAccess = new DataAccessLayer();

        public void save(Product product)
        {
            dataAccess.InsertDataLayer(product);
            //throw new NotImplementedException();
        }

        public List<Product> getAllProduct()
        {
            return dataAccess.getAllProductDB();
            //throw new NotImplementedException();
        }

        public List<Product> getProduct(string name)
        {
            return dataAccess.getProductDB(name);
            //throw new NotImplementedException();
        }

        public List<Product> UpdateSelectProductLogic(int id_product)
        {
            return dataAccess.UpdateSelectProductDB(id_product);
            //throw new NotImplementedException();
        }

        internal void UpdateProductLogic(List<Product> itemsProduct,int id)
        {
            dataAccess.UpdateProductDB(itemsProduct,id);
            //throw new NotImplementedException();
        }

        internal void DeleteProductID(int idProduct)
        {
            dataAccess.DeleteProductIdDB(idProduct);
            //throw new NotImplementedException();
        }
    }
}
