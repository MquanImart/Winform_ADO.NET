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
            this.txtNapTien = new System.Windows.Forms.TextBox();
            this.txtTruTien = new System.Windows.Forms.TextBox();
            this.btnTruTien = new System.Windows.Forms.Button();
            this.pnlMoney = new System.Windows.Forms.Panel();
            this.pnlnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.pnlMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(346, 211);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(76, 28);
            this.btnluu.TabIndex = 45;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(430, 211);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(80, 28);
            this.btnhuy.TabIndex = 44;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(187, 211);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 28);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 211);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 28);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(103, 211);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 28);
            this.btnsua.TabIndex = 41;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(539, 45);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(94, 25);
            this.btnreload.TabIndex = 40;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(539, 14);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(94, 25);
            this.btnthoat.TabIndex = 39;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnlnv
            // 
            this.pnlnv.Controls.Add(this.btnshowpass);
            this.pnlnv.Controls.Add(this.lbmoney);
            this.pnlnv.Controls.Add(this.txtMoney);
            this.pnlnv.Controls.Add(this.txtID);
            this.pnlnv.Controls.Add(this.lbID);
            this.pnlnv.Controls.Add(this.txtPass);
            this.pnlnv.Controls.Add(this.lbPass);
            this.pnlnv.Controls.Add(this.txtUser);
            this.pnlnv.Controls.Add(this.lbusername);
            this.pnlnv.Location = new System.Drawing.Point(10, 256);
            this.pnlnv.Name = "pnlnv";
            this.pnlnv.Size = new System.Drawing.Size(498, 159);
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
            this.dgvTK.Location = new System.Drawing.Point(10, 12);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(500, 193);
            this.dgvTK.TabIndex = 46;
            this.dgvTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTK_CellClick);
            // 
            // btnshowpassw
            // 
            this.btnshowpassw.Location = new System.Drawing.Point(539, 76);
            this.btnshowpassw.Name = "btnshowpassw";
            this.btnshowpassw.Size = new System.Drawing.Size(94, 47);
            this.btnshowpassw.TabIndex = 47;
            this.btnshowpassw.Text = "Show Password";
            this.btnshowpassw.UseVisualStyleBackColor = true;
            this.btnshowpassw.Click += new System.EventHandler(this.btnshowpassw_Click);
            // 
            // txtshowpass
            // 
            this.txtshowpass.Location = new System.Drawing.Point(539, 129);
            this.txtshowpass.Name = "txtshowpass";
            this.txtshowpass.PasswordChar = '*';
            this.txtshowpass.Size = new System.Drawing.Size(94, 22);
            this.txtshowpass.TabIndex = 48;
            // 
            // btnNaptien
            // 
            this.btnNaptien.Location = new System.Drawing.Point(13, 12);
            this.btnNaptien.Name = "btnNaptien";
            this.btnNaptien.Size = new System.Drawing.Size(94, 35);
            this.btnNaptien.TabIndex = 49;
            this.btnNaptien.Text = "Nap Tien";
            this.btnNaptien.UseVisualStyleBackColor = true;
            this.btnNaptien.Click += new System.EventHandler(this.btnNaptien_Click);
            // 
            // txtNapTien
            // 
            this.txtNapTien.Location = new System.Drawing.Point(13, 53);
            this.txtNapTien.Name = "txtNapTien";
            this.txtNapTien.Size = new System.Drawing.Size(94, 22);
            this.txtNapTien.TabIndex = 50;
            // 
            // txtTruTien
            // 
            this.txtTruTien.Location = new System.Drawing.Point(13, 127);
            this.txtTruTien.Name = "txtTruTien";
            this.txtTruTien.Size = new System.Drawing.Size(94, 22);
            this.txtTruTien.TabIndex = 52;
            // 
            // btnTruTien
            // 
            this.btnTruTien.Location = new System.Drawing.Point(13, 86);
            this.btnTruTien.Name = "btnTruTien";
            this.btnTruTien.Size = new System.Drawing.Size(94, 35);
            this.btnTruTien.TabIndex = 51;
            this.btnTruTien.Text = "Tru Tien";
            this.btnTruTien.UseVisualStyleBackColor = true;
            this.btnTruTien.Click += new System.EventHandler(this.btnTruTien_Click);
            // 
            // pnlMoney
            // 
            this.pnlMoney.Controls.Add(this.btnNaptien);
            this.pnlMoney.Controls.Add(this.txtTruTien);
            this.pnlMoney.Controls.Add(this.txtNapTien);
            this.pnlMoney.Controls.Add(this.btnTruTien);
            this.pnlMoney.Location = new System.Drawing.Point(526, 256);
            this.pnlMoney.Name = "pnlMoney";
            this.pnlMoney.Size = new System.Drawing.Size(122, 159);
            this.pnlMoney.TabIndex = 53;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 423);
            this.Controls.Add(this.pnlMoney);
            this.Controls.Add(this.txtshowpass);
            this.Controls.Add(this.btnshowpassw);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.pnlnv);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.pnlnv.ResumeLayout(false);
            this.pnlnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.pnlMoney.ResumeLayout(false);
            this.pnlMoney.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNapTien;
        private System.Windows.Forms.TextBox txtTruTien;
        private System.Windows.Forms.Button btnTruTien;
        private System.Windows.Forms.Panel pnlMoney;
    }
}