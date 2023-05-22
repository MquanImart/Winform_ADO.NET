using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO_NET.DB_layer;

namespace ADO_NET.BS_layer
{
    internal class BL_KhachHang
    {
        DataBase db = null;
        public BL_KhachHang()
        {
            db = new DataBase();
        }
        public DataSet LayKhachHang()
        {
            return db.LayDuLieu("select * from KhachHang");
        }
        public bool KiemTraID(string id)
        {
            string sqlstr = "Select * from KhachHang where id='" + id + "'";
            return db.KiemTraDuLieu(sqlstr);
        }
        public bool ThemKhachHang(string id, string hoten, string diachi, string sdt)
        {
            string sqlString = "Insert Into KhachHang Values(" + "'" +
            id + "',N'" + hoten + "',N'"+ diachi + "',N'" + sdt + "')";
            return db.ChinhSuaDuLieu(sqlString);
        } 
        public bool XoaKhachHang(string id)
        {
            string sqlString = "Delete From KhachHang Where id='" + id + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool CapNhatKhachHang(string id, string hoten, string diachi, string sdt)
        {
            string sqlString = "Update KhachHang Set hoten=N'" +
            hoten + "',diachi=N'" + diachi + "',sdt=N'" + sdt +  "' Where id='" + id + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public DataSet TimKhachHang(string id, string hoten, string diachi, string sdt)
        {
            string strSQL = "select * from KhachHang where ";
            string where = "";
            string start = "";
            string strid = "id ='" + id + "'";
            string strhoten = "hoten ='" + hoten + "'";
            string strdiachi = "diachi ='" + diachi + "'";
            string strsdt = "sdt ='" + sdt + "'";

            if (id != "") { where += strid; start = "id"; }
            else if (hoten != "") { where += strhoten; start = "hoten"; }
            else if (diachi != "") { where += strdiachi; start = "diachi"; }
            else if (sdt != "") { where += strsdt; start = "sdt"; }
            else return null;

            if (hoten != "" && start != "hoten") where += " and " + strhoten;
            else if (diachi != "" && start != "diachi") where += " and " + strdiachi;
            else if (sdt != "" && start != "sdt") where += " and " + strsdt;

            strSQL = strSQL + where;
            return db.LayDuLieu(strSQL);
        }
    }
}
