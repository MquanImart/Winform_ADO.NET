using ADO_NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET.BS_layer
{
    internal class BL_NhanVien
    {
        DataBase db = null;
        public BL_NhanVien()
        {
            db = new DataBase();
        }
        public DataSet LayNhanVien()
        {
            return db.LayDuLieu("select * from NhanVien");
        }
        public bool KiemTraID(string id)
        {
            string sqlstr = "Select * from NhanVien where ID='" + id + "'";
            return db.KiemTraDuLieu(sqlstr);
        }
        public bool ThemNhanVien(string id, string hoten,DateTime ngaysinh, string cccd, string diachi,bool isnam, string sdt, string chucvu, int luong)
        {
            string gioitinh = isnam == true ? "nam" : "nu";
            string sqlString = "Insert Into NhanVien Values(" + "'" +
            id + "',N'" + hoten + "',N'" + ngaysinh.ToShortDateString() + "',N'" + cccd + "',N'" + diachi + "',N'" + gioitinh + "',N'" + sdt+ "',N'"+chucvu + "'," +luong + ")";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool XoaNhanVien(string id)
        {
            string sqlString = "Delete From NhanVien Where ID='" + id + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool CapNhatNhanVien(string id, string hoten, DateTime ngaysinh, string cccd, string diachi, bool isnam, string sdt, string chucvu, int luong)
        {
            string gioitinh = isnam == true ? "nam" : "nu";
            string sqlString = "Update NhanVien Set Hoten=N'" +
            hoten + "', Ngaysinh = '"+ngaysinh.ToShortDateString() +"',CCCD='" + cccd+ "',Diachi=N'" + diachi + 
            "',Gioitinh='"+ gioitinh +"',sdt=N'" + sdt +"',Chucvu='" + chucvu + "', Luong=" + luong + " Where ID='" + id + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public DataSet TimNhanVien(string id, string hoten, string cccd, string diachi, string sdt, string chucvu, int luong)
        {

            string strSQL = "select * from NhanVien where ";
            string where = "";
            string start = "";
            string strid = "ID ='" + id + "'";
            string strhoten = "Hoten ='" + hoten + "'";
            string strcccd = "CCCD ='" + cccd + "'";
            string strdiachi = "Diachi ='" + diachi + "'";
            string strsdt = "SDT ='" + sdt + "'";
            string strchucvu = "Chucvu ='" + chucvu + "'";
            string strluong = "Luong=" + luong + "";

            if (id != "") { where += strid; start = "id"; }
            else if (hoten != "") { where += strhoten; start = "hoten"; }
            else if (cccd != "") { where += strcccd; start = "cccd"; }
            else if (diachi != "") { where += strdiachi; start = "diachi"; }
            else if (sdt != "") { where += strsdt; start = "sdt"; }
            else if (chucvu != "") { where += strchucvu; start = "chucvu"; }
            else if (luong != 0) { where += strluong; start = "luong"; }
            else return null;

            if (hoten != "" && start != "hoten") where += " and " + strhoten;
            if (cccd != "" && start != "cccd") where += " and " + strcccd;
            if (diachi != "" && start != "diachi") where += " and " + strdiachi;
            if (sdt != "" && start != "sdt") where += " and " + strsdt;
            if (chucvu != "" && start != "chucvu") where += " and " + strchucvu;
            if (luong != 0 && start != "luong") where += " and " + strluong;

            strSQL = strSQL + where;
            return db.LayDuLieu(strSQL);
        }

    }
}
