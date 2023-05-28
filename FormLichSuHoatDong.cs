using ADO_NET.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET
{
    public partial class FormLichSuHoatDong : Form
    {
        ChucNang chucnang = ChucNang.None;
        BL_LichSuHoatDong bl = new BL_LichSuHoatDong();
        DataTable dt;
        bool ClickCell = true;
        public FormLichSuHoatDong()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        void LoadData()
        {
            changState(false);
            try
            {
                DataSet ds = bl.LayDuLieu();
                this.dt = ds.Tables[0];
                dgvLSHD.DataSource = dt;
                dgvLSHD.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }
        void Reset_Txt()
        {
            txttinhtrang.ResetText();
            txtusername.ResetText();

        }
        void changState(bool chinhsua)
        {
            if (chinhsua)
            {
                Reset_Txt();
            }
            Enable_Button(chinhsua);
        }
        void Enable_Button(bool chinhsua)
        {
            pnllshd.Enabled = chinhsua;
            btnluu.Enabled = chinhsua;
            btnhuy.Enabled = chinhsua;

            btnthem.Enabled = !chinhsua;
            btnsua.Enabled = !chinhsua;
            btnxoa.Enabled = !chinhsua;
            btnthoat.Enabled = !chinhsua;
        }
        private void FormLichSuHoatDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btntatmay_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Sua;
            Enable_Button(true);
            Calendar.Enabled = false;
            numGio.Enabled = false;
            numPhut.Enabled = false;
            txttinhtrang.Enabled = false;
            txtusername.Enabled = false;
            numsomay.Enabled = false;
            numthoigian.Enabled = true;
            txttinhtrang.Text = "da su dung";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Them;
            changState(true);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Sua;
            Enable_Button(true);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.TimKiem;
            changState(true);
            cbngay.Enabled = true;
            Reset_Txt();
            numGio.Value = 0;
            numPhut.Value = 0;
            numsomay.Value = 0;
            numthoigian.Value = 0;
            ClickCell = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                DateTime ngay = Calendar.SelectionStart;
                DateTime gio = new DateTime(1, 1, 1, Convert.ToInt32(numGio.Value), Convert.ToInt32(numPhut.Value), 0);
                int somay = Convert.ToInt32(numsomay.Value);
                string username = txtusername.Text;
                bl.XoaLichSuHoatDong(ngay, gio, somay, username);
                LoadData();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DateTime ngay = Calendar.SelectionStart;
            DateTime gio = new DateTime(1, 1, 1, Convert.ToInt32(numGio.Value), Convert.ToInt32(numPhut.Value), 0);

            if (chucnang == ChucNang.Them)
            {
                if (!txtusername.Text.Trim().Equals(""))
                {
                    bl.ThemHoatDong(ngay, gio, Convert.ToInt32(numsomay.Value), txtusername.Text, txttinhtrang.Text, Convert.ToInt32(numthoigian.Value));
                    LoadData();
                    Reset_Txt();
                }
                else
                {
                    MessageBox.Show("Nhập Thieu Thong Tin!");
                }
            }
            else if (chucnang == ChucNang.Sua)
            {
                if (!txtusername.Text.Trim().Equals(""))
                {
                    bl.ThayDoiLichSuHoatDong(ngay, gio, Convert.ToInt32(numsomay.Value), txtusername.Text, txttinhtrang.Text, Convert.ToInt32(numthoigian.Value));
                    LoadData();
                    Reset_Txt();
                }
                else
                {
                    MessageBox.Show("Nhập User name!");
                }
            }
            else
            {
                DataSet dsimkiem;
                if (cbngay.Checked) { dsimkiem = bl.TImKiemThongTin(ngay, gio, Convert.ToInt32(numsomay.Value), txtusername.Text, txttinhtrang.Text, Convert.ToInt32(numthoigian.Value)); }
                else dsimkiem = bl.TimKiemThongTin_NotNgay(gio, Convert.ToInt32(numsomay.Value), txtusername.Text, txttinhtrang.Text, Convert.ToInt32(numthoigian.Value));
                try
                {
                    if (dsimkiem != null)
                    {
                        dgvLSHD.DataSource = dsimkiem.Tables[0];
                        dgvLSHD.AutoResizeColumns();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung!");
                }
                cbngay.Enabled = false;
                ClickCell = true;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            changState(false);
            ClickCell = true;
            cbngay.Enabled = false;
        }

        private void dgvLSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClickCell == true)
            {
                int r = dgvLSHD.CurrentCell.RowIndex;
                Calendar.SelectionStart = Convert.ToDateTime(dgvLSHD.Rows[r].Cells[0].Value);
                TimeSpan gio = (TimeSpan)dgvLSHD.Rows[r].Cells[1].Value;
                numGio.Value = gio.Hours;
                numPhut.Value = gio.Minutes;
                numsomay.Value = Convert.ToInt32(dgvLSHD.Rows[r].Cells[2].Value);
                txtusername.Text = dgvLSHD.Rows[r].Cells[3].Value.ToString();
                txttinhtrang.Text = dgvLSHD.Rows[r].Cells[4].Value.ToString();
                numthoigian.Value = Convert.ToInt32(dgvLSHD.Rows[r].Cells[5].Value);
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show((dgvLSHD.RowCount - 1).ToString());
        }

        private void btnTinhThoiGian_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < dgvLSHD.Rows.Count - 1; i++)
            {
                tong = tong + Convert.ToInt32(dgvLSHD.Rows[i].Cells[5].Value);
            }
            MessageBox.Show("Tong thoi gian su dung la: " + tong.ToString());
        }
    }
}
