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
    public partial class FormTaiKhoan : Form
    {
        bool Them = false;
        BL_TaiKhoan bl = new BL_TaiKhoan();
        DataTable dt;
        public FormTaiKhoan()
        {
            InitializeComponent();
            dt = new DataTable();
        }
        void LoadData()
        {
            changState(false);
            try
            {
                DataSet ds = bl.LayTaiKhoan();
                this.dt = ds.Tables[0];
                dgvTK.DataSource = dt;
                dgvTK.Columns[1].Visible = false;
                dgvTK.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }
        void Reset_Txt()
        {
            txtID.ResetText();
            txtUser.ResetText();
            txtPass.ResetText();
            txtMoney.ResetText();
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
        private void FormTaiKhoan_Load(object sender, EventArgs e)
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
                bl.XoaTaiKhoan(txtUser.Text);
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
            if (Them == true)
            {
                if (!txtUser.Text.Trim().Equals(""))
                {
                    bl.ThemTaiKhoan(txtUser.Text, txtPass.Text, txtID.Text, Convert.ToInt32(txtMoney.Text));
                    LoadData();
                    Reset_Txt();
                }
                else
                {
                    MessageBox.Show("Nhập User name!");
                    txtID.Focus();
                }
            }
            else
            {
                if (!txtUser.Text.Trim().Equals(""))
                {
                    bl.CapNhatTaiKhoan(txtUser.Text, txtPass.Text, txtID.Text, Convert.ToInt32(txtMoney.Text));
                    LoadData();
                    Reset_Txt();
                }
                else
                {
                    MessageBox.Show("Nhập User name!");
                    txtID.Focus();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Them = false;

            changState(true);
            txtID.Enabled = false;
            txtID.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtID.Enabled = true;

            changState(true);
            txtID.Focus();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTK.CurrentCell.RowIndex;
            txtUser.Text = dgvTK.Rows[r].Cells[0].Value.ToString();
            txtPass.Text = dgvTK.Rows[r].Cells[1].Value.ToString();
            txtID.Text = dgvTK.Rows[r].Cells[2].Value.ToString();
            txtMoney.Text = dgvTK.Rows[r].Cells[3].Value.ToString();
            txtshowpass.ResetText();
        }

        private void btnshowpass_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = txtPass.PasswordChar == '\0'? '*': '\0';
        }

        private void btnshowpassw_Click(object sender, EventArgs e)
        {
            int r = dgvTK.CurrentCell.RowIndex;
            txtshowpass.Text = dgvTK.Rows[r].Cells[1].Value.ToString();
            txtshowpass.PasswordChar = '\0';
        }
        private void ThayDoiTien(bool isadd)
        {
            int r = dgvTK.CurrentCell.RowIndex;
            txtUser.Text = dgvTK.Rows[r].Cells[0].Value.ToString();
            int money_crr = Convert.ToInt32(dgvTK.Rows[r].Cells[3].Value);
            if (isadd) money_crr = money_crr + Convert.ToInt32(numNap.Value);
            else if (money_crr - Convert.ToInt32(numTru.Value) >= 0) money_crr = money_crr - Convert.ToInt32(numTru.Value);
            else
            {
                numNap.Value = 0;
                numTru.Value = 0;
                MessageBox.Show("So du khong du!!!");
                return;
            }
            bl.CapNhatTaiKhoan(txtUser.Text, dgvTK.Rows[r].Cells[1].Value.ToString(), dgvTK.Rows[r].Cells[2].Value.ToString(), money_crr);
            LoadData();
            numNap.Value = 0;
            numTru.Value = 0;
        }
        private void btnNaptien_Click(object sender, EventArgs e)
        {
            ThayDoiTien(true);
        }
        private void btnTruTien_Click(object sender, EventArgs e)
        {
            ThayDoiTien(false);
        }
    }
}
