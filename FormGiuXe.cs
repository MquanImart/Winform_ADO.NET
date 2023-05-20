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
        bool Them = false;
        BL_GiuXe bl = new BL_GiuXe();
        DataTable dt;
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
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them = true;
            changState(true);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Them = false;
            Enable_Button(true);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                DateTime ngay = Calendar.SelectionStart;
                DateTime giovao = new DateTime();
                giovao.AddHours(Convert.ToInt32(numGioVao.Value));
                giovao.AddMinutes(Convert.ToInt32(numPhutVao.Value));
                string bienso = txtBienSo.Text;
                bl.XoaLichSuGiuXe(ngay, giovao, bienso);
                LoadData();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DateTime ngay = Calendar.SelectionStart;
            DateTime giovao = new DateTime();
            DateTime giora = new DateTime();
            giovao.AddHours(Convert.ToInt32(numGioVao.Value));
            giovao.AddMinutes(Convert.ToInt32(numPhutVao.Value));
            giora.AddHours(Convert.ToInt32(numGioRa.Value));
            giora.AddMinutes(Convert.ToInt32(numPhutRa.Value));
            if (Them == true)
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
            else
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
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Reset_Txt();
            changState(false);
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGX.CurrentCell.RowIndex;
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
                numGioRa.Value = -1;
                numPhutRa.Value = 0;
            } 
            
            txtBienSo.Text = dgvGX.Rows[r].Cells[3].Value.ToString();
            txtIDCard.Text = dgvGX.Rows[r].Cells[4].Value.ToString();
        }
    }
}
