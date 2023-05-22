using ADO_NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET.BS_layer
{
    internal class BL_GiuXe
    {
        DataBase db = null;
        public BL_GiuXe()
        {
            db = new DataBase();
        }
        public DataSet LayDuLieu()
        {
            return db.LayDuLieu("select * from GiuXe");
        }
        public bool ThemXeVao(DateTime ngay, DateTime giovao, string bienso, string IDcard)
        {
            string newstr = giovao.ToShortTimeString();
            string giovaostr = newstr.Substring(0, newstr.Length - 3) + ":00";
            string sqlString = "Insert Into GiuXe Values(" + "'" +
            ngay.ToShortDateString() + "',N'" + giovaostr + "',NULL,N'" + bienso + "',N'" + IDcard + "')";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool XoaLichSuGiuXe(DateTime ngay, DateTime giovao, string bienso)
        {
            string sqlString = "Delete From GiuXe Where Ngay='" + ngay.ToShortDateString() + "' and GioVao='" + giovao.ToShortTimeString() +
                "' and BienSo='" + bienso + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool ThayDoiThongTinGiuXe(DateTime ngay, DateTime giovao,DateTime giora, string bienso, string IDcard)
        {
            string sqlString = "Update GiuXe Set GioRa=N'" +
            giora.ToShortTimeString()+ "',IDcard=N'" + IDcard + "' Where Ngay='" + ngay + "' and GioVao = '" + giovao + "' and BienSo ='" + bienso + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public DataSet TimKiemThongTin(DateTime ngay, DateTime giovao, DateTime giora, string bienso, string IDcard)
        {
            string sql = "select* from GiuXe where ";
            string strngay = "ngay= '" + ngay.ToShortDateString() + "'";
            string strgiovao = "giovao= '" + giovao.ToShortTimeString() + "'";
            string strgiora = "giora= '" + giora.ToShortTimeString() + "'";
            string strbienso = "bienso= '" + bienso + "'";
            string strIDcard = "IDcard= '" + IDcard + "'";

            sql = sql + strngay;
            if (giovao.ToShortTimeString() != "12:00 AM") sql = sql + " and " + strgiovao;
            if (giora.ToShortTimeString() != "12:00 AM") sql = sql + " and " + strgiora;
            if (bienso != "") sql = sql + " and " + strbienso;
            if (IDcard != "") sql = sql + " and " + strIDcard;

            return db.LayDuLieu(sql);
        }
        public DataSet TimKiemThongTin_NotNgay(DateTime giovao, DateTime giora, string bienso, string IDcard)
        {
            string sql = "select* from GiuXe where ";
            string where = "none";
            string strgiovao = "giovao= '" + giovao.ToShortTimeString() + "'";
            string strgiora = "giora= '" + giora.ToShortTimeString() + "'";
            string strbienso = "bienso= '" + bienso + "'";
            string strIDcard = "IDcard= '" + IDcard + "'";

            if (giovao.ToShortTimeString() != "12:00 AM") { sql = sql + strgiovao; where = "giovao"; }
            else if (giora.ToShortTimeString() != "12:00 AM") { sql = sql + strgiora; where = "giora"; }
            else if (bienso != "") { sql = sql + strbienso; where = "bienso"; }
            else if (IDcard != "") { sql = sql + strIDcard; where = "IDcard"; }

            if (giovao.ToShortTimeString() != "12:00 AM" && where != "giovao") sql = sql + " and " + strgiovao;
            if (giora.ToShortTimeString() != "12:00 AM" && where != "giora") sql = sql + " and " + strgiora;
            if (bienso != "" && where != "bienso") sql = sql + " and " + strbienso;
            if (IDcard != "" && where != "IDcard") sql = sql + " and " + strIDcard;

            return db.LayDuLieu(sql);
        }
    }
}
