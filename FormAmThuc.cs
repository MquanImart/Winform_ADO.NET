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
    internal enum LuaChon
    {
        None,
        Them,
        Xoa,
        Sua,
        TimKiem
    }
    public partial class FormAmThuc : Form
    {
        LuaChon luaChon = LuaChon.None;
        BL_AmThuc blAmThuc = new BL_AmThuc();
        public FormAmThuc()
        {
            InitializeComponent();
        }
        void Reset_Txt()
        {
            txtTen.ResetText();
            txtID.ResetText();
            txtGia.ResetText();
            txtSL.ResetText();
        }
        void changeState(bool chinhsua)
        {
            if (chinhsua)
            {
                Reset_Txt();
            }
            pnlAmThuc.Enabled = chinhsua;
            btnHuy.Enabled = chinhsua;
            btnLuu.Enabled = chinhsua;

            //btnThem.Enabled = !chinhsua;
            //btnXoa.Enabled = !chinhsua;
            //btnSua.Enabled = !chinhsua;
            //btnThoat.Enabled = !chinhsua;
            //btnTimKiem.Enabled = !chinhsua;
        }
        void LoadData()
        {
            changeState(false);
            try
            {
                dgvAmThuc.DataSource = blAmThuc.LayAmThuc().Tables[0];
                dgvAmThuc.AutoResizeColumns();
                dgvAmThuc_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table AmThuc. Lỗi rồi!!!");
            }

        }
        private void FormAmThuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAmThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvAmThuc.CurrentCell.RowIndex;
            txtID.Text = dgvAmThuc.Rows[r].Cells[0].Value.ToString();
            txtTen.Text = dgvAmThuc.Rows[r].Cells[1].Value.ToString();
            txtGia.Text = dgvAmThuc.Rows[r].Cells[2].Value.ToString();
            txtSL.Text = dgvAmThuc.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Xoa;
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                try
                {
                    if (blAmThuc.XoaAmThuc(txtID.Text))
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không xóa được. Lỗi rồi!!!");
                }
            }

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
                        if (blAmThuc.ThemAmThuc(txtID.Text, txtTen.Text, txtGia.Text, txtSL.Text))
                        {
                            LoadData();
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else
                        {
                            MessageBox.Show("Không thêm được!");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID");
                    txtID.Focus();
                }
            }
            else if (luaChon == LuaChon.Sua)
            {
                if (!txtID.Text.Trim().Equals(""))
                {
                    try
                    {
                        if (blAmThuc.CapNhatAmThuc(txtID.Text, txtTen.Text, txtGia.Text, txtSL.Text))
                        {
                            LoadData();
                            MessageBox.Show("Đã sửa xong!");
                        }
                        else
                        {
                            MessageBox.Show("Không sửa được!");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập ID");
                    txtID.Focus();
                }
            }
            else if (luaChon == LuaChon.TimKiem)
            {
                DataSet ds = blAmThuc.TimKiemAmThuc(txtID.Text, txtTen.Text, txtGia.Text, txtSL.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvAmThuc.DataSource = ds.Tables[0];
                    dgvAmThuc.AutoResizeColumns();
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
            txtTen.Enabled = false;
            txtGia.Enabled = true;
            txtSL.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //btnSua.Enabled = !chinhsua;
            btnTimKiem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Them;
            changeState(true);
            txtID.Enabled = true;
            txtID.Focus();

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnTimKiem.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetText();
            LoadData();
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            int total = 0;
            int n = dgvAmThuc.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                total += int.Parse(dgvAmThuc.Rows[i].Cells[2].Value.ToString()) * int.Parse(dgvAmThuc.Rows[i].Cells[3].Value.ToString());
            }
            MessageBox.Show($"Tổng tiền là: {total} đồng");

        }

        private void btnTongSL_Click(object sender, EventArgs e)
        {
            //  Tính tổng số lượng món ăn trong dgvAmThuc
            int total = 0;
            int n = dgvAmThuc.Rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                total += int.Parse(dgvAmThuc.Rows[i].Cells[3].Value.ToString());
            }
            MessageBox.Show($"Tổng số lượng là: {total}");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.TimKiem;
            changeState(true);
            ResetText();
            txtID.Enabled = true;
            txtTen.Enabled = true;
            txtGia.Enabled = true;
            txtSL.Enabled = true;

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;

        }
    }
}
