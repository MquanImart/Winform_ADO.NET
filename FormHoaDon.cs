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
    public partial class FormHoaDon : Form
    {
        LuaChon luaChon = LuaChon.None;
        BL_HoaDon blHoaDon = new BL_HoaDon();
        bool click_cell = true;
        public FormHoaDon()
        {
            InitializeComponent();
        }
        void Reset_Txt()
        {
            txtID.ResetText();
            txtDanhMuc.ResetText();
            txtLoai.ResetText();
            txtTien.ResetText();
        }
        void changeState(bool chinhsua)
        {
            if (chinhsua)
            {
                Reset_Txt();
            }
            pnlHoaDon.Enabled = chinhsua;
            btnHuy.Enabled = chinhsua;
            btnLuu.Enabled = chinhsua;
        }
        void LoadData()
        {
            changeState(false);
            try
            {
                dgvHoaDon.DataSource = blHoaDon.LayHoaDon().Tables[0];
                dgvHoaDon.AutoResizeColumns();
                dgvHoaDon_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HoaDon. Lỗi rồi!!!");
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            if (click_cell && r < dgvAmThuc.RowCount - 1)
            {
                txtID.Text = dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                txtDanhMuc.Text = dgvHoaDon.Rows[r].Cells[3].Value.ToString();
                txtLoai.Text = dgvHoaDon.Rows[r].Cells[4].Value.ToString();
                txtTien.Text = dgvHoaDon.Rows[r].Cells[5].Value.ToString();
                // Đưa hàng thứ 1 của dgvHoaDon lên monthCalendar1
                monthCalendar1.SelectionStart = Convert.ToDateTime(dgvHoaDon.Rows[r].Cells[1].Value);
                //  Dùng timespan để lấy giờ
                TimeSpan gio = (TimeSpan)dgvHoaDon.Rows[r].Cells[2].Value;
                numericUpDownHour.Value = gio.Hours;
                numericUpDownMinute.Value = gio.Minutes;
                numericUpDownSec.Value = gio.Seconds;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Xoa;
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc xóa không?", "Xóa Hóa Đơn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                try
                {
                    if (blHoaDon.XoaHoaDon(txtID.Text))
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
            else
            {
                MessageBox.Show("Không thực hiện việc xóa Hóa Đơn!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetText();
            changeState(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnTimKiem.Enabled = true;
            click_cell = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime gio = new DateTime(1, 1, 1, Convert.ToInt32(numericUpDownHour.Value), Convert.ToInt32(numericUpDownMinute.Value), Convert.ToInt32(numericUpDownSec.Value));

            if (luaChon == LuaChon.Them)
            {
                if (!txtID.Text.Trim().Equals(""))
                {
                    try
                    {
                        if (blHoaDon.ThemHoaDon(txtID.Text, monthCalendar1.SelectionStart, gio, txtDanhMuc.Text, txtLoai.Text, txtTien.Text))
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
            }
            else if (luaChon == LuaChon.Sua)
            {
                try
                {
                    if (blHoaDon.CapNhatHoaDon(txtID.Text, monthCalendar1.SelectionStart, gio, txtDanhMuc.Text, txtLoai.Text, txtTien.Text))
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
            else if (luaChon == LuaChon.TimKiem)
            {
                try
                {
                    dgvHoaDon.DataSource = blHoaDon.TimKiemHoaDon(txtID.Text, monthCalendar1.SelectionStart, gio, txtDanhMuc.Text, txtLoai.Text, txtTien.Text).Tables[0];
                    dgvHoaDon.AutoResizeColumns();
                    dgvHoaDon_CellClick(null, null);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không tìm thấy. Lỗi rồi!!!");
                }
            }
            click_cell = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Sua;
            changeState(true);
            txtID.Enabled = false;
            txtDanhMuc.Enabled = true;
            txtLoai.Enabled = true;
            txtTien.Enabled = true;
            monthCalendar1.Enabled = true;
            numericUpDownHour.Enabled = true;
            numericUpDownMinute.Enabled = true;
            numericUpDownSec.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.Them;
            changeState(true);
            ResetText();
            txtID.Enabled = true;
            txtDanhMuc.Enabled = true;
            txtLoai.Enabled = true;
            txtTien.Enabled = true;
            monthCalendar1.Enabled = true;
            numericUpDownHour.Enabled = true;
            numericUpDownMinute.Enabled = true;
            numericUpDownSec.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = false;
            click_cell = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            luaChon = LuaChon.TimKiem;
            changeState(true);
            ResetText();
            txtID.Enabled = true;
            txtDanhMuc.Enabled = true;
            txtLoai.Enabled = true;
            txtTien.Enabled = true;
            monthCalendar1.Enabled = true;
            numericUpDownHour.Enabled = true;
            numericUpDownMinute.Enabled = true;
            numericUpDownSec.Enabled = true;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            click_cell = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetText();
            LoadData();
            click_cell = true;
        }

        private void btnTongChi_Click(object sender, EventArgs e)
        {
            int tongChi = 0;
            string chi = "chi  ";
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                string cellValue = Convert.ToString(dgvHoaDon.Rows[i].Cells[4].Value);
                if (cellValue.Equals(chi))
                {
                    tongChi += Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value);
                }
            }
            MessageBox.Show($"Tổng chi là: {tongChi}");
        }

        private void btnTongThu_Click(object sender, EventArgs e)
        {
            int tongThu = 0;
            string thu = "thu  ";
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                string cellValue = Convert.ToString(dgvHoaDon.Rows[i].Cells[4].Value);
                if (cellValue.Equals(thu))
                {
                    tongThu += Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value);
                }
            }
            MessageBox.Show("Tổng thu là: " + tongThu.ToString());
        }

        private void btnLoi_Click(object sender, EventArgs e)
        {
            int loiNhuan = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                string cellValue = Convert.ToString(dgvHoaDon.Rows[i].Cells[4].Value);
                if (cellValue.Equals("thu  "))
                {
                    loiNhuan += Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value);
                }
                else
                {
                    loiNhuan -= Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value);
                }
            }
            MessageBox.Show("Lợi nhuận là: " + loiNhuan.ToString());
        }
    }
}
