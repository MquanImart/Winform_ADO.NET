namespace ADO_NET
{
    partial class FormGiuXe
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
            this.dgvGX = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnlgx = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbbienso = new System.Windows.Forms.Label();
            this.numPhutRa = new System.Windows.Forms.NumericUpDown();
            this.numGioRa = new System.Windows.Forms.NumericUpDown();
            this.numPhutVao = new System.Windows.Forms.NumericUpDown();
            this.numGioVao = new System.Windows.Forms.NumericUpDown();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.lbgiora = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.lbgiovao = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lbidcard = new System.Windows.Forms.Label();
            this.lbngay = new System.Windows.Forms.Label();
            this.cbngay = new System.Windows.Forms.CheckBox();
            this.btnXeRa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGX)).BeginInit();
            this.pnlgx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutVao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioVao)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(11, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 43);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvGX
            // 
            this.dgvGX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGX.Location = new System.Drawing.Point(41, 80);
            this.dgvGX.Name = "dgvGX";
            this.dgvGX.RowHeadersWidth = 51;
            this.dgvGX.RowTemplate.Height = 24;
            this.dgvGX.Size = new System.Drawing.Size(750, 254);
            this.dgvGX.TabIndex = 46;
            this.dgvGX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(314, 340);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(85, 48);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(41, 340);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 48);
            this.btnthem.TabIndex = 44;
            this.btnthem.Text = "Xe Vào";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(223, 340);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(85, 48);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sửa đổi";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(11, 12);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(104, 47);
            this.btnreload.TabIndex = 42;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(11, 65);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 47);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnlgx
            // 
            this.pnlgx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlgx.Controls.Add(this.label2);
            this.pnlgx.Controls.Add(this.label1);
            this.pnlgx.Controls.Add(this.lbbienso);
            this.pnlgx.Controls.Add(this.numPhutRa);
            this.pnlgx.Controls.Add(this.numGioRa);
            this.pnlgx.Controls.Add(this.numPhutVao);
            this.pnlgx.Controls.Add(this.numGioVao);
            this.pnlgx.Controls.Add(this.Calendar);
            this.pnlgx.Controls.Add(this.btnhuy);
            this.pnlgx.Controls.Add(this.btnluu);
            this.pnlgx.Controls.Add(this.lbgiora);
            this.pnlgx.Controls.Add(this.txtIDCard);
            this.pnlgx.Controls.Add(this.lbgiovao);
            this.pnlgx.Controls.Add(this.txtBienSo);
            this.pnlgx.Controls.Add(this.lbidcard);
            this.pnlgx.Controls.Add(this.lbngay);
            this.pnlgx.Location = new System.Drawing.Point(41, 394);
            this.pnlgx.Name = "pnlgx";
            this.pnlgx.Size = new System.Drawing.Size(911, 233);
            this.pnlgx.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "h";
            // 
            // lbbienso
            // 
            this.lbbienso.AutoSize = true;
            this.lbbienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbienso.Location = new System.Drawing.Point(426, 130);
            this.lbbienso.Name = "lbbienso";
            this.lbbienso.Size = new System.Drawing.Size(71, 20);
            this.lbbienso.TabIndex = 55;
            this.lbbienso.Text = "Biển số:";
            // 
            // numPhutRa
            // 
            this.numPhutRa.Location = new System.Drawing.Point(603, 80);
            this.numPhutRa.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numPhutRa.Name = "numPhutRa";
            this.numPhutRa.Size = new System.Drawing.Size(49, 22);
            this.numPhutRa.TabIndex = 54;
            // 
            // numGioRa
            // 
            this.numGioRa.Location = new System.Drawing.Point(524, 80);
            this.numGioRa.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numGioRa.Name = "numGioRa";
            this.numGioRa.Size = new System.Drawing.Size(49, 22);
            this.numGioRa.TabIndex = 53;
            // 
            // numPhutVao
            // 
            this.numPhutVao.Location = new System.Drawing.Point(603, 27);
            this.numPhutVao.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numPhutVao.Name = "numPhutVao";
            this.numPhutVao.Size = new System.Drawing.Size(49, 22);
            this.numPhutVao.TabIndex = 52;
            // 
            // numGioVao
            // 
            this.numGioVao.Location = new System.Drawing.Point(524, 27);
            this.numGioVao.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numGioVao.Name = "numGioVao";
            this.numGioVao.Size = new System.Drawing.Size(49, 22);
            this.numGioVao.TabIndex = 51;
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
            this.btnhuy.Location = new System.Drawing.Point(792, 72);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(104, 45);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(792, 10);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(104, 49);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lbgiora
            // 
            this.lbgiora.AutoSize = true;
            this.lbgiora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiora.Location = new System.Drawing.Point(425, 79);
            this.lbgiora.Name = "lbgiora";
            this.lbgiora.Size = new System.Drawing.Size(60, 20);
            this.lbgiora.TabIndex = 11;
            this.lbgiora.Text = "Giờ ra:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(506, 174);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(158, 22);
            this.txtIDCard.TabIndex = 10;
            // 
            // lbgiovao
            // 
            this.lbgiovao.AutoSize = true;
            this.lbgiovao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiovao.Location = new System.Drawing.Point(425, 26);
            this.lbgiovao.Name = "lbgiovao";
            this.lbgiovao.Size = new System.Drawing.Size(74, 20);
            this.lbgiovao.TabIndex = 7;
            this.lbgiovao.Text = "Giờ Vào:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(506, 130);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(158, 22);
            this.txtBienSo.TabIndex = 5;
            // 
            // lbidcard
            // 
            this.lbidcard.AutoSize = true;
            this.lbidcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidcard.Location = new System.Drawing.Point(425, 174);
            this.lbidcard.Name = "lbidcard";
            this.lbidcard.Size = new System.Drawing.Size(72, 20);
            this.lbidcard.TabIndex = 4;
            this.lbidcard.Text = "ID Card:";
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
            // cbngay
            // 
            this.cbngay.AutoSize = true;
            this.cbngay.Enabled = false;
            this.cbngay.Location = new System.Drawing.Point(19, 69);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(93, 20);
            this.cbngay.TabIndex = 58;
            this.cbngay.Text = "Chọn ngày";
            this.cbngay.UseVisualStyleBackColor = true;
            // 
            // btnXeRa
            // 
            this.btnXeRa.Location = new System.Drawing.Point(132, 340);
            this.btnXeRa.Name = "btnXeRa";
            this.btnXeRa.Size = new System.Drawing.Size(85, 48);
            this.btnXeRa.TabIndex = 59;
            this.btnXeRa.Text = "Xe Ra";
            this.btnXeRa.UseVisualStyleBackColor = true;
            this.btnXeRa.Click += new System.EventHandler(this.btnXeRa_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cbngay);
            this.panel1.Location = new System.Drawing.Point(823, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 106);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Controls.Add(this.btnreload);
            this.panel2.Location = new System.Drawing.Point(823, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 130);
            this.panel2.TabIndex = 61;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(646, 340);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(145, 48);
            this.btnTinhTong.TabIndex = 62;
            this.btnTinhTong.Text = "Tính số lượng xe";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(368, 22);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(272, 39);
            this.lbltitle.TabIndex = 63;
            this.lbltitle.Text = "Quản Lý Giữ Xe";
            // 
            // FormGiuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 660);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXeRa);
            this.Controls.Add(this.dgvGX);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.pnlgx);
            this.Name = "FormGiuXe";
            this.Text = "FormGiuXe";
            this.Load += new System.EventHandler(this.FormGiuXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGX)).EndInit();
            this.pnlgx.ResumeLayout(false);
            this.pnlgx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutRa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioRa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutVao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioVao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvGX;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnlgx;
        private System.Windows.Forms.Label lbbienso;
        private System.Windows.Forms.NumericUpDown numPhutRa;
        private System.Windows.Forms.NumericUpDown numGioRa;
        private System.Windows.Forms.NumericUpDown numPhutVao;
        private System.Windows.Forms.NumericUpDown numGioVao;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label lbgiora;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lbgiovao;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lbidcard;
        private System.Windows.Forms.Label lbngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbngay;
        private System.Windows.Forms.Button btnXeRa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label lbltitle;
    }
}