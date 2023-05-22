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
using static System.Net.WebRequestMethods;

namespace ADO_NET
{
    internal enum ChucNang
    {
        None,
        Them,
        Sua,
        TimKiem
    }
    public partial class FormKhachHang : Form
    {
        ChucNang chucnang = ChucNang.None;
        BL_KhachHang bl = new BL_KhachHang();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        void Reset_Txt()
        {
            txtID.ResetText();
            txtHoTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
        }
        void LoadData()
        {
            changState(false);
            try
            {
                DataSet ds = bl.LayKhachHang();
                dgvKH.DataSource = ds.Tables[0];
                dgvKH.AutoResizeColumns();
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
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                bl.XoaKhachHang(txtID.Text);
                LoadData();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            changState(false);
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
                        bl.ThemKhachHang(txtID.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text);
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
                    bl.CapNhatKhachHang(txtID.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text);
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
                DataSet dsimkiem = bl.TimKhachHang(txtID.Text, txtHoTen.Text, txtDiaChi.Text, txtSDT.Text);
                try
                {
                    if (dsimkiem != null)
                    {
                        dgvKH.DataSource = dsimkiem.Tables[0];
                        dgvKH.AutoResizeColumns();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung!");
                }
            }
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
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            LoadData();
        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            txtID.Text = dgvKH.Rows[r].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKH.Rows[r].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[r].Cells[2].Value.ToString();
            txtSDT.Text = dgvKH.Rows[r].Cells[3].Value.ToString();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaiKhoan tk = new FormTaiKhoan();
            tk.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.TimKiem;
            changState(true);
            Reset_Txt();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show((dgvKH.RowCount - 1).ToString());
        }
    }
}
