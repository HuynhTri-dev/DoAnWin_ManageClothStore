namespace DoAnCuoiKi
{
    partial class QuanLyDongHang
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
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.CapNhatButton = new System.Windows.Forms.Button();
            this.PhiText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaDHText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TrangThaComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GhiChuText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NgayGiaoDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaChiText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NgayLapDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MaPhieuText = new System.Windows.Forms.TextBox();
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
            this.MapWebView.TabIndex = 2;
            this.MapWebView.ZoomFactor = 1D;
            this.MapWebView.Click += new System.EventHandler(this.MapWebView_Click);
            // 
            // DonHangAdvanced
            // 
            this.DonHangAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonHangAdvanced.FilterAndSortEnabled = true;
            this.DonHangAdvanced.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DonHangAdvanced.Location = new System.Drawing.Point(19, 351);
            this.DonHangAdvanced.MaxFilterButtonImageHeight = 23;
            this.DonHangAdvanced.Name = "DonHangAdvanced";
            this.DonHangAdvanced.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DonHangAdvanced.RowHeadersWidth = 51;
            this.DonHangAdvanced.RowTemplate.Height = 24;
            this.DonHangAdvanced.Size = new System.Drawing.Size(677, 328);
            this.DonHangAdvanced.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.DonHangAdvanced.TabIndex = 0;
            this.DonHangAdvanced.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.DonHangAdvanced_SortStringChanged);
            this.DonHangAdvanced.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.DonHangAdvanced_FilterStringChanged);
            this.DonHangAdvanced.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonHangAdvanced_CellContentClick);
            this.DonHangAdvanced.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonHangAdvanced_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phiếu:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimKiemButton);
            this.groupBox1.Controls.Add(this.CapNhatButton);
            this.groupBox1.Controls.Add(this.PhiText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MaDHText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TrangThaComboBox);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Location = new System.Drawing.Point(589, 30);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(82, 33);
            this.TimKiemButton.TabIndex = 9;
            this.TimKiemButton.Text = "Find";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            this.TimKiemButton.Click += new System.EventHandler(this.TimKiemButton_Click);
            // 
            // CapNhatButton
            // 
            this.CapNhatButton.Location = new System.Drawing.Point(334, 169);
            this.CapNhatButton.Name = "CapNhatButton";
            this.CapNhatButton.Size = new System.Drawing.Size(103, 35);
            this.CapNhatButton.TabIndex = 8;
            this.CapNhatButton.Text = "Cập nhật";
            this.CapNhatButton.UseVisualStyleBackColor = true;
            this.CapNhatButton.Click += new System.EventHandler(this.CapNhatButton_Click);
            // 
            // PhiText
            // 
            this.PhiText.Location = new System.Drawing.Point(122, 135);
            this.PhiText.Name = "PhiText";
            this.PhiText.Size = new System.Drawing.Size(202, 28);
            this.PhiText.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phí:";
            // 
            // MaDHText
            // 
            this.MaDHText.Location = new System.Drawing.Point(433, 33);
            this.MaDHText.Name = "MaDHText";
            this.MaDHText.Size = new System.Drawing.Size(150, 28);
            this.MaDHText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã DH:";
            // 
            // TrangThaComboBox
            // 
            this.TrangThaComboBox.FormattingEnabled = true;
            this.TrangThaComboBox.Items.AddRange(new object[] {
            "Chưa giao",
            "Đang giao",
            "Hoàn thành"});
            this.TrangThaComboBox.Location = new System.Drawing.Point(433, 101);
            this.TrangThaComboBox.Name = "TrangThaComboBox";
            this.TrangThaComboBox.Size = new System.Drawing.Size(150, 29);
            this.TrangThaComboBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái:";
            // 
            // GhiChuText
            // 
            this.GhiChuText.Location = new System.Drawing.Point(122, 169);
            this.GhiChuText.Name = "GhiChuText";
            this.GhiChuText.Size = new System.Drawing.Size(202, 61);
            this.GhiChuText.TabIndex = 4;
            this.GhiChuText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ghi chú:";
            // 
            // NgayGiaoDate
            // 
            this.NgayGiaoDate.CustomFormat = "dd/MM/yyyy";
            this.NgayGiaoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayGiaoDate.Location = new System.Drawing.Point(433, 66);
            this.NgayGiaoDate.Name = "NgayGiaoDate";
            this.NgayGiaoDate.Size = new System.Drawing.Size(150, 28);
            this.NgayGiaoDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày giao:";
            // 
            // DiaChiText
            // 
            this.DiaChiText.Location = new System.Drawing.Point(122, 101);
            this.DiaChiText.Name = "DiaChiText";
            this.DiaChiText.Size = new System.Drawing.Size(202, 28);
            this.DiaChiText.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ:";
            // 
            // NgayLapDate
            // 
            this.NgayLapDate.CustomFormat = "dd/MM/yyyy";
            this.NgayLapDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayLapDate.Location = new System.Drawing.Point(122, 67);
            this.NgayLapDate.Name = "NgayLapDate";
            this.NgayLapDate.Size = new System.Drawing.Size(150, 28);
            this.NgayLapDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày lập:";
            // 
            // MaPhieuText
            // 
            this.MaPhieuText.Location = new System.Drawing.Point(122, 33);
            this.MaPhieuText.Name = "MaPhieuText";
            this.MaPhieuText.Size = new System.Drawing.Size(202, 28);
            this.MaPhieuText.TabIndex = 0;
            // 
            // QuanLyDongHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DonHangAdvanced);
            this.Controls.Add(this.MapWebView);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDongHang";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TrangThaComboBox;
        private System.Windows.Forms.TextBox MaDHText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhiText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.Button CapNhatButton;
    }
}