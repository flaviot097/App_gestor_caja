using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_gestor_caja
{
    internal class BusineesLogicUser
    {
        DataAccesUser _accesUser;

        internal void CreateUser(List<User> users)
        {
            _accesUser = new DataAccesUser();
            _accesUser.CreateUserDB(users);
            //throw new NotImplementedException();
        }

        internal string GetUserLogicName(string name)
        {
            _accesUser = new DataAccesUser();
            return _accesUser.GetUserDB(name);
            //throw new NotImplementedException();
        }
    }
}
