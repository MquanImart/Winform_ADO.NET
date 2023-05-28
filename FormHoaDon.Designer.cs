namespace ADO_NET
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTien = new System.Windows.Forms.TextBox();
            this.btnLoi = new System.Windows.Forms.Button();
            this.btnTongChi = new System.Windows.Forms.Button();
            this.btnTongThu = new System.Windows.Forms.Button();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.numericUpDownSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.lbDanhMuc = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            this.pnlHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(71, 169);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(131, 20);
            this.txtTien.TabIndex = 41;
            // 
            // btnLoi
            // 
            this.btnLoi.Location = new System.Drawing.Point(564, 197);
            this.btnLoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoi.Name = "btnLoi";
            this.btnLoi.Size = new System.Drawing.Size(79, 29);
            this.btnLoi.TabIndex = 66;
            this.btnLoi.Text = "Lợi nhuận";
            this.btnLoi.UseVisualStyleBackColor = true;
            this.btnLoi.Click += new System.EventHandler(this.btnLoi_Click);
            // 
            // btnTongChi
            // 
            this.btnTongChi.Location = new System.Drawing.Point(387, 197);
            this.btnTongChi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTongChi.Name = "btnTongChi";
            this.btnTongChi.Size = new System.Drawing.Size(85, 29);
            this.btnTongChi.TabIndex = 65;
            this.btnTongChi.Text = "Tổng Chi";
            this.btnTongChi.UseVisualStyleBackColor = true;
            this.btnTongChi.Click += new System.EventHandler(this.btnTongChi_Click);
            // 
            // btnTongThu
            // 
            this.btnTongThu.Location = new System.Drawing.Point(476, 197);
            this.btnTongThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTongThu.Name = "btnTongThu";
            this.btnTongThu.Size = new System.Drawing.Size(79, 29);
            this.btnTongThu.TabIndex = 64;
            this.btnTongThu.Text = "Tổng Thu";
            this.btnTongThu.UseVisualStyleBackColor = true;
            this.btnTongThu.Click += new System.EventHandler(this.btnTongThu_Click);
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(12, 172);
            this.lbSoTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(43, 13);
            this.lbSoTien.TabIndex = 40;
            this.lbSoTien.Text = "Số tiền:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(549, 70);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(64, 29);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(549, 36);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 29);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // numericUpDownSec
            // 
            this.numericUpDownSec.Location = new System.Drawing.Point(566, 172);
            this.numericUpDownSec.Name = "numericUpDownSec";
            this.numericUpDownSec.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownSec.TabIndex = 30;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(517, 172);
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownMinute.TabIndex = 29;
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(467, 172);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownHour.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Giờ:";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(223, 14);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(35, 13);
            this.lbNgay.TabIndex = 26;
            this.lbNgay.Text = "Ngày:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(226, 36);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Location = new System.Drawing.Point(71, 137);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(131, 20);
            this.txtDanhMuc.TabIndex = 24;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(71, 105);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(131, 20);
            this.txtLoai.TabIndex = 22;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(37, 108);
            this.lbLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(30, 13);
            this.lbLoai.TabIndex = 21;
            this.lbLoai.Text = "Loại:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(131, 20);
            this.txtID.TabIndex = 20;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(45, 79);
            this.lbid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(21, 13);
            this.lbid.TabIndex = 19;
            this.lbid.Text = "ID:";
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.txtTien);
            this.pnlHoaDon.Controls.Add(this.lbSoTien);
            this.pnlHoaDon.Controls.Add(this.btnHuy);
            this.pnlHoaDon.Controls.Add(this.btnLuu);
            this.pnlHoaDon.Controls.Add(this.numericUpDownSec);
            this.pnlHoaDon.Controls.Add(this.numericUpDownMinute);
            this.pnlHoaDon.Controls.Add(this.numericUpDownHour);
            this.pnlHoaDon.Controls.Add(this.label1);
            this.pnlHoaDon.Controls.Add(this.lbNgay);
            this.pnlHoaDon.Controls.Add(this.monthCalendar1);
            this.pnlHoaDon.Controls.Add(this.txtDanhMuc);
            this.pnlHoaDon.Controls.Add(this.lbDanhMuc);
            this.pnlHoaDon.Controls.Add(this.txtLoai);
            this.pnlHoaDon.Controls.Add(this.lbLoai);
            this.pnlHoaDon.Controls.Add(this.txtID);
            this.pnlHoaDon.Controls.Add(this.lbid);
            this.pnlHoaDon.Location = new System.Drawing.Point(19, 231);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(624, 222);
            this.pnlHoaDon.TabIndex = 63;
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.AutoSize = true;
            this.lbDanhMuc.Location = new System.Drawing.Point(12, 140);
            this.lbDanhMuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(59, 13);
            this.lbDanhMuc.TabIndex = 23;
            this.lbDanhMuc.Text = "Danh mục:";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(648, 43);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(64, 29);
            this.btnReload.TabIndex = 62;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(648, 10);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 29);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(216, 197);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 29);
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(148, 197);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 29);
            this.btnTimKiem.TabIndex = 59;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(80, 197);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 29);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 197);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 29);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 12);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(631, 180);
            this.dgvHoaDon.TabIndex = 56;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 462);
            this.Controls.Add(this.btnLoi);
            this.Controls.Add(this.btnTongChi);
            this.Controls.Add(this.btnTongThu);
            this.Controls.Add(this.pnlHoaDon);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            this.pnlHoaDon.ResumeLayout(false);
            this.pnlHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Button btnLoi;
        private System.Windows.Forms.Button btnTongChi;
        private System.Windows.Forms.Button btnTongThu;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.NumericUpDown numericUpDownSec;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Label lbDanhMuc;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}