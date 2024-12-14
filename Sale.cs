using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    public class Sale
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public Product id_Product { get; set; }
        public decimal Quantity { get; set; }
        public int Amount_sales { get; set; }
        public decimal Total {  get; set; }
        public User id_user { get; set; }
        public DateTime date { get; set; }

    }
}
