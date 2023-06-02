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
    public partial class FormGiuXe : Form
    {
        ChucNang chucnang = ChucNang.None;
        BL_GiuXe bl = new BL_GiuXe();
        DataTable dt;
        bool click_cell = true;
        public FormGiuXe()
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
                dgvGX.DataSource = dt;
                dgvGX.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }
        void Reset_Txt()
        {
            txtBienSo.ResetText();
            txtIDCard.ResetText();

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
            pnlgx.Enabled = chinhsua;
            btnluu.Enabled = chinhsua;
            btnhuy.Enabled = chinhsua;

            btnXeRa.Enabled = !chinhsua;
            btnthem.Enabled = !chinhsua;
            btnsua.Enabled = !chinhsua;
            btnxoa.Enabled = !chinhsua;
            btnthoat.Enabled = !chinhsua;
        }
        private void FormGiuXe_Load(object sender, EventArgs e)
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
            click_cell = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Them;
            changState(true);
            numGioRa.Enabled = false;
            numPhutRa.Enabled = false;
            click_cell = false;
        }
        private void btnXeRa_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Sua;
            Enable_Button(true);
            pnlgx.Enabled = true;
            numGioRa.Enabled = true;
            numPhutRa.Enabled = true;
            Calendar.Enabled = false;
            numGioVao.Enabled = false;
            numPhutVao.Enabled = false;
            txtBienSo.Enabled = false;
            txtIDCard.Enabled = false;
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
            numPhutRa.Enabled = true;
            Calendar.Enabled = true;
            numGioVao.Enabled = true;
            numPhutVao.Enabled = true;
            txtBienSo.Enabled = true;
            txtIDCard.Enabled = true;
            click_cell = false;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                DateTime ngay = Calendar.SelectionStart;
                DateTime giovao = new DateTime(1, 1, 1, Convert.ToInt32(numGioVao.Value), Convert.ToInt32(numPhutVao.Value), 0);
                string bienso = txtBienSo.Text;
                bl.XoaLichSuGiuXe(ngay, giovao, bienso);
                LoadData();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DateTime ngay = Calendar.SelectionStart;
            DateTime giovao = new DateTime(1, 1, 1, Convert.ToInt32(numGioVao.Value), Convert.ToInt32(numPhutVao.Value), 0);
            DateTime giora = new DateTime(1, 1, 1, Convert.ToInt32(numGioRa.Value), Convert.ToInt32(numPhutRa.Value), 0);
            
            if (chucnang == ChucNang.Them)
            {
                if (!txtBienSo.Text.Trim().Equals(""))
                {
                    bl.ThemXeVao(ngay,giovao,txtBienSo.Text, txtIDCard.Text);
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
                if (!txtBienSo.Text.Trim().Equals(""))
                {
                    bl.ThayDoiThongTinGiuXe(ngay, giovao, giora, txtBienSo.Text, txtIDCard.Text);
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
                if (cbngay.Checked == true) { dsimkiem = bl.TimKiemThongTin(ngay, giovao, giora, txtBienSo.Text, txtIDCard.Text); }
                else dsimkiem = bl.TimKiemThongTin_NotNgay(giovao, giora, txtBienSo.Text, txtIDCard.Text);
                try
                {
                    if (dsimkiem != null)
                    {
                        dgvGX.DataSource = dsimkiem.Tables[0];
                        dgvGX.AutoResizeColumns();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung!");
                }
                cbngay.Enabled = false;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            changState(false);
            cbngay.Enabled = false;
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGX.CurrentCell.RowIndex;
            if (r < dgvGX.Rows.Count - 1 && click_cell)
            {
                Calendar.SelectionStart = Convert.ToDateTime(dgvGX.Rows[r].Cells[0].Value);
                TimeSpan giovao = (TimeSpan)dgvGX.Rows[r].Cells[1].Value;
                numGioVao.Value = giovao.Hours;
                numPhutVao.Value = giovao.Minutes;

                try
                {
                    TimeSpan giora = (TimeSpan)dgvGX.Rows[r].Cells[2].Value;
                    numGioRa.Value = giora.Hours;
                    numPhutRa.Value = giora.Minutes;
                }
                catch
                {
                    numGioRa.Value = 0;
                    numPhutRa.Value = 0;
                }

                txtBienSo.Text = dgvGX.Rows[r].Cells[3].Value.ToString();
                txtIDCard.Text = dgvGX.Rows[r].Cells[4].Value.ToString();
            }      
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show((dgvGX.RowCount - 1).ToString());
        }
    }
}
