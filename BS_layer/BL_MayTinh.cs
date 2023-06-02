using ADO_NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET.BS_layer
{
    internal class BL_MayTinh
    {
        DataBase db = null;
        public BL_MayTinh()
        {
            db = new DataBase();
        }
        public DataSet LayDuLieu()
        {
            return db.LayDuLieu("select * from MayTinh");
        }
        public bool KiemTraID(string id)
        {
            string sqlstr = "Select * from MayTinh where ID='" + id + "'";
            return db.KiemTraDuLieu(sqlstr);
        }
        public bool ThemMayTinh(string id, string manhinh, string CPU, string ocung, string Ram, string tinhtrang)
        {
            string sqlString = "Insert Into MayTinh Values(" + "'" +
            id + "',N'" + manhinh + "',N'" + CPU + "',N'" + ocung + "',N'" + Ram + "',N'" + tinhtrang + "')";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool XoaMayTinh(string id)
        {
            string sqlString = "Delete From MayTinh Where ID='" + id + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public bool CapNhatMayTinh(string id, string manhinh, string CPU, string ocung, string Ram, string tinhtrang)
        {
            string sqlString = "Update MayTinh Set Manhinh=N'" +
            manhinh + "',CPU=N'" + CPU + "',Ocung=N'" + ocung + "', Ram='" + Ram + "', Tinhtrang = '" + tinhtrang + "' Where ID='" + id + "'";
            return db.ChinhSuaDuLieu(sqlString);
        }
        public DataSet TinhMayTinh(string id, string manhinh, string CPU, string ocung, string Ram, string tinhtrang)
        {
            string strSQL = "select * from MayTinh where ";
            string where = "";
            string start = "";
            string strid = "id ='" + id + "'";
            string strmanhinh = "Manhinh ='" + manhinh + "'";
            string strCPU = "CPU ='" + CPU + "'";
            string strocung = "Ocung ='" + ocung + "'";
            string strRam = "Ram ='" + Ram + "'";
            string strtt = "Tinhtrang ='" + tinhtrang + "'";

            if (id != "") { where += strid; start = "id"; }
            else if (manhinh != "") { where += strmanhinh; start = "manhinh"; }
            else if (CPU != "") { where += strCPU; start = "CPU"; }
            else if (ocung != "") { where += strocung; start = "ocung"; }
            else if (Ram != "") { where += strRam; start = "Ram"; }
            else if (tinhtrang != "") { where += strtt; start = "tt"; }
            else return null;

            if (manhinh != "" && start != "manhinh") where += " and " + strmanhinh;
            if (CPU != "" && start != "CPU") where += " and " + strCPU;
            if (ocung != "" && start != "ocung") where += " and " + strocung;
            if (Ram != "" && start != "Ram") where += " and " + strRam;
            if (tinhtrang != "" && start != "tt") where += " and " + strtt;

            strSQL = strSQL + where;
            return db.LayDuLieu(strSQL);
        }
    }
}
