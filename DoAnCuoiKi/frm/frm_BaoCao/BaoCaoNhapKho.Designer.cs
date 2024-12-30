namespace DoAnCuoiKi.frm.frm_BaoCao
{
    partial class BaoCaoNhapKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NamText = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ThangText = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NhapKhoReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.LapBaoCaoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThangText)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 77);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(373, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "BÁO CÁO NHẬP KHO";
            // 
            // NamText
            // 
            this.NamText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamText.Location = new System.Drawing.Point(158, 129);
            this.NamText.Name = "NamText";
            this.NamText.Size = new System.Drawing.Size(95, 28);
            this.NamText.TabIndex = 19;
            this.NamText.ValueChanged += new System.EventHandler(this.NamText_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Năm:";
            // 
            // ThangText
            // 
            this.ThangText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThangText.Location = new System.Drawing.Point(158, 95);
            this.ThangText.Name = "ThangText";
            this.ThangText.Size = new System.Drawing.Size(95, 28);
            this.ThangText.TabIndex = 17;
            this.ThangText.ValueChanged += new System.EventHandler(this.ThangText_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tháng:";
            // 
            // NhapKhoReport
            // 
            this.NhapKhoReport.Location = new System.Drawing.Point(0, 163);
            this.NhapKhoReport.Name = "NhapKhoReport";
            this.NhapKhoReport.ServerReport.BearerToken = null;
            this.NhapKhoReport.Size = new System.Drawing.Size(1110, 599);
            this.NhapKhoReport.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(931, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LapBaoCaoButton
            // 
            this.LapBaoCaoButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapBaoCaoButton.Location = new System.Drawing.Point(308, 112);
            this.LapBaoCaoButton.Name = "LapBaoCaoButton";
            this.LapBaoCaoButton.Size = new System.Drawing.Size(159, 41);
            this.LapBaoCaoButton.TabIndex = 22;
            this.LapBaoCaoButton.Text = "Lập báo cáo";
            this.LapBaoCaoButton.UseVisualStyleBackColor = true;
            this.LapBaoCaoButton.Click += new System.EventHandler(this.LapBaoCaoButton_Click);
            // 
            // BaoCaoNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LapBaoCaoButton);
            this.Controls.Add(this.NhapKhoReport);
            this.Controls.Add(this.NamText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThangText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoNhapKho";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaoCaoNhapKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThangText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NamText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ThangText;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer NhapKhoReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LapBaoCaoButton;
    }
}