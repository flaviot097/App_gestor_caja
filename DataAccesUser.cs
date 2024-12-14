using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    internal class DataAccesUser
    {
        List<User> _user = new List<User>();
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=App_gestor_caja;Data Source=DESKTOP-SEVLBL8");

        internal void CreateUserDB(List<User> users)
        {
            conn.Open();
            try
            {
                string query = "INSERT INTO Users (Username , password) VALUES (@user, @password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", users[0].Name);
                cmd.Parameters.AddWithValue("@password", users[0].Password);
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

        internal string GetUserDB(string name)
        {
            string password="";
            conn.Open();
            try
            {
                string query = "SELECT password FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", name);
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read()) 
                {
                    password = data["password"].ToString(); 
                }


            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return password;
            //throw new NotImplementedException();
        }
    }
}
