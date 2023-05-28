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
    internal class BL_HangHoa
    {
        DataBase db = null;
        public BL_HangHoa()
        {
            db = new DataBase();
        }
        public DataSet LayHangHoa()
        {
            return db.LayDuLieu("select * from HangHoa");
        }
        public bool KiemTraID(string ID)
        {
            return db.KiemTraDuLieu("select * from HangHoa where ID = '" + ID + "'");
        }
        public bool ThemHangHoa(string ID, string Loai, string Ten, string SL, string Gia, DateTime Ngay)
        {
            return db.ChinhSuaDuLieu("insert into HangHoa values('" + ID + "',N'" + Loai + "',N'" + Ten + "','" + SL + "','" + Gia + "','" + Ngay + "')");
        }
        public bool XoaHangHoa(string ID)
        {
            return db.ChinhSuaDuLieu("delete from HangHoa where ID = '" + ID + "'");
        }
        public bool CapNhatHangHoa(string ID, string Loai, string Ten, string SL, string Gia, DateTime Ngay)
        {
            return db.ChinhSuaDuLieu("update HangHoa set Loai = N'" + Loai + "', Ten = N'" + Ten + "', SL = '" + SL + "', Gia = '" + Gia + "', Ngay = '" + Ngay + "' where ID = '" + ID + "'");
        }
        public DataSet TimKiemHangHoa(string ID, string Loai, string Ten, string SL, string Gia, DateTime Ngay)
        {
            string strSQL = "select * from HangHoa where ";
            string where = "";
            string start = "";
            string strid = "id ='" + ID + "'";
            string strl = "Loai = N'" + Loai + "'";
            string strt = "Ten = N'" + Ten + "'";
            string strsl = "SL = '" + SL + "'";
            string strg = "Gia = '" + Gia + "'";

            if (ID != "") { where += strid; start = " id "; }
            else if (Loai != "") { where += strl; start = " Loai "; }
            else if (Ten != "") { where += strt; start = " Ten "; }
            else if (SL != "") { where += strsl; start = " SL "; }
            else if (Gia != "") { where += strg; start = " Gia "; }
            else return null;

            if (Loai != "" && start != " Loai ") where += " and " + strl;
            else if (Ten != "" && start != " Ten ") where += " and " + strt;
            else if (SL != "" && start != " SL ") where += " and " + strsl;
            else if (Gia != "" && start != " Gia ") where += " and " + strg;

            strSQL += where + " order by " + start;
            return db.LayDuLieu(strSQL);
        }

    }
}
