using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ADO_NET.BS_layer;
using System.Data.SqlClient;

namespace ADO_NET
{
    public partial class FormHangHoa : Form
    {
        LuaChon luaChon = LuaChon.None;
        BL_HangHoa blHangHoa = new BL_HangHoa();
        public FormHangHoa()
        {
            InitializeComponent();
        }
        void Reset_Txt()
        {
            txtID.ResetText();
            txtLoai.ResetText();
            txtTen.ResetText();
            txtGia.ResetText();
            txtSL.ResetText();
        }
        void changeState(bool chinhsua)
        {
            if (chinhsua)
            {
                Reset_Txt();
            }
            pnlHangHoa.Enabled = chinhsua;
            btnHuy.Enabled = chinhsua;
            btnLuu.Enabled = chinhsua;

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            pnlHangHoa.Enabled = true;
        }
        void LoadData()
        {
            changeState(false);
            try
            {
                dgvHangHoa.DataSource = blHangHoa.LayHangHoa().Tables[0];
                dgvHangHoa.AutoResizeColumns();
                dgvHangHoa_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHangHoa.CurrentCell.RowIndex;
            if (r < 0 || r >= dgvHangHoa.RowCount) return;
            txtID.Text = dgvHangHoa.Rows[r].Cells[0].Value.ToString();
            txtLoai.Text = dgvHangHoa.Rows[r].Cells[1].Value.ToString();
            txtTen.Text = dgvHangHoa.Rows[r].Cells[2].Value.ToString();
            txtSL.Text = dgvHangHoa.Rows[r].Cells[3].Value.ToString();
            txtGia.Text = dgvHangHoa.Rows[r].Cells[4].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Xoa;
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa hàng hóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
            {
                try
                {
                    if (blHangHoa.XoaHangHoa(txtID.Text))
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else MessageBox.Show("Không xóa được!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được. Lỗi rồi!!!");
                }
            }
            else MessageBox.Show("Không thực hiện việc xóa hàng hóa!");

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            changeState(false);
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnTimKiem.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luaChon == LuaChon.Them)
            {
                if (!txtID.Text.Trim().Equals(""))
                {
                    try
                    {
                        if (blHangHoa.ThemHangHoa(txtID.Text, txtLoai.Text, txtTen.Text, txtSL.Text, txtGia.Text, Calendar.SelectionStart))
                        {
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else MessageBox.Show("Không thêm được!");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID!");
                }
            }
            else if (luaChon == LuaChon.Sua)
            {
                try
                {
                    if (blHangHoa.CapNhatHangHoa(txtID.Text, txtLoai.Text, txtTen.Text, txtSL.Text, txtGia.Text, Calendar.SelectionStart))
                    {
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    else MessageBox.Show("Không sửa được!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!!!");
                }
            }
            else if (luaChon == LuaChon.TimKiem)
            {
                DataSet ds = blHangHoa.TimKiemHangHoa(txtID.Text, txtLoai.Text, txtTen.Text, txtSL.Text, txtGia.Text, Calendar.SelectionStart);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvHangHoa.DataSource = ds.Tables[0];
                    dgvHangHoa.AutoResizeColumns();
                    dgvHangHoa_CellClick(null, null);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Sua;
            changeState(true);
            txtID.Enabled = false;
            txtTen.Enabled = true;
            txtLoai.Enabled = true;
            txtSL.Enabled = true;
            txtGia.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Them;
            changeState(true);
            txtID.Enabled = true;
            txtTen.Focus();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetText();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.TimKiem;
            changeState(true);
            ResetText();
            txtID.Enabled = true;
            txtLoai.Enabled = true;
            txtTen.Enabled = true;
            txtSL.Enabled = true;
            txtGia.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTongSL_Click(object sender, EventArgs e)
        {
            int tongSL = 0;
            int n = dgvHangHoa.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                tongSL += int.Parse(dgvHangHoa.Rows[i].Cells[3].Value.ToString());
            }
            MessageBox.Show($"Tổng số lượng là: {tongSL}");

        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            int n = dgvHangHoa.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                tongTien += int.Parse(dgvHangHoa.Rows[i].Cells[3].Value.ToString()) * int.Parse(dgvHangHoa.Rows[i].Cells[4].Value.ToString());
            }
            MessageBox.Show($"Tổng tiền là: {tongTien} đồng");
        }
    }
}
