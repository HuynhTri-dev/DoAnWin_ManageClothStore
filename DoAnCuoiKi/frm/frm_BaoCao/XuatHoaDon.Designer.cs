namespace DoAnCuoiKi
{
    partial class XuatHoaDon
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
            this.DonHangReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DonHangReportViewer
            // 
            this.DonHangReportViewer.Location = new System.Drawing.Point(-1, 1);
            this.DonHangReportViewer.Name = "DonHangReportViewer";
            this.DonHangReportViewer.ServerReport.BearerToken = null;
            this.DonHangReportViewer.Size = new System.Drawing.Size(884, 573);
            this.DonHangReportViewer.TabIndex = 0;
            this.DonHangReportViewer.Load += new System.EventHandler(this.DonHangReportViewer_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Trờ lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DonHangReportViewer);
            this.Name = "XuatHoaDon";
            this.Text = "XuatHoaDon";
            this.Load += new System.EventHandler(this.XuatHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DonHangReportViewer;
        private System.Windows.Forms.Button button1;
    }
}