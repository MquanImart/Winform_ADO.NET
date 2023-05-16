using ADO_NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ADO_NET
{
    internal class BL_TaiKhoan
    {
        DataBase db = null;
        public BL_TaiKhoan()
        {
            db = new DataBase();
        }
        public DataSet LayTaiKhoan()
        {
            return db.LayDuLieu("select * from TaiKhoan");
        }
        public bool Check(string username)
        {
            string sqlString = "select * from TaiKhoan where username= '" + username+"'";
            return db.KiemTraDuLieu(sqlString);
        }
        public bool ThemTaiKhoan(string username, string pass, string id, int money)
        {
            string sqlString = "Insert Into TaiKhoan Values(" + "'" +
            username + "',N'" + pass + "',N'" + id + "',N'" + money + "')";
            if (Check(username))
            {
                MessageBox.Show("User name da ton tai!!!");
                return false;
            }
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool XoaTaiKhoan(string username)
        {
            string sqlString = "Delete From TaiKhoan Where username='" + username + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool CapNhatTaiKhoan(string username, string pass, string id, int money)
        {
            string sqlString = "Update KhachHang Set pass=N'" +
            pass + ",id=N'" + id + ",money_account=N'" + money + "' Where username='" + username + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
    }
}
