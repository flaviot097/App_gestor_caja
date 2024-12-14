using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    public class Product
    {
        public int Id_product { get; set; }
        public string name_product { get; set; }
        public string Code_bar { get; set; }
        public string RouteImg { get; set; }
        public string description_product { get; set; }
        public decimal stock { get; set; }
        public decimal price { get; set; }
        public decimal cost { get; set; }
        public int margin_revenue { get; set; }
        public int id_category { get; set; }
    }
}
