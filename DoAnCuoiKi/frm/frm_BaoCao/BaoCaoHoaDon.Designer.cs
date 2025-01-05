namespace DoAnCuoiKi
{
    partial class BaoCaoHoaDon
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
            this.BaoCaoReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NamText = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ThangText = new System.Windows.Forms.NumericUpDown();
            this.LapBaoCaoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThangText)).BeginInit();
            this.SuspendLayout();
            // 
            // BaoCaoReportViewer
            // 
            this.BaoCaoReportViewer.Location = new System.Drawing.Point(-2, 151);
            this.BaoCaoReportViewer.Name = "BaoCaoReportViewer";
            this.BaoCaoReportViewer.ServerReport.BearerToken = null;
            this.BaoCaoReportViewer.Size = new System.Drawing.Size(1177, 515);
            this.BaoCaoReportViewer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 77);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(489, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "BÁO CÁO HÓA ĐƠN";
            // 
            // NamText
            // 
            this.NamText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamText.Location = new System.Drawing.Point(538, 118);
            this.NamText.Name = "NamText";
            this.NamText.Size = new System.Drawing.Size(95, 28);
            this.NamText.TabIndex = 17;
            this.NamText.ValueChanged += new System.EventHandler(this.NamText_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Năm:";
            // 
            // ThangText
            // 
            this.ThangText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThangText.Location = new System.Drawing.Point(538, 84);
            this.ThangText.Name = "ThangText";
            this.ThangText.Size = new System.Drawing.Size(95, 28);
            this.ThangText.TabIndex = 14;
            this.ThangText.ValueChanged += new System.EventHandler(this.ThangText_ValueChanged);
            // 
            // LapBaoCaoButton
            // 
            this.LapBaoCaoButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapBaoCaoButton.Location = new System.Drawing.Point(689, 95);
            this.LapBaoCaoButton.Name = "LapBaoCaoButton";
            this.LapBaoCaoButton.Size = new System.Drawing.Size(159, 41);
            this.LapBaoCaoButton.TabIndex = 16;
            this.LapBaoCaoButton.Text = "Lập báo cáo";
            this.LapBaoCaoButton.UseVisualStyleBackColor = true;
            this.LapBaoCaoButton.Click += new System.EventHandler(this.LapBaoCaoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tháng:";
            // 
            // BaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 678);
            this.Controls.Add(this.NamText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThangText);
            this.Controls.Add(this.LapBaoCaoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BaoCaoReportViewer);
            this.Name = "BaoCaoHoaDon";
            this.Text = "BaoCaoHoaDon";
            this.Load += new System.EventHandler(this.BaoCaoHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThangText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer BaoCaoReportViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NamText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThangText;
        private System.Windows.Forms.Button LapBaoCaoButton;
        private System.Windows.Forms.Label label1;
    }
}