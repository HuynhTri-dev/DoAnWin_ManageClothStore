namespace DoAnCuoiKi
{
    partial class QuanLyKhachHang
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
            this.ThongTinKHDataGirdView = new System.Windows.Forms.DataGridView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCDOB = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCGender = new System.Windows.Forms.Label();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.MaKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.HoTenTextBox = new System.Windows.Forms.TextBox();
            this.DiaChiTextBox = new System.Windows.Forms.TextBox();
            this.NgaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ThemSuaButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ghiChuText = new System.Windows.Forms.RichTextBox();
            this.NuRadioButton = new System.Windows.Forms.RadioButton();
            this.NamRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinKHDataGirdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThongTinKHDataGirdView
            // 
            this.ThongTinKHDataGirdView.AllowUserToAddRows = false;
            this.ThongTinKHDataGirdView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.ThongTinKHDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongTinKHDataGirdView.Location = new System.Drawing.Point(43, 353);
            this.ThongTinKHDataGirdView.Name = "ThongTinKHDataGirdView";
            this.ThongTinKHDataGirdView.RowHeadersWidth = 51;
            this.ThongTinKHDataGirdView.RowTemplate.Height = 24;
            this.ThongTinKHDataGirdView.Size = new System.Drawing.Size(1008, 307);
            this.ThongTinKHDataGirdView.TabIndex = 1;
            this.ThongTinKHDataGirdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ThongTinKHDataGirdView_CellContentClick);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(26, 27);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(144, 24);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Mã khách hàng";
            // 
            // lblCDOB
            // 
            this.lblCDOB.AutoSize = true;
            this.lblCDOB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDOB.Location = new System.Drawing.Point(419, 27);
            this.lblCDOB.Name = "lblCDOB";
            this.lblCDOB.Size = new System.Drawing.Size(97, 24);
            this.lblCDOB.TabIndex = 3;
            this.lblCDOB.Text = "Ngày sinh";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(26, 71);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(75, 24);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Họ Tên";
            // 
            // lblCGender
            // 
            this.lblCGender.AutoSize = true;
            this.lblCGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCGender.Location = new System.Drawing.Point(26, 119);
            this.lblCGender.Name = "lblCGender";
            this.lblCGender.Size = new System.Drawing.Size(84, 24);
            this.lblCGender.TabIndex = 5;
            this.lblCGender.Text = "Giới tính";
            // 
            // lblCAddress
            // 
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAddress.Location = new System.Drawing.Point(419, 71);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(71, 24);
            this.lblCAddress.TabIndex = 6;
            this.lblCAddress.Text = "Địa chỉ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(419, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 24);
            this.label.TabIndex = 7;
            this.label.Text = "Ghi chú";
            // 
            // MaKhachHangTextBox
            // 
            this.MaKhachHangTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhachHangTextBox.Location = new System.Drawing.Point(179, 21);
            this.MaKhachHangTextBox.Name = "MaKhachHangTextBox";
            this.MaKhachHangTextBox.Size = new System.Drawing.Size(195, 32);
            this.MaKhachHangTextBox.TabIndex = 8;
            // 
            // HoTenTextBox
            // 
            this.HoTenTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTenTextBox.Location = new System.Drawing.Point(179, 68);
            this.HoTenTextBox.Name = "HoTenTextBox";
            this.HoTenTextBox.Size = new System.Drawing.Size(195, 32);
            this.HoTenTextBox.TabIndex = 9;
            this.HoTenTextBox.TextChanged += new System.EventHandler(this.HoTenTextBox_TextChanged);
            // 
            // DiaChiTextBox
            // 
            this.DiaChiTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiTextBox.Location = new System.Drawing.Point(533, 68);
            this.DiaChiTextBox.Name = "DiaChiTextBox";
            this.DiaChiTextBox.Size = new System.Drawing.Size(189, 32);
            this.DiaChiTextBox.TabIndex = 10;
            // 
            // NgaySinhDateTimePicker
            // 
            this.NgaySinhDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.NgaySinhDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinhDateTimePicker.Location = new System.Drawing.Point(533, 21);
            this.NgaySinhDateTimePicker.Name = "NgaySinhDateTimePicker";
            this.NgaySinhDateTimePicker.Size = new System.Drawing.Size(163, 32);
            this.NgaySinhDateTimePicker.TabIndex = 12;
            this.NgaySinhDateTimePicker.ValueChanged += new System.EventHandler(this.NgaySinhDateTimePicker_ValueChanged);
            // 
            // ThemSuaButton
            // 
            this.ThemSuaButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemSuaButton.Location = new System.Drawing.Point(254, 174);
            this.ThemSuaButton.Name = "ThemSuaButton";
            this.ThemSuaButton.Size = new System.Drawing.Size(145, 40);
            this.ThemSuaButton.TabIndex = 14;
            this.ThemSuaButton.Text = "Thêm / Sửa";
            this.ThemSuaButton.UseVisualStyleBackColor = true;
            this.ThemSuaButton.Click += new System.EventHandler(this.ThemSuaButton_Click_1);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(479, 174);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(96, 40);
            this.XoaButton.TabIndex = 15;
            this.XoaButton.Text = "Xoá";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 78);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ghiChuText);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.NuRadioButton);
            this.groupBox1.Controls.Add(this.NamRadioButton);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.DiaChiTextBox);
            this.groupBox1.Controls.Add(this.NgaySinhDateTimePicker);
            this.groupBox1.Controls.Add(this.HoTenTextBox);
            this.groupBox1.Controls.Add(this.lblCAddress);
            this.groupBox1.Controls.Add(this.XoaButton);
            this.groupBox1.Controls.Add(this.lblCGender);
            this.groupBox1.Controls.Add(this.ThemSuaButton);
            this.groupBox1.Controls.Add(this.MaKhachHangTextBox);
            this.groupBox1.Controls.Add(this.lblCustomerID);
            this.groupBox1.Controls.Add(this.lblCDOB);
            this.groupBox1.Location = new System.Drawing.Point(119, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 233);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // ghiChuText
            // 
            this.ghiChuText.Location = new System.Drawing.Point(533, 113);
            this.ghiChuText.Name = "ghiChuText";
            this.ghiChuText.Size = new System.Drawing.Size(189, 52);
            this.ghiChuText.TabIndex = 17;
            this.ghiChuText.Text = "";
            // 
            // NuRadioButton
            // 
            this.NuRadioButton.AutoSize = true;
            this.NuRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuRadioButton.Location = new System.Drawing.Point(279, 117);
            this.NuRadioButton.Name = "NuRadioButton";
            this.NuRadioButton.Size = new System.Drawing.Size(56, 28);
            this.NuRadioButton.TabIndex = 16;
            this.NuRadioButton.TabStop = true;
            this.NuRadioButton.Text = "Nữ";
            this.NuRadioButton.UseVisualStyleBackColor = true;
            this.NuRadioButton.CheckedChanged += new System.EventHandler(this.NuRadioButton_CheckedChanged);
            // 
            // NamRadioButton
            // 
            this.NamRadioButton.AutoSize = true;
            this.NamRadioButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamRadioButton.Location = new System.Drawing.Point(179, 117);
            this.NamRadioButton.Name = "NamRadioButton";
            this.NamRadioButton.Size = new System.Drawing.Size(72, 28);
            this.NamRadioButton.TabIndex = 16;
            this.NamRadioButton.TabStop = true;
            this.NamRadioButton.Text = "Nam";
            this.NamRadioButton.UseVisualStyleBackColor = true;
            this.NamRadioButton.CheckedChanged += new System.EventHandler(this.NamRadioButton_CheckedChanged);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 672);
            this.Controls.Add(this.ThongTinKHDataGirdView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyKhachHang";
            this.Text = "v";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinKHDataGirdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ThongTinKHDataGirdView;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCDOB;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCGender;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox MaKhachHangTextBox;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox DiaChiTextBox;
        private System.Windows.Forms.DateTimePicker NgaySinhDateTimePicker;
        private System.Windows.Forms.Button ThemSuaButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NuRadioButton;
        private System.Windows.Forms.RadioButton NamRadioButton;
        private System.Windows.Forms.RichTextBox ghiChuText;
    }
}