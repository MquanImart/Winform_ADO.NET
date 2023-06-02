namespace ADO_NET
{
    partial class FormTaiKhoan
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
            this.btnshowpass = new System.Windows.Forms.Button();
            this.lbmoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbusername = new System.Windows.Forms.Label();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.btnshowpassw = new System.Windows.Forms.Button();
            this.txtshowpass = new System.Windows.Forms.TextBox();
            this.btnNaptien = new System.Windows.Forms.Button();
            this.btnTruTien = new System.Windows.Forms.Button();
            this.pnlMoney = new System.Windows.Forms.Panel();
            this.numTru = new System.Windows.Forms.NumericUpDown();
            this.numNap = new System.Windows.Forms.NumericUpDown();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.pnlMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(324, 110);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(76, 44);
            this.btnluu.TabIndex = 45;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(405, 110);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(80, 44);
            this.btnhuy.TabIndex = 44;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(381, 9);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 38);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(199, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 38);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(290, 9);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(85, 37);
            this.btnsua.TabIndex = 41;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(21, 56);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(94, 39);
            this.btnreload.TabIndex = 40;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(21, 11);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(94, 39);
            this.btnthoat.TabIndex = 39;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnlnv
            // 
            this.pnlnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnv.Controls.Add(this.btnhuy);
            this.pnlnv.Controls.Add(this.btnluu);
            this.pnlnv.Controls.Add(this.btnshowpass);
            this.pnlnv.Controls.Add(this.lbmoney);
            this.pnlnv.Controls.Add(this.txtMoney);
            this.pnlnv.Controls.Add(this.txtID);
            this.pnlnv.Controls.Add(this.lbID);
            this.pnlnv.Controls.Add(this.txtPass);
            this.pnlnv.Controls.Add(this.lbPass);
            this.pnlnv.Controls.Add(this.txtUser);
            this.pnlnv.Controls.Add(this.lbusername);
            this.pnlnv.Location = new System.Drawing.Point(46, 371);
            this.pnlnv.Name = "pnlnv";
            this.pnlnv.Size = new System.Drawing.Size(498, 170);
            this.pnlnv.TabIndex = 38;
            // 
            // btnshowpass
            // 
            this.btnshowpass.Location = new System.Drawing.Point(91, 91);
            this.btnshowpass.Name = "btnshowpass";
            this.btnshowpass.Size = new System.Drawing.Size(57, 30);
            this.btnshowpass.TabIndex = 47;
            this.btnshowpass.Text = "show";
            this.btnshowpass.UseVisualStyleBackColor = true;
            this.btnshowpass.Click += new System.EventHandler(this.btnshowpass_Click);
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.Location = new System.Drawing.Point(254, 66);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(51, 16);
            this.lbmoney.TabIndex = 11;
            this.lbmoney.Text = "Money:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(324, 66);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(161, 22);
            this.txtMoney.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(324, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(161, 22);
            this.txtID.TabIndex = 8;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(254, 18);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(64, 16);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID Owner:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(91, 63);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(133, 22);
            this.txtPass.TabIndex = 5;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(13, 66);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(70, 16);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(91, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(133, 22);
            this.txtUser.TabIndex = 2;
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(4, 18);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(79, 16);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "User Name:";
            // 
            // dgvTK
            // 
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(44, 73);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(500, 193);
            this.dgvTK.TabIndex = 46;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // btnshowpassw
            // 
            this.btnshowpassw.Location = new System.Drawing.Point(21, 101);
            this.btnshowpassw.Name = "btnshowpassw";
            this.btnshowpassw.Size = new System.Drawing.Size(94, 47);
            this.btnshowpassw.TabIndex = 47;
            this.btnshowpassw.Text = "Show Password";
            this.btnshowpassw.UseVisualStyleBackColor = true;
            this.btnshowpassw.Click += new System.EventHandler(this.btnshowpassw_Click);
            // 
            // txtshowpass
            // 
            this.txtshowpass.Location = new System.Drawing.Point(21, 154);
            this.txtshowpass.Name = "txtshowpass";
            this.txtshowpass.PasswordChar = '*';
            this.txtshowpass.Size = new System.Drawing.Size(94, 22);
            this.txtshowpass.TabIndex = 48;
            // 
            // btnNaptien
            // 
            this.btnNaptien.Location = new System.Drawing.Point(21, 9);
            this.btnNaptien.Name = "btnNaptien";
            this.btnNaptien.Size = new System.Drawing.Size(94, 35);
            this.btnNaptien.TabIndex = 49;
            this.btnNaptien.Text = "Nạp Tiền";
            this.btnNaptien.UseVisualStyleBackColor = true;
            this.btnNaptien.Click += new System.EventHandler(this.btnNaptien_Click);
            // 
            // btnTruTien
            // 
            this.btnTruTien.Location = new System.Drawing.Point(21, 91);
            this.btnTruTien.Name = "btnTruTien";
            this.btnTruTien.Size = new System.Drawing.Size(94, 35);
            this.btnTruTien.TabIndex = 51;
            this.btnTruTien.Text = "Trừ Tiền";
            this.btnTruTien.UseVisualStyleBackColor = true;
            this.btnTruTien.Click += new System.EventHandler(this.btnTruTien_Click);
            // 
            // pnlMoney
            // 
            this.pnlMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMoney.Controls.Add(this.numTru);
            this.pnlMoney.Controls.Add(this.btnNaptien);
            this.pnlMoney.Controls.Add(this.numNap);
            this.pnlMoney.Controls.Add(this.btnTruTien);
            this.pnlMoney.Location = new System.Drawing.Point(550, 371);
            this.pnlMoney.Name = "pnlMoney";
            this.pnlMoney.Size = new System.Drawing.Size(139, 170);
            this.pnlMoney.TabIndex = 53;
            // 
            // numTru
            // 
            this.numTru.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTru.Location = new System.Drawing.Point(21, 136);
            this.numTru.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTru.Name = "numTru";
            this.numTru.Size = new System.Drawing.Size(94, 22);
            this.numTru.TabIndex = 55;
            // 
            // numNap
            // 
            this.numNap.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNap.Location = new System.Drawing.Point(21, 50);
            this.numNap.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numNap.Name = "numNap";
            this.numNap.Size = new System.Drawing.Size(94, 22);
            this.numNap.TabIndex = 54;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(175, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(327, 39);
            this.lbltitle.TabIndex = 69;
            this.lbltitle.Text = "Quản Lý Tài Khoản";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Location = new System.Drawing.Point(44, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 62);
            this.panel2.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnthoat);
            this.panel3.Controls.Add(this.btnreload);
            this.panel3.Controls.Add(this.btnshowpassw);
            this.panel3.Controls.Add(this.txtshowpass);
            this.panel3.Location = new System.Drawing.Point(550, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 193);
            this.panel3.TabIndex = 72;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 585);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pnlMoney);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.pnlnv);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.pnlnv.ResumeLayout(false);
            this.pnlnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.pnlMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnshowpass;
        private System.Windows.Forms.Label lbmoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Button btnshowpassw;
        private System.Windows.Forms.TextBox txtshowpass;
        private System.Windows.Forms.Button btnNaptien;
        private System.Windows.Forms.Button btnTruTien;
        private System.Windows.Forms.Panel pnlMoney;
        private System.Windows.Forms.NumericUpDown numTru;
        private System.Windows.Forms.NumericUpDown numNap;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}