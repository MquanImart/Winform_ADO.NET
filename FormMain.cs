using ADO_NET.BS_layer;
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
    public partial class FormMain : Form
    {
        BL_Login bl = new BL_Login();
        public FormMain()
        {
            InitializeComponent();
            pnlchucnang.Enabled = false;
        }

        private void btnGiuxe_Click(object sender, EventArgs e)
        {
            FormGiuXe gx = new FormGiuXe();
            gx.ShowDialog();
        }

        private void btnAmthuc_Click(object sender, EventArgs e)
        {
            FormAmThuc amThuc = new FormAmThuc();
            amThuc.ShowDialog();
        }

        private void btnHanghoa_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa();
            formHangHoa.ShowDialog();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon formHoaDon = new FormHoaDon();
            formHoaDon.ShowDialog();
        }

        private void btnMaytinh_Click(object sender, EventArgs e)
        {
            FormMayTinh formMayTinh = new FormMayTinh();
            formMayTinh.ShowDialog();
        }

        private void btnLichsu_Click(object sender, EventArgs e)
        {
            FormLichSuHoatDong formLichSu = new FormLichSuHoatDong();
            formLichSu.ShowDialog();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            pnlchucnang.Enabled = false;
            pnllogin.Enabled = true;
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (bl.CheckLogin(txtuser.Text, txtpass.Text))
            {
                pnlchucnang.Enabled = true;
                pnllogin.Enabled = false;
                txtuser.ResetText();
                txtpass.ResetText();
            }

        }
    }
}
