namespace DoAnCuoiKi
{
    partial class QuanLyDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.MapWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.DonHangAdvanced = new Zuby.ADGV.AdvancedDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MaPhieuText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NgayLapDate = new System.Windows.Forms.DateTimePicker();
            this.NgayGiaoDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaChiText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GhiChuText = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapWebView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangAdvanced)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(610, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐƠN HÀNG";
            // 
            // MapWebView
            // 
            this.MapWebView.AllowExternalDrop = true;
            this.MapWebView.CreationProperties = null;
            this.MapWebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MapWebView.Location = new System.Drawing.Point(707, 101);
            this.MapWebView.Name = "MapWebView";
            this.MapWebView.Size = new System.Drawing.Size(700, 578);
            this.MapWebView.TabIndex = 1;
            this.MapWebView.ZoomFactor = 1D;
            // 
            // DonHangAdvanced
            // 
            this.DonHangAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonHangAdvanced.FilterAndSortEnabled = true;
            this.DonHangAdvanced.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DonHangAdvanced.Location = new System.Drawing.Point(24, 301);
            this.DonHangAdvanced.MaxFilterButtonImageHeight = 23;
            this.DonHangAdvanced.Name = "DonHangAdvanced";
            this.DonHangAdvanced.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DonHangAdvanced.RowHeadersWidth = 51;
            this.DonHangAdvanced.RowTemplate.Height = 24;
            this.DonHangAdvanced.Size = new System.Drawing.Size(655, 378);
            this.DonHangAdvanced.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DonHangAdvanced.TabIndex = 2;
            this.DonHangAdvanced.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonHangAdvanced_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phiếu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GhiChuText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NgayGiaoDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DiaChiText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NgayLapDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaPhieuText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // MaPhieuText
            // 
            this.MaPhieuText.Location = new System.Drawing.Point(122, 42);
            this.MaPhieuText.Name = "MaPhieuText";
            this.MaPhieuText.Size = new System.Drawing.Size(168, 28);
            this.MaPhieuText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày lập:";
            // 
            // NgayLapDate
            // 
            this.NgayLapDate.CustomFormat = "dd/MM/yyyy";
            this.NgayLapDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayLapDate.Location = new System.Drawing.Point(122, 84);
            this.NgayLapDate.Name = "NgayLapDate";
            this.NgayLapDate.Size = new System.Drawing.Size(150, 28);
            this.NgayLapDate.TabIndex = 6;
            // 
            // NgayGiaoDate
            // 
            this.NgayGiaoDate.CustomFormat = "dd/MM/yyyy";
            this.NgayGiaoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayGiaoDate.Location = new System.Drawing.Point(408, 83);
            this.NgayGiaoDate.Name = "NgayGiaoDate";
            this.NgayGiaoDate.Size = new System.Drawing.Size(150, 28);
            this.NgayGiaoDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày giao:";
            // 
            // DiaChiText
            // 
            this.DiaChiText.Location = new System.Drawing.Point(408, 41);
            this.DiaChiText.Name = "DiaChiText";
            this.DiaChiText.Size = new System.Drawing.Size(228, 28);
            this.DiaChiText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ghi chú:";
            // 
            // GhiChuText
            // 
            this.GhiChuText.Location = new System.Drawing.Point(122, 127);
            this.GhiChuText.Name = "GhiChuText";
            this.GhiChuText.Size = new System.Drawing.Size(168, 49);
            this.GhiChuText.TabIndex = 12;
            this.GhiChuText.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(408, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 28);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái:";
            // 
            // QuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DonHangAdvanced);
            this.Controls.Add(this.MapWebView);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDonHang";
            this.Text = "Đơn Hàng";
            this.Load += new System.EventHandler(this.QuanLyDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapWebView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangAdvanced)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Web.WebView2.WinForms.WebView2 MapWebView;
        private Zuby.ADGV.AdvancedDataGridView DonHangAdvanced;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox GhiChuText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker NgayGiaoDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiaChiText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NgayLapDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaPhieuText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}