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

namespace ADO_NET.BS_layer
{
    public partial class FormMayTinh : Form
    {
        ChucNang chucnang = ChucNang.None;
        BL_MayTinh bl = new BL_MayTinh();
        public FormMayTinh()
        {
            InitializeComponent();
        }
        void Reset_Txt()
        {
            txtID.ResetText();
            txtmanhinh.ResetText();
            txtCPU.ResetText();
            txtOcung.ResetText();
            txtRam.ResetText();
            txttinhtrang.ResetText();
        }
        void LoadData()
        {
            changState(false);
            try
            {
                DataSet ds = bl.LayDuLieu();
                dgvMT.DataSource = ds.Tables[0];
                dgvMT.AutoResizeColumns();
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
        private void FormMayTinh_Load(object sender, EventArgs e)
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
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Them;
            txtID.Enabled = true;

            changState(true);
            txtID.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.Sua;

            changState(true);
            txtID.Enabled = false;
            txtID.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            chucnang = ChucNang.TimKiem;
            changState(true);
            Reset_Txt();
            txtID.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn xóa?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                bl.XoaMayTinh(txtID.Text);
                LoadData();
            }
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
                        bl.ThemMayTinh(txtID.Text, txtmanhinh.Text, txtCPU.Text, txtOcung.Text, txtRam.Text, txttinhtrang.Text);
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
                    bl.CapNhatMayTinh(txtID.Text, txtmanhinh.Text, txtCPU.Text, txtOcung.Text, txtRam.Text, txttinhtrang.Text);
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
                DataSet dsimkiem = bl.TinhMayTinh(txtID.Text, txtmanhinh.Text, txtCPU.Text, txtOcung.Text, txtRam.Text, txttinhtrang.Text);
                try
                {
                    if (dsimkiem != null)
                    {
                        dgvMT.DataSource = dsimkiem.Tables[0];
                        dgvMT.AutoResizeColumns();
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
        }

        private void dgvMT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMT.CurrentCell.RowIndex;
            txtID.Text = dgvMT.Rows[r].Cells[0].Value.ToString();
            txtmanhinh.Text = dgvMT.Rows[r].Cells[1].Value.ToString();
            txtCPU.Text = dgvMT.Rows[r].Cells[2].Value.ToString();
            txtOcung.Text = dgvMT.Rows[r].Cells[3].Value.ToString();
            txtRam.Text = dgvMT.Rows[r].Cells[4].Value.ToString();
            txttinhtrang.Text = dgvMT.Rows[r].Cells[5].Value.ToString();
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Số lượng máy tính: " + (dgvMT.RowCount - 1).ToString());
        }
    }
}
