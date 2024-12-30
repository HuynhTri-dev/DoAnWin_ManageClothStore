namespace DoAnCuoiKi.frm.frm_Data
{
    partial class QuanLyHoaDon
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
            this.HoaDonAdvance = new Zuby.ADGV.AdvancedDataGridView();
            this.CTDHDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PTTTText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TongTienText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaHDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NgayLap = new System.Windows.Forms.DateTimePicker();
            this.MaKMText = new System.Windows.Forms.TextBox();
            this.MaNVText = new System.Windows.Forms.TextBox();
            this.MaKHText = new System.Windows.Forms.TextBox();
            this.LoaiDHText = new System.Windows.Forms.TextBox();
            this.MaDHText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XoaButton = new System.Windows.Forms.Button();
            this.InHoaDonButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTDHDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 99);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // HoaDonAdvance
            // 
            this.HoaDonAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoaDonAdvance.FilterAndSortEnabled = true;
            this.HoaDonAdvance.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.HoaDonAdvance.Location = new System.Drawing.Point(34, 122);
            this.HoaDonAdvance.MaxFilterButtonImageHeight = 23;
            this.HoaDonAdvance.Name = "HoaDonAdvance";
            this.HoaDonAdvance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HoaDonAdvance.RowHeadersWidth = 51;
            this.HoaDonAdvance.RowTemplate.Height = 24;
            this.HoaDonAdvance.Size = new System.Drawing.Size(861, 555);
            this.HoaDonAdvance.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.HoaDonAdvance.TabIndex = 7;
            this.HoaDonAdvance.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.HoaDonAdvance_SortStringChanged);
            this.HoaDonAdvance.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.HoaDonAdvance_FilterStringChanged);
            this.HoaDonAdvance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoaDonAdvance_CellContentClick);
            this.HoaDonAdvance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoaDonAdvance_CellContentClick);
            // 
            // CTDHDataGrid
            // 
            this.CTDHDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CTDHDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTDHDataGrid.Location = new System.Drawing.Point(936, 507);
            this.CTDHDataGrid.Name = "CTDHDataGrid";
            this.CTDHDataGrid.RowHeadersWidth = 51;
            this.CTDHDataGrid.RowTemplate.Height = 24;
            this.CTDHDataGrid.Size = new System.Drawing.Size(453, 170);
            this.CTDHDataGrid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(949, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chi tiết đơn hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PTTTText);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TongTienText);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MaHDTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NgayLap);
            this.groupBox1.Controls.Add(this.MaKMText);
            this.groupBox1.Controls.Add(this.MaNVText);
            this.groupBox1.Controls.Add(this.MaKHText);
            this.groupBox1.Controls.Add(this.LoaiDHText);
            this.groupBox1.Controls.Add(this.MaDHText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(936, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 345);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // PTTTText
            // 
            this.PTTTText.Location = new System.Drawing.Point(108, 129);
            this.PTTTText.Name = "PTTTText";
            this.PTTTText.Size = new System.Drawing.Size(208, 28);
            this.PTTTText.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "PTTT:";
            // 
            // TongTienText
            // 
            this.TongTienText.Location = new System.Drawing.Point(108, 95);
            this.TongTienText.Name = "TongTienText";
            this.TongTienText.Size = new System.Drawing.Size(208, 28);
            this.TongTienText.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Tổng tiền:";
            // 
            // MaHDTextBox
            // 
            this.MaHDTextBox.Location = new System.Drawing.Point(108, 27);
            this.MaHDTextBox.Name = "MaHDTextBox";
            this.MaHDTextBox.Size = new System.Drawing.Size(208, 28);
            this.MaHDTextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mã HD:";
            // 
            // NgayLap
            // 
            this.NgayLap.CustomFormat = "dd/MM/yyyy";
            this.NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayLap.Location = new System.Drawing.Point(108, 61);
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Size = new System.Drawing.Size(208, 28);
            this.NgayLap.TabIndex = 24;
            // 
            // MaKMText
            // 
            this.MaKMText.Location = new System.Drawing.Point(108, 299);
            this.MaKMText.Name = "MaKMText";
            this.MaKMText.Size = new System.Drawing.Size(208, 28);
            this.MaKMText.TabIndex = 23;
            // 
            // MaNVText
            // 
            this.MaNVText.Location = new System.Drawing.Point(108, 265);
            this.MaNVText.Name = "MaNVText";
            this.MaNVText.Size = new System.Drawing.Size(208, 28);
            this.MaNVText.TabIndex = 22;
            // 
            // MaKHText
            // 
            this.MaKHText.Location = new System.Drawing.Point(108, 231);
            this.MaKHText.Name = "MaKHText";
            this.MaKHText.Size = new System.Drawing.Size(208, 28);
            this.MaKHText.TabIndex = 21;
            // 
            // LoaiDHText
            // 
            this.LoaiDHText.Location = new System.Drawing.Point(108, 197);
            this.LoaiDHText.Name = "LoaiDHText";
            this.LoaiDHText.Size = new System.Drawing.Size(208, 28);
            this.LoaiDHText.TabIndex = 20;
            // 
            // MaDHText
            // 
            this.MaDHText.Location = new System.Drawing.Point(108, 163);
            this.MaDHText.Name = "MaDHText";
            this.MaDHText.Size = new System.Drawing.Size(208, 28);
            this.MaDHText.TabIndex = 18;
            this.MaDHText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã KM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã NV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loại DH:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = " Mã DH:";
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(1288, 197);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(101, 45);
            this.XoaButton.TabIndex = 13;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // InHoaDonButton
            // 
            this.InHoaDonButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHoaDonButton.Location = new System.Drawing.Point(1288, 133);
            this.InHoaDonButton.Name = "InHoaDonButton";
            this.InHoaDonButton.Size = new System.Drawing.Size(101, 45);
            this.InHoaDonButton.TabIndex = 14;
            this.InHoaDonButton.Text = "In hóa đơn";
            this.InHoaDonButton.UseVisualStyleBackColor = true;
            this.InHoaDonButton.Click += new System.EventHandler(this.InHoaDonButton_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.InHoaDonButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CTDHDataGrid);
            this.Controls.Add(this.HoaDonAdvance);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTDHDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView HoaDonAdvance;
        private System.Windows.Forms.DataGridView CTDHDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaDHText;
        private System.Windows.Forms.TextBox LoaiDHText;
        private System.Windows.Forms.TextBox MaKMText;
        private System.Windows.Forms.TextBox MaNVText;
        private System.Windows.Forms.TextBox MaKHText;
        private System.Windows.Forms.DateTimePicker NgayLap;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button InHoaDonButton;
        private System.Windows.Forms.TextBox TongTienText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaHDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PTTTText;
        private System.Windows.Forms.Label label11;
    }
}