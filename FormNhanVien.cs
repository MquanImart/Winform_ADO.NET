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
    public partial class FormNhanVien : Form
    {
        ChucNang chucnang = ChucNang.None;
        BL_NhanVien bl = new BL_NhanVien();
        bool click_cell = true;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        void Reset_Txt()
        {
            txtID.ResetText();
            txtHoTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtcccd.ResetText();
            txtchucvu.ResetText();
            numLuong.Value = 0;
        }
        void LoadData()
        {
            changState(false);
            try
            {
                DataSet ds = bl.LayNhanVien();
                dgvNV.DataSource = ds.Tables[0];
                dgvNV.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }
        void changState(bool chinhsua)
        {
            if (chinhsua)
            {
                Reset_Txt();
            }
            pnlnv.Enabled = chinhsua;
            btnluu.Enabled = chinhsua;
            btnhuy.Enabled = chinhsua;

            btnthem.Enabled = !chinhsua;
            btnsua.Enabled = !chinhsua;
            btnxoa.Enabled = !chinhsua;
            btnthoat.Enabled = !chinhsua;


        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            LoadData();
            click_cell = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                bl.XoaNhanVien(txtID.Text);
                LoadData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.TimKiem;
            changState(true);
            Reset_Txt();
            click_cell = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Sua;

            changState(true);
            txtID.Enabled = false;
            txtID.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Them;
            txtID.Enabled = true;

            changState(true);
            txtID.Focus();
            click_cell = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (chucnang == ChucNang.Them)
            {
                if (!txtID.Text.Trim().Equals(""))
                {
                    if (bl.KiemTraID(txtID.Text))
                    {
                        MessageBox.Show("ID da ton tai!!!");
                        Reset_Txt();
                    }
                    else
                        bl.ThemNhanVien(txtID.Text, txtHoTen.Text,dtpngaysinh.Value,txtcccd.Text,
                            txtDiaChi.Text,cbnam.Checked, txtSDT.Text, txtchucvu.Text, Convert.ToInt32(numLuong.Value));
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nhập ID!");
                    txtID.Focus();
                }
            }
            else if (chucnang == ChucNang.Sua)
            {
                if (!txtID.Text.Trim().Equals(""))
                {
                    bl.CapNhatNhanVien(txtID.Text, txtHoTen.Text, dtpngaysinh.Value, txtcccd.Text,
                            txtDiaChi.Text, cbnam.Checked, txtSDT.Text, txtchucvu.Text, Convert.ToInt32(numLuong.Value));
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nhập ID!");
                    txtID.Focus();
                }
            }
            else if (chucnang == ChucNang.TimKiem)
            {
                DataSet dsimkiem = bl.TimNhanVien(txtID.Text, txtHoTen.Text, txtcccd.Text,
                            txtDiaChi.Text, txtSDT.Text, txtchucvu.Text, Convert.ToInt32(numLuong.Value));
                try
                {
                    if (dsimkiem != null)
                    {
                        dgvNV.DataSource = dsimkiem.Tables[0];
                        dgvNV.AutoResizeColumns();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung!");
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            changState(false);
            click_cell = true;
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNV.CurrentCell.RowIndex;
            if (r < dgvNV.RowCount - 1 && click_cell)
            {
                txtID.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
                txtHoTen.Text = dgvNV.Rows[r].Cells[1].Value.ToString();
                dtpngaysinh.Value = Convert.ToDateTime(dgvNV.Rows[r].Cells[2].Value);
                txtcccd.Text = dgvNV.Rows[r].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNV.Rows[r].Cells[4].Value.ToString();
                cbnam.CheckState = dgvNV.Rows[r].Cells[5].Value.ToString().Contains("nam") ? CheckState.Checked : CheckState.Unchecked;
                txtSDT.Text = dgvNV.Rows[r].Cells[6].Value.ToString();
                txtchucvu.Text = dgvNV.Rows[r].Cells[7].Value.ToString();
                numLuong.Value = Convert.ToInt32(dgvNV.Rows[r].Cells[8].Value);
            }

        }

        private void btnTinhSL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số lượng nhân viên: " + (dgvNV.RowCount - 1).ToString());
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            int r = dgvNV.CurrentCell.RowIndex;
            for (int i = 0; i < dgvNV.Rows.Count - 1; i++)
            {
                tong = tong + Convert.ToInt32(dgvNV.Rows[i].Cells[8].Value);
            }
            MessageBox.Show("Tổng lương nhân viên: " + tong.ToString());
        }
    }
}
