using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace App_gestor_caja
{
    // Acceso a la base de datos 
    public class DataAccessLayer
    {
        // "Preparo la conencion pasandole la cadena de coneccion"
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=App_gestor_caja;Data Source=DESKTOP-SEVLBL8");
       
        public void InsertDataLayer(Product product)
        {
            try
            {
                // Se abre la coneccion a la DB
                conn.Open();

                // Se genera la Consulta
                string queryInsertProduct = @"INSERT INTO Product (name_product,Code_bar,RouteImg,description_product,stock,price,cost,margin_revenue,id_category)
                                              VALUES (@name_product,@Code_bar,@RouteImg,@description_product,@stock,@price,@cost,@margin_revenue,@id_category)";

                // Se le pasan o bindean los parametros correspondientes
                SqlParameter name = new SqlParameter("@name_product", product.name_product);
                SqlParameter codebar = new SqlParameter("@Code_bar", product.Code_bar);
                SqlParameter route = new SqlParameter("@RouteImg", product.RouteImg);
                SqlParameter description = new SqlParameter("@description_product", product.description_product);
                SqlParameter stock = new SqlParameter("@stock", product.stock);
                SqlParameter cost = new SqlParameter("@cost", product.cost);
                SqlParameter price = new SqlParameter("@price", product.price);
                SqlParameter marginRevenue = new SqlParameter("@margin_revenue", product.margin_revenue);
                SqlParameter idCategory = new SqlParameter("@id_category", product.id_category);

                // Se agregan los parametros respectivos a la consulta
                SqlCommand cmd = new SqlCommand(queryInsertProduct, conn);
                cmd.Parameters.Add(name);
                cmd.Parameters.Add(codebar);
                cmd.Parameters.Add(route);
                cmd.Parameters.Add(description);
                cmd.Parameters.Add(stock);
                cmd.Parameters.Add(cost);
                cmd.Parameters.Add(price);
                cmd.Parameters.Add(idCategory);
                cmd.Parameters.Add(marginRevenue);

                // Se realiza la consulta
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            //throw new NotImplementedException();
        }

        public List<Product> getAllProductDB()
        {
            List<Product> listProduct = new List<Product>();
            try
            {
                conn.Open();
                string querySQL = @"SELECT * FROM Product";
                SqlCommand cmdG = new SqlCommand(querySQL, conn);
                SqlDataReader reader = cmdG.ExecuteReader();
                while (reader.Read()) {
                    listProduct.Add(new Product
                    {
                        id_category = int.Parse(reader["id_product"].ToString()),
                        Code_bar = reader["Code_bar"].ToString(),
                        name_product = reader["name_product"].ToString(),
                        RouteImg = reader["RouteImg"].ToString(),
                        stock = decimal.Parse(reader["stock"].ToString()),
                        cost= decimal.Parse(reader["cost"].ToString()),
                        price = decimal.Parse(reader["price"].ToString()),
                        margin_revenue = int.Parse(reader["margin_revenue"].ToString()),
                        description_product = reader["description_product"].ToString(),
                        Id_product = int.Parse(reader["id_product"].ToString())
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            //throw new NotImplementedException();
            return listProduct;
        }

        internal List<Product> getProductDB(string name)
        {
            List<Product> listProduct = new List<Product>();
            try
            {
                conn.Open();
                string sqlQuery = @"SELECT * FROM Product WHERE name_product = @name_product";
                SqlParameter parameter = new SqlParameter("@name_product",name);
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
                sqlCommand.Parameters.Add(parameter);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    listProduct.Add(new Product
                    {
                        id_category = int.Parse(reader["id_product"].ToString()),
                        Code_bar = reader["Code_bar"].ToString(),
                        name_product = reader["name_product"].ToString(),
                        RouteImg = reader["RouteImg"].ToString(),
                        stock = decimal.Parse(reader["stock"].ToString()),
                        cost = decimal.Parse(reader["cost"].ToString()),
                        price = decimal.Parse(reader["price"].ToString()),
                        margin_revenue = int.Parse(reader["margin_revenue"].ToString()),
                        description_product = reader["description_product"].ToString(),
                        Id_product = int.Parse(reader["id_product"].ToString())
                    });
                }

            }
            catch (Exception) {
            
            }
            finally { 
                conn.Close(); 
            }
            return listProduct;
            //throw new NotImplementedException();
        }

        internal List<Product> UpdateSelectProductDB(int id_product)
        {
            List<Product> product = new List<Product>();

            try
            {
                conn.Open();
                string query = @"SELECT * FROM Product WHERE id_product = @id_product";
                SqlParameter id_parameter = new SqlParameter("@id_product",id_product);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(id_parameter);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    product.Add(new Product
                    {
                        id_category = int.Parse(reader["id_product"].ToString()),
                        Code_bar = reader["Code_bar"].ToString(),
                        name_product = reader["name_product"].ToString(),
                        RouteImg = reader["RouteImg"].ToString(),
                        stock = decimal.Parse(reader["stock"].ToString()),
                        cost = decimal.Parse(reader["cost"].ToString()),
                        price = decimal.Parse(reader["price"].ToString()),
                        margin_revenue = int.Parse(reader["margin_revenue"].ToString()),
                        description_product = reader["description_product"].ToString(),
                        Id_product = int.Parse(reader["id_product"].ToString())
                    });
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return product;
            //throw new NotImplementedException();
        }

        internal void UpdateProductDB(List<Product> itemsProduct, int id)
        {
            try
            {
                conn.Open();
                string queryInsertProduct = @"UPDATE Product SET name_product = @name_product ,Code_bar = @Code_bar,RouteImg = @RouteImg,description_product=@description_product,stock = @stock,price = @price,cost = @cost,margin_revenue = @margin_revenue, id_category = @id_category WHERE Id_product = @Id_product";

                // Se le pasan o bindean los parametros correspondientes
                SqlParameter id_product = new SqlParameter("@Id_product", id);
                SqlParameter name = new SqlParameter("@name_product", itemsProduct[0].name_product);
                SqlParameter codebar = new SqlParameter("@Code_bar", itemsProduct[0].Code_bar);
                SqlParameter route = new SqlParameter("@RouteImg", itemsProduct[0].RouteImg ?? "");
                SqlParameter description = new SqlParameter("@description_product", itemsProduct[0].description_product);
                SqlParameter stock = new SqlParameter("@stock", itemsProduct[0].stock);
                SqlParameter cost = new SqlParameter("@cost", itemsProduct[0].cost);
                SqlParameter price = new SqlParameter("@price", itemsProduct[0].price);
                SqlParameter marginRevenue = new SqlParameter("@margin_revenue", itemsProduct[0].margin_revenue);
                SqlParameter idCategory = new SqlParameter("@id_category", itemsProduct[0].id_category);

                // Se agregan los parametros respectivos a la consulta
                SqlCommand cmd = new SqlCommand(queryInsertProduct, conn);
                cmd.Parameters.Add(id_product);
                cmd.Parameters.Add(name);
                cmd.Parameters.Add(codebar);
                cmd.Parameters.Add(route);
                cmd.Parameters.Add(description);
                cmd.Parameters.Add(stock);
                cmd.Parameters.Add(cost);
                cmd.Parameters.Add(price);
                cmd.Parameters.Add(idCategory);
                cmd.Parameters.Add(marginRevenue);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            //throw new NotImplementedException();
        }

        internal void DeleteProductIdDB(int idProduct)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Product WHERE Id_product = @Id_product";
                SqlParameter parameter = new SqlParameter("@Id_product", idProduct);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
            //throw new NotImplementedException();
        }
    }
}
