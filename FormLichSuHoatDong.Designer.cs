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
            this.label1 = new System.Windows.Forms.Label();
            this.lbsomay = new System.Windows.Forms.Label();
            this.numthoigian = new System.Windows.Forms.NumericUpDown();
            this.numPhut = new System.Windows.Forms.NumericUpDown();
            this.numGio = new System.Windows.Forms.NumericUpDown();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lbgio = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbngay = new System.Windows.Forms.Label();
            this.numsomay = new System.Windows.Forms.NumericUpDown();
            this.btntatmay = new System.Windows.Forms.Button();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHD)).BeginInit();
            this.pnllshd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numthoigian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsomay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(187, 235);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 36);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tim Kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvLSHD
            // 
            this.dgvLSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSHD.Location = new System.Drawing.Point(12, 12);
            this.dgvLSHD.Name = "dgvLSHD";
            this.dgvLSHD.RowHeadersWidth = 51;
            this.dgvLSHD.RowTemplate.Height = 24;
            this.dgvLSHD.Size = new System.Drawing.Size(780, 217);
            this.dgvLSHD.TabIndex = 46;
            this.dgvLSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSHD_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(289, 235);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 36);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 235);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 36);
            this.btnthem.TabIndex = 44;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(103, 235);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 36);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(798, 48);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(67, 30);
            this.btnreload.TabIndex = 42;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(798, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(67, 30);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnllshd
            // 
            this.pnllshd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnllshd.Controls.Add(this.txttinhtrang);
            this.pnllshd.Controls.Add(this.label2);
            this.pnllshd.Controls.Add(this.numsomay);
            this.pnllshd.Controls.Add(this.label1);
            this.pnllshd.Controls.Add(this.lbsomay);
            this.pnllshd.Controls.Add(this.numthoigian);
            this.pnllshd.Controls.Add(this.numPhut);
            this.pnllshd.Controls.Add(this.numGio);
            this.pnllshd.Controls.Add(this.Calendar);
            this.pnllshd.Controls.Add(this.btnhuy);
            this.pnllshd.Controls.Add(this.btnluu);
            this.pnllshd.Controls.Add(this.lbthoigian);
            this.pnllshd.Controls.Add(this.txtusername);
            this.pnllshd.Controls.Add(this.lbgio);
            this.pnllshd.Controls.Add(this.lbuser);
            this.pnllshd.Controls.Add(this.lbngay);
            this.pnllshd.Location = new System.Drawing.Point(12, 277);
            this.pnllshd.Name = "pnllshd";
            this.pnllshd.Size = new System.Drawing.Size(853, 233);
            this.pnllshd.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "h";
            // 
            // lbsomay
            // 
            this.lbsomay.AutoSize = true;
            this.lbsomay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsomay.Location = new System.Drawing.Point(383, 164);
            this.lbsomay.Name = "lbsomay";
            this.lbsomay.Size = new System.Drawing.Size(70, 20);
            this.lbsomay.TabIndex = 55;
            this.lbsomay.Text = "Số máy:";
            // 
            // numthoigian
            // 
            this.numthoigian.Location = new System.Drawing.Point(553, 97);
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
            // numPhut
            // 
            this.numPhut.Location = new System.Drawing.Point(579, 30);
            this.numPhut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numPhut.Name = "numPhut";
            this.numPhut.Size = new System.Drawing.Size(49, 22);
            this.numPhut.TabIndex = 52;
            // 
            // numGio
            // 
            this.numGio.Location = new System.Drawing.Point(505, 30);
            this.numGio.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numGio.Name = "numGio";
            this.numGio.Size = new System.Drawing.Size(44, 22);
            this.numGio.TabIndex = 51;
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(62, 12);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 50;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(693, 71);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(85, 36);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(693, 13);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(85, 36);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lbthoigian
            // 
            this.lbthoigian.AutoSize = true;
            this.lbthoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoigian.Location = new System.Drawing.Point(375, 99);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(146, 20);
            this.lbthoigian.TabIndex = 11;
            this.lbthoigian.Text = "Thời gian sử dụng:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(724, 177);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(122, 22);
            this.txtusername.TabIndex = 10;
            // 
            // lbgio
            // 
            this.lbgio.AutoSize = true;
            this.lbgio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgio.Location = new System.Drawing.Point(375, 29);
            this.lbgio.Name = "lbgio";
            this.lbgio.Size = new System.Drawing.Size(106, 20);
            this.lbgio.TabIndex = 7;
            this.lbgio.Text = "Giờ Sử dụng:";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(619, 177);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(99, 20);
            this.lbuser.TabIndex = 4;
            this.lbuser.Text = "User Name:";
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
            // numsomay
            // 
            this.numsomay.Location = new System.Drawing.Point(463, 162);
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
            // btntatmay
            // 
            this.btntatmay.Location = new System.Drawing.Point(798, 84);
            this.btntatmay.Name = "btntatmay";
            this.btntatmay.Size = new System.Drawing.Size(67, 44);
            this.btntatmay.TabIndex = 51;
            this.btntatmay.Text = "Tắt máy";
            this.btntatmay.UseVisualStyleBackColor = true;
            this.btntatmay.Click += new System.EventHandler(this.btntatmay_Click);
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(724, 129);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(122, 22);
            this.txttinhtrang.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tình trạng:";
            // 
            // FormLichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 520);
            this.Controls.Add(this.btntatmay);
            this.Controls.Add(this.pnllshd);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvLSHD);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnthoat);
            this.Name = "FormLichSuHoatDong";
            this.Text = "FormLichSuHoatDong";
            this.Load += new System.EventHandler(this.FormLichSuHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHD)).EndInit();
            this.pnllshd.ResumeLayout(false);
            this.pnllshd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numthoigian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numsomay)).EndInit();
            this.ResumeLayout(false);

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
    }
}