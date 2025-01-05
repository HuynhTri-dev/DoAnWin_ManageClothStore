namespace DoAnCuoiKi.frm.frm_BaoCao
{
    partial class BaoCaoDoanhThu
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
            this.DoanhThuReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // DoanhThuReportViewer
            // 
            this.DoanhThuReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoanhThuReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DoanhThuReportViewer.Name = "DoanhThuReportViewer";
            this.DoanhThuReportViewer.ServerReport.BearerToken = null;
            this.DoanhThuReportViewer.Size = new System.Drawing.Size(1061, 605);
            this.DoanhThuReportViewer.TabIndex = 3;
            this.DoanhThuReportViewer.Load += new System.EventHandler(this.DoanhThuReportViewer_Load);
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 605);
            this.Controls.Add(this.DoanhThuReportViewer);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DoanhThuReportViewer;
    }
}