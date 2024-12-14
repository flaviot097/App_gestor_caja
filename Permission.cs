using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    public class Permission
    {
        public int id {  get; set; }
        public User Id_user { get; set; }
        public string NamePermission {  get; set; }
    }
}
