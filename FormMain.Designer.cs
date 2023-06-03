namespace ADO_NET
{
    partial class FormMain
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.pnllogin = new System.Windows.Forms.Panel();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlchucnang = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnMaytinh = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnGiuxe = new System.Windows.Forms.Button();
            this.btnLichsu = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnHanghoa = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnAmthuc = new System.Windows.Forms.Button();
            this.pnllogin.SuspendLayout();
            this.pnlchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(194, 34);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(396, 38);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Quản lý Dịch Vụ Internet";
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.AutoSize = true;
            this.lbldangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.Location = new System.Drawing.Point(173, 10);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(78, 29);
            this.lbldangnhap.TabIndex = 1;
            this.lbldangnhap.Text = "Login";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(146, 55);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(155, 22);
            this.txtuser.TabIndex = 2;
            // 
            // pnllogin
            // 
            this.pnllogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnllogin.Controls.Add(this.btndangnhap);
            this.pnllogin.Controls.Add(this.txtpass);
            this.pnllogin.Controls.Add(this.label2);
            this.pnllogin.Controls.Add(this.label1);
            this.pnllogin.Controls.Add(this.lbldangnhap);
            this.pnllogin.Controls.Add(this.txtuser);
            this.pnllogin.Location = new System.Drawing.Point(201, 90);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(404, 140);
            this.pnllogin.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(325, 93);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(47, 37);
            this.btndangnhap.TabIndex = 9;
            this.btndangnhap.Text = "Ok";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(146, 100);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(155, 22);
            this.txtpass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // pnlchucnang
            // 
            this.pnlchucnang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlchucnang.Controls.Add(this.btnthoat);
            this.pnlchucnang.Controls.Add(this.btnMaytinh);
            this.pnlchucnang.Controls.Add(this.btnNhanvien);
            this.pnlchucnang.Controls.Add(this.btnGiuxe);
            this.pnlchucnang.Controls.Add(this.btnLichsu);
            this.pnlchucnang.Controls.Add(this.btnKhachhang);
            this.pnlchucnang.Controls.Add(this.btnHanghoa);
            this.pnlchucnang.Controls.Add(this.btnHoadon);
            this.pnlchucnang.Controls.Add(this.btnAmthuc);
            this.pnlchucnang.Location = new System.Drawing.Point(93, 249);
            this.pnlchucnang.Name = "pnlchucnang";
            this.pnlchucnang.Size = new System.Drawing.Size(623, 189);
            this.pnlchucnang.TabIndex = 4;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(450, 122);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(145, 37);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Đăng xuất";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnMaytinh
            // 
            this.btnMaytinh.Location = new System.Drawing.Point(234, 68);
            this.btnMaytinh.Name = "btnMaytinh";
            this.btnMaytinh.Size = new System.Drawing.Size(145, 37);
            this.btnMaytinh.TabIndex = 7;
            this.btnMaytinh.Text = "Máy tính";
            this.btnMaytinh.UseVisualStyleBackColor = true;
            this.btnMaytinh.Click += new System.EventHandler(this.btnMaytinh_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(450, 9);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(145, 37);
            this.btnNhanvien.TabIndex = 6;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnGiuxe
            // 
            this.btnGiuxe.Location = new System.Drawing.Point(234, 13);
            this.btnGiuxe.Name = "btnGiuxe";
            this.btnGiuxe.Size = new System.Drawing.Size(145, 37);
            this.btnGiuxe.TabIndex = 5;
            this.btnGiuxe.Text = "Giữ Xe";
            this.btnGiuxe.UseVisualStyleBackColor = true;
            this.btnGiuxe.Click += new System.EventHandler(this.btnGiuxe_Click);
            // 
            // btnLichsu
            // 
            this.btnLichsu.Location = new System.Drawing.Point(234, 122);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(145, 37);
            this.btnLichsu.TabIndex = 4;
            this.btnLichsu.Text = "Lịch Sử Hoạt Động";
            this.btnLichsu.UseVisualStyleBackColor = true;
            this.btnLichsu.Click += new System.EventHandler(this.btnLichsu_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Location = new System.Drawing.Point(450, 68);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(145, 37);
            this.btnKhachhang.TabIndex = 3;
            this.btnKhachhang.Text = "Khách Hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnHanghoa
            // 
            this.btnHanghoa.Location = new System.Drawing.Point(19, 68);
            this.btnHanghoa.Name = "btnHanghoa";
            this.btnHanghoa.Size = new System.Drawing.Size(145, 37);
            this.btnHanghoa.TabIndex = 2;
            this.btnHanghoa.Text = "Hàng Hóa";
            this.btnHanghoa.UseVisualStyleBackColor = true;
            this.btnHanghoa.Click += new System.EventHandler(this.btnHanghoa_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.Location = new System.Drawing.Point(19, 122);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(145, 37);
            this.btnHoadon.TabIndex = 1;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnAmthuc
            // 
            this.btnAmthuc.Location = new System.Drawing.Point(19, 13);
            this.btnAmthuc.Name = "btnAmthuc";
            this.btnAmthuc.Size = new System.Drawing.Size(145, 37);
            this.btnAmthuc.TabIndex = 0;
            this.btnAmthuc.Text = "Ẩm thực";
            this.btnAmthuc.UseVisualStyleBackColor = true;
            this.btnAmthuc.Click += new System.EventHandler(this.btnAmthuc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlchucnang);
            this.Controls.Add(this.pnllogin);
            this.Controls.Add(this.lbltitle);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.pnlchucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlchucnang;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnMaytinh;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnGiuxe;
        private System.Windows.Forms.Button btnLichsu;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnHanghoa;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnAmthuc;
        private System.Windows.Forms.Button btndangnhap;
    }
}