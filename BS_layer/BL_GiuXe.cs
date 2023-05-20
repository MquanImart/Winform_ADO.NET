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
            string sqlString = "Insert Into GiuXe Values(" + "'" +
            ngay.ToShortDateString() + "',N'" + giovao.ToShortTimeString() + "',N'NULL',N'" + bienso + "',N'" + IDcard + "')";
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
            giora+ "',IDcard=N'" + IDcard + "' Where Ngay='" + ngay + "' and GioVao = '" + giovao + "' and BienSo ='" + bienso + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
    }
}
