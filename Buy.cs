using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    public class Buy
    {
        public int Id { get; set; }
        public Product Id_product { get; set; }
        public int Buy_amount { get; set; }
        public int Quantity { get; set; }
        public User Id_user { get; set; }
        public decimal Total { get; set; }
        public Provider Id_provider { get; set; }
        public DateTime Date { get; set; }
    }
}
