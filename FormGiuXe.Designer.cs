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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGX)).BeginInit();
            this.pnlgx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioRa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhutVao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGioVao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(798, 443);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 36);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tim Kiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvGX
            // 
            this.dgvGX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGX.Location = new System.Drawing.Point(14, 12);
            this.dgvGX.Name = "dgvGX";
            this.dgvGX.RowHeadersWidth = 51;
            this.dgvGX.RowTemplate.Height = 24;
            this.dgvGX.Size = new System.Drawing.Size(750, 254);
            this.dgvGX.TabIndex = 46;
            this.dgvGX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(798, 286);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(85, 36);
            this.btnxoa.TabIndex = 45;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(798, 328);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 36);
            this.btnthem.TabIndex = 44;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(798, 370);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(85, 36);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(798, 54);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(85, 36);
            this.btnreload.TabIndex = 42;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(798, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 36);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoat";
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
            this.pnlgx.Location = new System.Drawing.Point(14, 272);
            this.pnlgx.Name = "pnlgx";
            this.pnlgx.Size = new System.Drawing.Size(750, 233);
            this.pnlgx.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "h";
            // 
            // lbbienso
            // 
            this.lbbienso.AutoSize = true;
            this.lbbienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbienso.Location = new System.Drawing.Point(376, 132);
            this.lbbienso.Name = "lbbienso";
            this.lbbienso.Size = new System.Drawing.Size(71, 20);
            this.lbbienso.TabIndex = 55;
            this.lbbienso.Text = "Biển số:";
            // 
            // numPhutRa
            // 
            this.numPhutRa.Location = new System.Drawing.Point(553, 82);
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
            this.numGioRa.Location = new System.Drawing.Point(474, 82);
            this.numGioRa.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numGioRa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numGioRa.Name = "numGioRa";
            this.numGioRa.Size = new System.Drawing.Size(49, 22);
            this.numGioRa.TabIndex = 53;
            // 
            // numPhutVao
            // 
            this.numPhutVao.Location = new System.Drawing.Point(553, 30);
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
            this.numGioVao.Location = new System.Drawing.Point(474, 30);
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
            this.btnhuy.Location = new System.Drawing.Point(645, 74);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(85, 36);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Huy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(645, 22);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(85, 36);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lbgiora
            // 
            this.lbgiora.AutoSize = true;
            this.lbgiora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiora.Location = new System.Drawing.Point(375, 81);
            this.lbgiora.Name = "lbgiora";
            this.lbgiora.Size = new System.Drawing.Size(60, 20);
            this.lbgiora.TabIndex = 11;
            this.lbgiora.Text = "Giờ ra:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(456, 176);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(158, 22);
            this.txtIDCard.TabIndex = 10;
            // 
            // lbgiovao
            // 
            this.lbgiovao.AutoSize = true;
            this.lbgiovao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgiovao.Location = new System.Drawing.Point(375, 29);
            this.lbgiovao.Name = "lbgiovao";
            this.lbgiovao.Size = new System.Drawing.Size(74, 20);
            this.lbgiovao.TabIndex = 7;
            this.lbgiovao.Text = "Giờ Vào:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(456, 132);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(158, 22);
            this.txtBienSo.TabIndex = 5;
            // 
            // lbidcard
            // 
            this.lbidcard.AutoSize = true;
            this.lbidcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidcard.Location = new System.Drawing.Point(375, 176);
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
            this.cbngay.Location = new System.Drawing.Point(798, 485);
            this.cbngay.Name = "cbngay";
            this.cbngay.Size = new System.Drawing.Size(93, 20);
            this.cbngay.TabIndex = 58;
            this.cbngay.Text = "Chọn ngày";
            this.cbngay.UseVisualStyleBackColor = true;
            // 
            // FormGiuXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 519);
            this.Controls.Add(this.cbngay);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvGX);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnthoat);
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
    }
}