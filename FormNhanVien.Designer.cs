namespace ADO_NET
{
    partial class FormNhanVien
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnlnv = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnam = new System.Windows.Forms.CheckBox();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.lblcccd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.lbsdt = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.btnTinhSL = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.pnlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(216, 255);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 44);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tim Kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(41, 21);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(1130, 217);
            this.dgvNV.TabIndex = 46;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(318, 255);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 44);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(41, 255);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 44);
            this.btnthem.TabIndex = 44;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(132, 255);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 44);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(1013, 252);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(76, 39);
            this.btnreload.TabIndex = 42;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(1095, 252);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(76, 39);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnlnv
            // 
            this.pnlnv.Controls.Add(this.label4);
            this.pnlnv.Controls.Add(this.numLuong);
            this.pnlnv.Controls.Add(this.label3);
            this.pnlnv.Controls.Add(this.txtchucvu);
            this.pnlnv.Controls.Add(this.label1);
            this.pnlnv.Controls.Add(this.cbnam);
            this.pnlnv.Controls.Add(this.lblngaysinh);
            this.pnlnv.Controls.Add(this.dtpngaysinh);
            this.pnlnv.Controls.Add(this.txtcccd);
            this.pnlnv.Controls.Add(this.lblcccd);
            this.pnlnv.Controls.Add(this.label2);
            this.pnlnv.Controls.Add(this.txtDiaChi);
            this.pnlnv.Controls.Add(this.txtSDT);
            this.pnlnv.Controls.Add(this.btnhuy);
            this.pnlnv.Controls.Add(this.btnluu);
            this.pnlnv.Controls.Add(this.lbsdt);
            this.pnlnv.Controls.Add(this.txtHoTen);
            this.pnlnv.Controls.Add(this.lbTen);
            this.pnlnv.Controls.Add(this.txtID);
            this.pnlnv.Controls.Add(this.lbid);
            this.pnlnv.Location = new System.Drawing.Point(41, 315);
            this.pnlnv.Name = "pnlnv";
            this.pnlnv.Size = new System.Drawing.Size(1130, 180);
            this.pnlnv.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(934, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Lương:";
            // 
            // numLuong
            // 
            this.numLuong.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLuong.Location = new System.Drawing.Point(999, 12);
            this.numLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numLuong.Name = "numLuong";
            this.numLuong.Size = new System.Drawing.Size(100, 22);
            this.numLuong.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Chức vụ:";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(841, 66);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(258, 22);
            this.txtchucvu.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Giới tính:";
            // 
            // cbnam
            // 
            this.cbnam.AutoSize = true;
            this.cbnam.Location = new System.Drawing.Point(841, 17);
            this.cbnam.Name = "cbnam";
            this.cbnam.Size = new System.Drawing.Size(61, 20);
            this.cbnam.TabIndex = 40;
            this.cbnam.Text = "Nam:";
            this.cbnam.UseVisualStyleBackColor = true;
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(24, 123);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(70, 16);
            this.lblngaysinh.TabIndex = 39;
            this.lblngaysinh.Text = "Ngày sinh:";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(111, 117);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(224, 22);
            this.dtpngaysinh.TabIndex = 38;
            // 
            // txtcccd
            // 
            this.txtcccd.Location = new System.Drawing.Point(478, 18);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(258, 22);
            this.txtcccd.TabIndex = 37;
            // 
            // lblcccd
            // 
            this.lblcccd.AutoSize = true;
            this.lblcccd.Location = new System.Drawing.Point(398, 18);
            this.lblcccd.Name = "lblcccd";
            this.lblcccd.Size = new System.Drawing.Size(47, 16);
            this.lblcccd.TabIndex = 36;
            this.lblcccd.Text = "CCCD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dia Chi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(478, 117);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(478, 69);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(258, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(1023, 108);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(76, 42);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(920, 108);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(76, 42);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(398, 72);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(35, 16);
            this.lbsdt.TabIndex = 7;
            this.lbsdt.Text = "SDT";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(111, 66);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(224, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(24, 66);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(55, 16);
            this.lbTen.TabIndex = 4;
            this.lbTen.Text = "Ho Ten:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 22);
            this.txtID.TabIndex = 2;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(24, 21);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "ID:";
            // 
            // btnTinhSL
            // 
            this.btnTinhSL.Location = new System.Drawing.Point(497, 255);
            this.btnTinhSL.Name = "btnTinhSL";
            this.btnTinhSL.Size = new System.Drawing.Size(191, 44);
            this.btnTinhSL.TabIndex = 50;
            this.btnTinhSL.Text = "Tính số Lượng Nhân viên";
            this.btnTinhSL.UseVisualStyleBackColor = true;
            this.btnTinhSL.Click += new System.EventHandler(this.btnTinhSL_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(694, 255);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(202, 44);
            this.btnTong.TabIndex = 49;
            this.btnTong.Text = "Tính Tổng Lương Nhân Viên";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 530);
            this.Controls.Add(this.btnTinhSL);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.pnlnv);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.pnlnv.ResumeLayout(false);
            this.pnlnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnlnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbnam;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.Label lblcccd;
        private System.Windows.Forms.Button btnTinhSL;
        private System.Windows.Forms.Button btnTong;
    }
}