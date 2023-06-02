using ADO_NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.BS_layer
{
    internal class BL_Login
    {
        DataBase db = null;
        public BL_Login()
        {
            db = new DataBase();
        }
        public bool CheckLogin(string username, string password)
        {
            string sqlstr = "Select * from Manager where username='" + username + "' and pass='" + password +"'";
            return db.KiemTraDuLieu(sqlstr);
        }
    }
}
