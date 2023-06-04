namespace ADO_NET
{
    partial class FormReportKhachHang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyInternet = new ADO_NET.QuanLyInternet();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new ADO_NET.QuanLyInternetTableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.khachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ADO_NET.Report_KhachHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(774, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyInternet
            // 
            this.quanLyInternet.DataSetName = "QuanLyInternet";
            this.quanLyInternet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.quanLyInternet;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportKhachHang";
            this.Text = "FormReportKhachHang";
            this.Load += new System.EventHandler(this.FormReportKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyInternet quanLyInternet;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QuanLyInternetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
    }
}