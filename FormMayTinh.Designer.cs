namespace ADO_NET.BS_layer
{
    partial class FormMayTinh
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
            this.dgvMT = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.pnlnv = new System.Windows.Forms.Panel();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOcung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanhinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.btnSL = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).BeginInit();
            this.pnlnv.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(189, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 44);
            this.btnTimKiem.TabIndex = 58;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvMT
            // 
            this.dgvMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMT.Location = new System.Drawing.Point(48, 88);
            this.dgvMT.Name = "dgvMT";
            this.dgvMT.RowHeadersWidth = 51;
            this.dgvMT.RowTemplate.Height = 24;
            this.dgvMT.Size = new System.Drawing.Size(855, 217);
            this.dgvMT.TabIndex = 57;
            this.dgvMT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMT_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(291, 13);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(76, 44);
            this.btnxoa.TabIndex = 56;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(14, 13);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 44);
            this.btnthem.TabIndex = 55;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(105, 13);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(78, 44);
            this.btnsua.TabIndex = 54;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(14, 58);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(76, 39);
            this.btnreload.TabIndex = 53;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(14, 13);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(76, 39);
            this.btnthoat.TabIndex = 52;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // pnlnv
            // 
            this.pnlnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnv.Controls.Add(this.txttinhtrang);
            this.pnlnv.Controls.Add(this.label5);
            this.pnlnv.Controls.Add(this.txtRam);
            this.pnlnv.Controls.Add(this.label4);
            this.pnlnv.Controls.Add(this.txtOcung);
            this.pnlnv.Controls.Add(this.label3);
            this.pnlnv.Controls.Add(this.txtCPU);
            this.pnlnv.Controls.Add(this.label2);
            this.pnlnv.Controls.Add(this.txtmanhinh);
            this.pnlnv.Controls.Add(this.label1);
            this.pnlnv.Controls.Add(this.btnhuy);
            this.pnlnv.Controls.Add(this.btnluu);
            this.pnlnv.Controls.Add(this.txtID);
            this.pnlnv.Controls.Add(this.lbid);
            this.pnlnv.Location = new System.Drawing.Point(48, 423);
            this.pnlnv.Name = "pnlnv";
            this.pnlnv.Size = new System.Drawing.Size(855, 152);
            this.pnlnv.TabIndex = 51;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(492, 92);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(224, 22);
            this.txttinhtrang.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tình Trạng:";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(492, 53);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(224, 22);
            this.txtRam.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ram:";
            // 
            // txtOcung
            // 
            this.txtOcung.Location = new System.Drawing.Point(492, 15);
            this.txtOcung.Name = "txtOcung";
            this.txtOcung.Size = new System.Drawing.Size(224, 22);
            this.txtOcung.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ổ cứng:";
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(111, 92);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(224, 22);
            this.txtCPU.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "CPU:";
            // 
            // txtmanhinh
            // 
            this.txtmanhinh.Location = new System.Drawing.Point(111, 53);
            this.txtmanhinh.Name = "txtmanhinh";
            this.txtmanhinh.Size = new System.Drawing.Size(224, 22);
            this.txtmanhinh.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Màn hình:";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(763, 72);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(76, 42);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(763, 15);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(76, 42);
            this.btnluu.TabIndex = 35;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
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
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(111, 14);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(144, 43);
            this.btnSL.TabIndex = 59;
            this.btnSL.Text = "Tính Số Lượng Máy";
            this.btnSL.UseVisualStyleBackColor = true;
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(366, 27);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(310, 39);
            this.lbltitle.TabIndex = 68;
            this.lbltitle.Text = "Quản Lý Máy Tính";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnreload);
            this.panel1.Location = new System.Drawing.Point(909, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 217);
            this.panel1.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Location = new System.Drawing.Point(48, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 70);
            this.panel2.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSL);
            this.panel3.Location = new System.Drawing.Point(541, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 70);
            this.panel3.TabIndex = 71;
            // 
            // FormMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.dgvMT);
            this.Controls.Add(this.pnlnv);
            this.Name = "FormMayTinh";
            this.Text = "FormMayTinh";
            this.Load += new System.EventHandler(this.FormMayTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).EndInit();
            this.pnlnv.ResumeLayout(false);
            this.pnlnv.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvMT;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel pnlnv;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOcung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmanhinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btnSL;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}