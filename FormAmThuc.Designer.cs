﻿namespace ADO_NET
{
    partial class FormAmThuc
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnTongSL = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbSl = new System.Windows.Forms.Label();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlAmThuc = new System.Windows.Forms.Panel();
            this.dgvAmThuc = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAmThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(915, 141);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(113, 46);
            this.btnReload.TabIndex = 50;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTongSL
            // 
            this.btnTongSL.Location = new System.Drawing.Point(915, 191);
            this.btnTongSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongSL.Name = "btnTongSL";
            this.btnTongSL.Size = new System.Drawing.Size(113, 46);
            this.btnTongSL.TabIndex = 48;
            this.btnTongSL.Text = "Tổng số lượng";
            this.btnTongSL.UseVisualStyleBackColor = true;
            this.btnTongSL.Click += new System.EventHandler(this.btnTongSL_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(847, 55);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 36);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(847, 9);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 36);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(570, 55);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(173, 22);
            this.txtSL.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(570, 14);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 22);
            this.txtTen.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(92, 60);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(173, 22);
            this.txtGia.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 14);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 22);
            this.txtID.TabIndex = 5;
            // 
            // lbSl
            // 
            this.lbSl.AutoSize = true;
            this.lbSl.Location = new System.Drawing.Point(488, 64);
            this.lbSl.Name = "lbSl";
            this.lbSl.Size = new System.Drawing.Size(67, 16);
            this.lbSl.TabIndex = 4;
            this.lbSl.Text = "Số Lượng:";
            // 
            // btnTongTien
            // 
            this.btnTongTien.Location = new System.Drawing.Point(915, 241);
            this.btnTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(113, 46);
            this.btnTongTien.TabIndex = 47;
            this.btnTongTien.Text = "Tổng giá tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(68, 241);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 46);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(68, 191);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 46);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(68, 141);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 46);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(524, 22);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(34, 16);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên:";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(58, 64);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(31, 16);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(58, 22);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "ID:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(915, 91);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 46);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 91);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 46);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlAmThuc
            // 
            this.pnlAmThuc.Controls.Add(this.btnHuy);
            this.pnlAmThuc.Controls.Add(this.btnLuu);
            this.pnlAmThuc.Controls.Add(this.txtSL);
            this.pnlAmThuc.Controls.Add(this.txtTen);
            this.pnlAmThuc.Controls.Add(this.txtGia);
            this.pnlAmThuc.Controls.Add(this.txtID);
            this.pnlAmThuc.Controls.Add(this.lbSl);
            this.pnlAmThuc.Controls.Add(this.lbTen);
            this.pnlAmThuc.Controls.Add(this.lbGia);
            this.pnlAmThuc.Controls.Add(this.lbid);
            this.pnlAmThuc.Location = new System.Drawing.Point(68, 323);
            this.pnlAmThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAmThuc.Name = "pnlAmThuc";
            this.pnlAmThuc.Size = new System.Drawing.Size(960, 102);
            this.pnlAmThuc.TabIndex = 42;
            // 
            // dgvAmThuc
            // 
            this.dgvAmThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmThuc.Location = new System.Drawing.Point(160, 68);
            this.dgvAmThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAmThuc.Name = "dgvAmThuc";
            this.dgvAmThuc.RowHeadersWidth = 51;
            this.dgvAmThuc.Size = new System.Drawing.Size(748, 247);
            this.dgvAmThuc.TabIndex = 41;
            this.dgvAmThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAmThuc_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(391, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(334, 39);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Quản lý Thực Phẩm";
            // 
            // FormAmThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 459);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTongSL);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlAmThuc);
            this.Controls.Add(this.dgvAmThuc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAmThuc";
            this.Text = "FormAmThuc";
            this.Load += new System.EventHandler(this.FormAmThuc_Load);
            this.pnlAmThuc.ResumeLayout(false);
            this.pnlAmThuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnTongSL;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbSl;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlAmThuc;
        private System.Windows.Forms.DataGridView dgvAmThuc;
        private System.Windows.Forms.Label lblTitle;
    }
}