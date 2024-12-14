using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    public class Provider
    {
        public int id_provider { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public string document { get; set; }

        public string razon_social { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string dates { get; set; }
        public bool status { get; set; }
    }
}
