namespace ADO_NET
{
    partial class FormKhachHang
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
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnlnv = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.pnlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(767, 12);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(76, 28);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(767, 60);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(76, 28);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(289, 235);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 36);
            this.btnxoa.TabIndex = 33;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 235);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 36);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(103, 235);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 36);
            this.btnsua.TabIndex = 31;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(798, 48);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(67, 30);
            this.btnreload.TabIndex = 29;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(798, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(67, 30);
            this.btnthoat.TabIndex = 28;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnlnv
            // 
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
            this.pnlnv.Location = new System.Drawing.Point(12, 293);
            this.pnlnv.Name = "pnlnv";
            this.pnlnv.Size = new System.Drawing.Size(853, 105);
            this.pnlnv.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dia Chi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(479, 63);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(479, 15);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(258, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(399, 18);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(35, 16);
            this.lbsdt.TabIndex = 7;
            this.lbsdt.Text = "SDT";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(93, 66);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(235, 22);
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
            this.txtID.Location = new System.Drawing.Point(93, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(235, 22);
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
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(12, 12);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(780, 217);
            this.dgvKH.TabIndex = 36;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Location = new System.Drawing.Point(798, 84);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(67, 145);
            this.btnTaiKhoan.TabIndex = 37;
            this.btnTaiKhoan.Text = "Quan Li Tai Khoan";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(187, 235);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 36);
            this.btnTimKiem.TabIndex = 38;
            this.btnTimKiem.Text = "Tim Kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(371, 235);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(158, 35);
            this.btnTinhTong.TabIndex = 39;
            this.btnTinhTong.Text = "TInh Tong Khach Hang";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 410);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTaiKhoan);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.pnlnv);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.pnlnv.ResumeLayout(false);
            this.pnlnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnlnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTinhTong;
    }
}

