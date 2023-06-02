namespace ADO_NET
{
    partial class FormHangHoa
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
            this.btnTongTien = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.lbLoai = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbSl = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.btnTongSL = new System.Windows.Forms.Button();
            this.pnlHangHoa = new System.Windows.Forms.Panel();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.pnlHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTongTien
            // 
            this.btnTongTien.Location = new System.Drawing.Point(653, 274);
            this.btnTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(105, 36);
            this.btnTongTien.TabIndex = 56;
            this.btnTongTien.Text = "Tổng giá tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 274);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 36);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(643, 89);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 36);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(643, 47);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 36);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(273, 15);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(79, 16);
            this.lbNgay.TabIndex = 19;
            this.lbNgay.Text = "Ngày Nhập:";
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(60, 55);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(173, 22);
            this.txtLoai.TabIndex = 18;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(15, 59);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(36, 16);
            this.lbLoai.TabIndex = 17;
            this.lbLoai.Text = "Loại:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(92, 196);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(141, 22);
            this.txtSL.TabIndex = 16;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(60, 100);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 22);
            this.txtTen.TabIndex = 15;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(60, 144);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(173, 22);
            this.txtGia.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 22);
            this.txtID.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(288, 274);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 36);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(197, 274);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 36);
            this.btnTimKiem.TabIndex = 54;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(107, 274);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 36);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(795, 55);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(85, 36);
            this.btnReload.TabIndex = 51;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(795, 15);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 36);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbSl
            // 
            this.lbSl.AutoSize = true;
            this.lbSl.Location = new System.Drawing.Point(11, 204);
            this.lbSl.Name = "lbSl";
            this.lbSl.Size = new System.Drawing.Size(67, 16);
            this.lbSl.TabIndex = 12;
            this.lbSl.Text = "Số Lượng:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(15, 108);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(34, 16);
            this.lbTen.TabIndex = 11;
            this.lbTen.Text = "Tên:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(25, 148);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(31, 16);
            this.lbGia.TabIndex = 10;
            this.lbGia.Text = "Giá:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(25, 23);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 9;
            this.lbid.Text = "ID:";
            // 
            // btnTongSL
            // 
            this.btnTongSL.Location = new System.Drawing.Point(535, 274);
            this.btnTongSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongSL.Name = "btnTongSL";
            this.btnTongSL.Size = new System.Drawing.Size(113, 36);
            this.btnTongSL.TabIndex = 57;
            this.btnTongSL.Text = "Tổng số lượng";
            this.btnTongSL.UseVisualStyleBackColor = true;
            this.btnTongSL.Click += new System.EventHandler(this.btnTongSL_Click);
            // 
            // pnlHangHoa
            // 
            this.pnlHangHoa.Controls.Add(this.btnHuy);
            this.pnlHangHoa.Controls.Add(this.btnLuu);
            this.pnlHangHoa.Controls.Add(this.lbNgay);
            this.pnlHangHoa.Controls.Add(this.txtLoai);
            this.pnlHangHoa.Controls.Add(this.lbLoai);
            this.pnlHangHoa.Controls.Add(this.txtSL);
            this.pnlHangHoa.Controls.Add(this.txtTen);
            this.pnlHangHoa.Controls.Add(this.txtGia);
            this.pnlHangHoa.Controls.Add(this.txtID);
            this.pnlHangHoa.Controls.Add(this.lbSl);
            this.pnlHangHoa.Controls.Add(this.lbTen);
            this.pnlHangHoa.Controls.Add(this.lbGia);
            this.pnlHangHoa.Controls.Add(this.lbid);
            this.pnlHangHoa.Controls.Add(this.Calendar);
            this.pnlHangHoa.Location = new System.Drawing.Point(15, 336);
            this.pnlHangHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHangHoa.Name = "pnlHangHoa";
            this.pnlHangHoa.Size = new System.Drawing.Size(743, 252);
            this.pnlHangHoa.TabIndex = 49;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(277, 42);
            this.Calendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(16, 15);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.Size = new System.Drawing.Size(741, 254);
            this.dgvHangHoa.TabIndex = 48;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongSL);
            this.Controls.Add(this.pnlHangHoa);
            this.Controls.Add(this.dgvHangHoa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.pnlHangHoa.ResumeLayout(false);
            this.pnlHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Label lbLoai;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbSl;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btnTongSL;
        private System.Windows.Forms.Panel pnlHangHoa;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView dgvHangHoa;
    }
}