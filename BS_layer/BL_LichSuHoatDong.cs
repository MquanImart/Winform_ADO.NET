using ADO_NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.BS_layer
{
    internal class BL_LichSuHoatDong
    {
        DataBase db = null;
        public BL_LichSuHoatDong()
        {
            db = new DataBase();
        }
        public DataSet LayDuLieu()
        {
            return db.LayDuLieu("select * from LichSuHoatDong");
        }
        public bool ThemHoatDong(DateTime ngay, DateTime gio, int somay,  string username, string tinhtrang, int thoigian)
        {
            string sqlString = "Insert Into LichSuHoatDong Values(" + "'" +
            ngay.ToShortDateString() + "',N'" + gio + "',N'" + somay + "',N'" + username+ "',N'" + tinhtrang + "',N'" +thoigian+ "')";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool XoaLichSuHoatDong(DateTime ngay, DateTime gio, int somay, string username)
        {
            string sqlString = "Delete From LichSuHoatDong Where ngay='" + ngay.ToShortDateString() + "' and gio='" + gio.ToShortTimeString() +
                "' and somay='" + somay + "' and username = '" + username + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool ThayDoiLichSuHoatDong(DateTime ngay, DateTime gio, int somay, string username, string tinhtrang, int thoigian)
        {
            string sqlString = "Update LichSuHoatDong Set tinhtrang=N'" +
            tinhtrang + "',thoigian=N'" + thoigian + "' Where ngay='" + ngay + "' and gio = '" + gio + "' and somay ='" + somay +"' and username ='" + username + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
    }
}
