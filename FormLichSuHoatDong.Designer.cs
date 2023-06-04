namespace ADO_NET
{
    partial class FormLichSuHoatDong
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvLSHD = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnllshd = new System.Windows.Forms.Panel();
            this.pnlthuoctinh = new System.Windows.Forms.Panel();
            this.lbgio = new System.Windows.Forms.Label();
            this.numGio = new System.Windows.Forms.NumericUpDown();
            this.numthoigian = new System.Windows.Forms.NumericUpDown();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPhut = new System.Windows.Forms.NumericUpDown();
            this.lbsomay = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.numsomay = new System.Windows.Forms.NumericUpDown();
            this.lbuser = new System.Windows.Forms.Label();
            this.cbngay = new System.Windows.Forms.CheckBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.lbngay = new System.Windows.Forms.Label();
            this.btntatmay = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTinhThoiGian = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHD)).BeginInit();
            this.pnllshd.SuspendLayout();
            this.pnlthuoctinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numthoigian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsomay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(11, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 44);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvLSHD
            // 
            this.dgvLSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSHD.Location = new System.Drawing.Point(58, 93);
            this.dgvLSHD.Name = "dgvLSHD";
            this.dgvLSHD.RowHeadersWidth = 51;
            this.dgvLSHD.RowTemplate.Height = 24;
            this.dgvLSHD.Size = new System.Drawing.Size(805, 247);
            this.dgvLSHD.TabIndex = 46;
            this.dgvLSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSHD_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(15, 116);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 45);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(15, 13);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 45);
            this.btnthem.TabIndex = 44;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(15, 65);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(88, 45);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(12, 57);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(97, 36);
            this.btnreload.TabIndex = 42;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(12, 15);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(97, 36);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnllshd
            // 
            this.pnllshd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnllshd.Controls.Add(this.pnlthuoctinh);
            this.pnllshd.Controls.Add(this.cbngay);
            this.pnllshd.Controls.Add(this.Calendar);
            this.pnllshd.Controls.Add(this.btnhuy);
            this.pnllshd.Controls.Add(this.btnluu);
            this.pnllshd.Controls.Add(this.lbngay);
            this.pnllshd.Location = new System.Drawing.Point(192, 353);
            this.pnllshd.Name = "pnllshd";
            this.pnllshd.Size = new System.Drawing.Size(671, 272);
            this.pnllshd.TabIndex = 50;
            // 
            // pnlthuoctinh
            // 
            this.pnlthuoctinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlthuoctinh.Controls.Add(this.lbgio);
            this.pnlthuoctinh.Controls.Add(this.numGio);
            this.pnlthuoctinh.Controls.Add(this.numthoigian);
            this.pnlthuoctinh.Controls.Add(this.lbthoigian);
            this.pnlthuoctinh.Controls.Add(this.txttinhtrang);
            this.pnlthuoctinh.Controls.Add(this.label1);
            this.pnlthuoctinh.Controls.Add(this.label2);
            this.pnlthuoctinh.Controls.Add(this.numPhut);
            this.pnlthuoctinh.Controls.Add(this.lbsomay);
            this.pnlthuoctinh.Controls.Add(this.txtusername);
            this.pnlthuoctinh.Controls.Add(this.numsomay);
            this.pnlthuoctinh.Controls.Add(this.lbuser);
            this.pnlthuoctinh.Location = new System.Drawing.Point(283, 43);
            this.pnlthuoctinh.Name = "pnlthuoctinh";
            this.pnlthuoctinh.Size = new System.Drawing.Size(288, 207);
            this.pnlthuoctinh.TabIndex = 52;
            // 
            // lbgio
            // 
            this.lbgio.AutoSize = true;
            this.lbgio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgio.Location = new System.Drawing.Point(21, 16);
            this.lbgio.Name = "lbgio";
            this.lbgio.Size = new System.Drawing.Size(106, 20);
            this.lbgio.TabIndex = 7;
            this.lbgio.Text = "Giờ Sử dụng:";
            // 
            // numGio
            // 
            this.numGio.Location = new System.Drawing.Point(143, 14);
            this.numGio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numGio.Name = "numGio";
            this.numGio.Size = new System.Drawing.Size(44, 22);
            this.numGio.TabIndex = 51;
            // 
            // numthoigian
            // 
            this.numthoigian.Location = new System.Drawing.Point(216, 176);
            this.numthoigian.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numthoigian.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numthoigian.Name = "numthoigian";
            this.numthoigian.Size = new System.Drawing.Size(49, 22);
            this.numthoigian.TabIndex = 53;
            // 
            // lbthoigian
            // 
            this.lbthoigian.AutoSize = true;
            this.lbthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoigian.Location = new System.Drawing.Point(21, 176);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(146, 20);
            this.lbthoigian.TabIndex = 11;
            this.lbthoigian.Text = "Thời gian sử dụng:";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(143, 142);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(122, 22);
            this.txttinhtrang.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tình trạng:";
            // 
            // numPhut
            // 
            this.numPhut.Location = new System.Drawing.Point(216, 14);
            this.numPhut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numPhut.Name = "numPhut";
            this.numPhut.Size = new System.Drawing.Size(49, 22);
            this.numPhut.TabIndex = 52;
            // 
            // lbsomay
            // 
            this.lbsomay.AutoSize = true;
            this.lbsomay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsomay.Location = new System.Drawing.Point(21, 59);
            this.lbsomay.Name = "lbsomay";
            this.lbsomay.Size = new System.Drawing.Size(70, 20);
            this.lbsomay.TabIndex = 55;
            this.lbsomay.Text = "Số máy:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(143, 104);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(122, 22);
            this.txtusername.TabIndex = 10;
            // 
            // numsomay
            // 
            this.numsomay.Location = new System.Drawing.Point(118, 57);
            this.numsomay.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numsomay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numsomay.Name = "numsomay";
            this.numsomay.Size = new System.Drawing.Size(49, 22);
            this.numsomay.TabIndex = 57;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(21, 106);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(99, 20);
            this.lbuser.TabIndex = 4;
            this.lbuser.Text = "User Name:";
            // 
            // cbngay
            // 
            this.cbngay.AutoSize = true;
            this.cbngay.Enabled = false;
            this.cbngay.Location = new System.Drawing.Point(73, 15);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(93, 20);
            this.cbngay.TabIndex = 52;
            this.cbngay.Text = "Chọn ngày";
            this.cbngay.UseVisualStyleBackColor = true;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(9, 43);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 50;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(577, 92);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(85, 36);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(577, 43);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(85, 36);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngay.Location = new System.Drawing.Point(3, 9);
            this.lbngay.Name = "lbngay";
            this.lbngay.Size = new System.Drawing.Size(64, 25);
            this.lbngay.TabIndex = 0;
            this.lbngay.Text = "Ngày:";
            // 
            // btntatmay
            // 
            this.btntatmay.Location = new System.Drawing.Point(11, 63);
            this.btntatmay.Name = "btntatmay";
            this.btntatmay.Size = new System.Drawing.Size(97, 45);
            this.btntatmay.TabIndex = 51;
            this.btntatmay.Text = "Tắt máy";
            this.btntatmay.UseVisualStyleBackColor = true;
            this.btntatmay.Click += new System.EventHandler(this.btntatmay_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(11, 16);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(97, 55);
            this.btnTinhTong.TabIndex = 52;
            this.btnTinhTong.Text = "Tính Số Lượng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnreload);
            this.panel1.Location = new System.Drawing.Point(874, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 108);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btntatmay);
            this.panel2.Location = new System.Drawing.Point(875, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 132);
            this.panel2.TabIndex = 54;
            // 
            // btnTinhThoiGian
            // 
            this.btnTinhThoiGian.Location = new System.Drawing.Point(11, 78);
            this.btnTinhThoiGian.Name = "btnTinhThoiGian";
            this.btnTinhThoiGian.Size = new System.Drawing.Size(97, 73);
            this.btnTinhThoiGian.TabIndex = 53;
            this.btnTinhThoiGian.Text = "Tính Tổng Thời Gian Sử Dụng";
            this.btnTinhThoiGian.UseVisualStyleBackColor = true;
            this.btnTinhThoiGian.Click += new System.EventHandler(this.btnTinhThoiGian_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnreport);
            this.panel3.Controls.Add(this.btnTinhTong);
            this.panel3.Controls.Add(this.btnTinhThoiGian);
            this.panel3.Location = new System.Drawing.Point(875, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 272);
            this.panel3.TabIndex = 55;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(288, 30);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(438, 38);
            this.lbltitle.TabIndex = 68;
            this.lbltitle.Text = "Quản lý Lịch Sử Hoạt Động";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnthem);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.btnxoa);
            this.panel4.Location = new System.Drawing.Point(58, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 272);
            this.panel4.TabIndex = 69;
            // 
            // btnreport
            // 
            this.btnreport.Location = new System.Drawing.Point(11, 157);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(97, 55);
            this.btnreport.TabIndex = 70;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // FormLichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnllshd);
            this.Controls.Add(this.dgvLSHD);
            this.Name = "FormLichSuHoatDong";
            this.Text = "FormLichSuHoatDong";
            this.Load += new System.EventHandler(this.FormLichSuHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHD)).EndInit();
            this.pnllshd.ResumeLayout(false);
            this.pnllshd.PerformLayout();
            this.pnlthuoctinh.ResumeLayout(false);
            this.pnlthuoctinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numthoigian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsomay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvLSHD;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnllshd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsomay;
        private System.Windows.Forms.NumericUpDown numthoigian;
        private System.Windows.Forms.NumericUpDown numPhut;
        private System.Windows.Forms.NumericUpDown numGio;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lbthoigian;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lbgio;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbngay;
        private System.Windows.Forms.NumericUpDown numsomay;
        private System.Windows.Forms.Button btntatmay;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbngay;
        private System.Windows.Forms.Panel pnlthuoctinh;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTinhThoiGian;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnreport;
    }
}