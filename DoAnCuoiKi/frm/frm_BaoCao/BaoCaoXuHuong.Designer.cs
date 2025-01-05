namespace DoAnCuoiKi.frm.frm_BaoCao
{
    partial class BaoCaoXuHuong
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
            this.SanPhamReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LapBaoCaoButton = new System.Windows.Forms.Button();
            this.ThangText = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NamText = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sanphamfrid = new System.Windows.Forms.DataGridView();
            this.danhmucfrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TongSanPhamText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThangText)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamfrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucfrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamReportViewer
            // 
            this.SanPhamReportViewer.Location = new System.Drawing.Point(0, 249);
            this.SanPhamReportViewer.Name = "SanPhamReportViewer";
            this.SanPhamReportViewer.ServerReport.BearerToken = null;
            this.SanPhamReportViewer.Size = new System.Drawing.Size(1383, 585);
            this.SanPhamReportViewer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO XU HƯỚNG SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng:";
            // 
            // LapBaoCaoButton
            // 
            this.LapBaoCaoButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapBaoCaoButton.Location = new System.Drawing.Point(54, 191);
            this.LapBaoCaoButton.Name = "LapBaoCaoButton";
            this.LapBaoCaoButton.Size = new System.Drawing.Size(159, 41);
            this.LapBaoCaoButton.TabIndex = 4;
            this.LapBaoCaoButton.Text = "Lập báo cáo";
            this.LapBaoCaoButton.UseVisualStyleBackColor = true;
            this.LapBaoCaoButton.Click += new System.EventHandler(this.LapBaoCaoButton_Click);
            // 
            // ThangText
            // 
            this.ThangText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThangText.Location = new System.Drawing.Point(118, 104);
            this.ThangText.Name = "ThangText";
            this.ThangText.Size = new System.Drawing.Size(95, 28);
            this.ThangText.TabIndex = 0;
            this.ThangText.ValueChanged += new System.EventHandler(this.ThangText_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1383, 71);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(368, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NamText
            // 
            this.NamText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamText.Location = new System.Drawing.Point(118, 138);
            this.NamText.Name = "NamText";
            this.NamText.Size = new System.Drawing.Size(95, 28);
            this.NamText.TabIndex = 11;
            this.NamText.ValueChanged += new System.EventHandler(this.NamText_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm:";
            // 
            // sanphamfrid
            // 
            this.sanphamfrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanphamfrid.Location = new System.Drawing.Point(533, 104);
            this.sanphamfrid.Name = "sanphamfrid";
            this.sanphamfrid.RowHeadersWidth = 51;
            this.sanphamfrid.RowTemplate.Height = 24;
            this.sanphamfrid.Size = new System.Drawing.Size(374, 139);
            this.sanphamfrid.TabIndex = 13;
            // 
            // danhmucfrid
            // 
            this.danhmucfrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhmucfrid.Location = new System.Drawing.Point(962, 104);
            this.danhmucfrid.Name = "danhmucfrid";
            this.danhmucfrid.RowHeadersWidth = 51;
            this.danhmucfrid.Size = new System.Drawing.Size(374, 139);
            this.danhmucfrid.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(958, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng:";
            // 
            // TongSanPhamText
            // 
            this.TongSanPhamText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongSanPhamText.Location = new System.Drawing.Point(322, 104);
            this.TongSanPhamText.Name = "TongSanPhamText";
            this.TongSanPhamText.ReadOnly = true;
            this.TongSanPhamText.Size = new System.Drawing.Size(156, 28);
            this.TongSanPhamText.TabIndex = 19;
            // 
            // BaoCaoXuHuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 833);
            this.Controls.Add(this.TongSanPhamText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.danhmucfrid);
            this.Controls.Add(this.sanphamfrid);
            this.Controls.Add(this.NamText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ThangText);
            this.Controls.Add(this.LapBaoCaoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SanPhamReportViewer);
            this.Name = "BaoCaoXuHuong";
            this.Text = "Báo cáo xu hướng";
            this.Load += new System.EventHandler(this.BaoCaoXuHuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThangText)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanphamfrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhmucfrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer SanPhamReportViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LapBaoCaoButton;
        private System.Windows.Forms.NumericUpDown ThangText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NamText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView sanphamfrid;
        private System.Windows.Forms.DataGridView danhmucfrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TongSanPhamText;
    }
}