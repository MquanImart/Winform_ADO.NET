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
        public DataSet TImKiemThongTin(DateTime ngay, DateTime gio, int somay, string username, string tinhtrang, int thoigian)
        {
            string sql = "select* from LichSuHoatDong where ";
            string strngay = "ngay= '" + ngay.ToShortDateString() + "'";
            string strgio = "gio= '" + gio.ToShortTimeString() + "'";
            string strsomay = "somay= '" + somay.ToString() + "'";
            string struser = "bienso= " + username ;
            string strtinhtrang = "tinhtrang= '" + tinhtrang + "'";
            string strthoigian = "thoigian= " + thoigian.ToString();

            sql = sql + strngay;
            if (gio.ToShortTimeString() != "12:00 AM") sql = sql + " and " + strgio;
            if (somay != 0) sql = sql + " and " + strsomay;
            if (username != "") sql = sql + " and " + struser;
            if (tinhtrang != "") sql = sql + " and " + strtinhtrang;
            if (thoigian != 0) sql = sql + " and "+ strthoigian;

            return db.LayDuLieu(sql);
        }
        public DataSet TimKiemThongTin_NotNgay(DateTime gio, int somay, string username, string tinhtrang, int thoigian)
        {
            string sql = "select* from LichSuHoatDong where ";
            string where = "none";
            string strgio = "gio= '" + gio.ToShortTimeString() + "'";
            string strsomay = "somay= '" + somay.ToString() + "'";
            string struser = "bienso= " + username;
            string strtinhtrang = "tinhtrang= '" + tinhtrang + "'";
            string strthoigian = "thoigian= " + thoigian.ToString();

            if (gio.ToShortTimeString() != "12:00 AM") { sql = sql + strgio; where = "gio"; }
            else if (somay != 0) { sql = sql + strsomay; where = "somay"; }
            else if (username != "") { sql = sql + struser; where = "user"; }
            else if (tinhtrang != "") { sql = sql + strtinhtrang; where = "tinhtrang"; }
            else if (thoigian != 0) { sql = sql + strthoigian; where = "thoigian"; }

            if (gio.ToShortTimeString() != "12:00 AM" && where != "gio") sql = sql + " and " + strgio;
            if (somay != 0 && where != "somay") sql = sql + " and " + strsomay;
            if (username != "" && where != "bienso") sql = sql + " and " + struser;
            if (tinhtrang != "" && where != "tinhtrang") sql = sql + " and " + strtinhtrang;
            if (thoigian != 0 && where != "thoigian") sql = sql + " and " + strthoigian;

            return db.LayDuLieu(sql);
        }
    }
}
