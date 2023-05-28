using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using ADO_NET.DB_layer;

namespace ADO_NET.BS_layer
{
    internal class BL_HoaDon
    {
        DataBase db = null;
        public BL_HoaDon()
        {
            db = new DataBase();
        }
        public DataSet LayHoaDon()
        {
            return db.LayDuLieu("select * from HoaDon");
        }
        public bool KiemTraID(string ID)
        {
            return db.KiemTraDuLieu("select * from HoaDon where ID = '" + ID + "'");
        }
        public bool ThemHoaDon(string ID, DateTime Ngay, DateTime Gio, string DanhMuc, string Loai, string Sotien)
        {
            string strTime = Gio.ToShortTimeString();
            return db.ChinhSuaDuLieu("insert into HoaDon values('" + ID + "', '" + Ngay.ToShortDateString() + "', '" + strTime + "', N'" + DanhMuc + "', N'" + Loai + "', '" + Sotien + "')");

        }
        public bool XoaHoaDon(string ID)
        {
            return db.ChinhSuaDuLieu("delete from HoaDon where ID = '" + ID + "'");
        }
        public bool CapNhatHoaDon(string ID, DateTime Ngay, DateTime Gio, string DanhMuc, string Loai, string Sotien)
        {
            string strTime = Gio.ToShortTimeString();
            return db.ChinhSuaDuLieu("update HoaDon set Ngay = '" + Ngay.ToShortDateString() + "', Gio = '" + strTime + "', DanhMuc = N'" + DanhMuc + "', Loai = N'" + Loai + "', Sotien = '" + Sotien + "' where ID = '" + ID + "'");
        }
        public DataSet TimKiemHoaDon(string ID, DateTime Ngay, DateTime Gio, string DanhMuc, string Loai, string Sotien)
        {
            string strTime = Gio.ToShortTimeString();

            string strSQL = "select * from HoaDon where ";
            string where = "";
            string start = "";
            string strid = "id ='" + ID + "'";
            string strn = "Ngay = '" + Ngay.ToShortDateString() + "'";
            string strg = "Gio = '" + strTime + "'";
            string strdm = "DanhMuc = N'" + DanhMuc + "'";
            string strl = "Loai = N'" + Loai + "'";
            string strs = "Sotien = '" + Sotien + "'";

            if (ID != "") { where += strid; start = " id "; }
            else if (strTime != null) { where += strn; start = " Ngay "; }
            else if (strTime != null) { where += strg; start = " Gio "; }
            else if (DanhMuc != "") { where += strdm; start = " DanhMuc "; }
            else if (Loai != "") { where += strl; start = " Loai "; }
            else if (Sotien != "") { where += strs; start = " Sotien "; }
            else return null;

            if (Ngay.ToShortDateString() != null && start != " Ngay ") where += " and " + strn;
            else if (strTime != null && start != " Gio ") where += " and " + strg;
            else if (DanhMuc != "" && start != " DanhMuc ") where += " and " + strdm;
            else if (Loai != "" && start != " Loai ") where += " and " + strl;
            else if (Sotien != "" && start != " Sotien ") where += " and " + strs;

            strSQL += where;
            return db.LayDuLieu(strSQL);
        }

    }
}
