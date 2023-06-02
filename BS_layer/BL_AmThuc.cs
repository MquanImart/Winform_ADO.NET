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
    internal class BL_AmThuc
    {
        DataBase db = null;
        public BL_AmThuc()
        {
            db = new DataBase();
        }
        public DataSet LayAmThuc()
        {
            return db.LayDuLieu("select * from AmThuc");
        }
        public bool KiemTraID(string ID)
        {
            return db.KiemTraDuLieu("select * from AmThuc where ID = '" + ID + "'");
        }
        public bool ThemAmThuc(string ID, string Ten, string Gia, string SL)
        {
            return db.ChinhSuaDuLieu("insert into AmThuc values('" + ID + "',N'" + Ten + "','" + Gia + "','" + SL + "')");
        }
        public bool XoaAmThuc(string ID)
        {
            return db.ChinhSuaDuLieu("delete from AmThuc where ID = '" + ID + "'");
        }
        public bool CapNhatAmThuc(string ID, string Ten, string Gia, string SL)
        {
            return db.ChinhSuaDuLieu("update AmThuc set Ten = N'" + Ten + "', Gia = '" + Gia + "', SL = '" + SL + "' where ID = '" + ID + "'");
        }
        public DataSet TimKiemAmThuc(string ID, string Ten, string Gia, string SL)
        {
            string strSQL = "select * from AmThuc where ";
            string where = "";
            string start = "";
            string strid = "id ='" + ID + "'";
            string strt = "Ten = N'" + Ten + "'";
            string strg = "Gia = '" + Gia + "'";
            string strsl = "SL = '" + SL + "'";

            if (ID != "") { where += strid; start = " id "; }
            else if (Ten != "") { where += strt; start = " Ten "; }
            else if (Gia != "") { where += strg; start = " Gia "; }
            else if (SL != "") { where += strsl; start = " SL "; }
            else return null;

            if (Ten != "" && start != " Ten ") where += " and " + strt;
            if (Gia != "" && start != " Gia ") where += " and " + strg;
            if (SL != "" && start != " SL ") where += " and " + strsl;

            strSQL += where + " order by " + start;
            return db.LayDuLieu(strSQL);
        }
        // Tính tổng số lượng món ăn
        public int TongSL()
        {
            DataSet ds = db.LayDuLieu("select * from AmThuc");
            int tong = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                tong += int.Parse(row["SL"].ToString());
            }
            return tong;
        }
        // Tính tổng số tiền
        public int TongTien()
        {
            DataSet ds = db.LayDuLieu("select * from AmThuc");
            int tong = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                tong += int.Parse(row["Gia"].ToString()) * int.Parse(row["SL"].ToString());
            }
            return tong;
        }

    }
}
