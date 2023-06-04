using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET
{
    public partial class FormReportKhachHang : Form
    {
        public FormReportKhachHang()
        {
            InitializeComponent();
        }

        private void FormReportKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyInternet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyInternet.KhachHang);

            this.reportViewer1.RefreshReport();
        }
    }
}
