namespace DoAnCuoiKi
{
    partial class BanHang
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
            this.label8 = new System.Windows.Forms.Label();
            this.LoaiDHComboBox = new System.Windows.Forms.ComboBox();
            this.GiaTriTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.MaKHTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaKMComboBox = new System.Windows.Forms.ComboBox();
            this.MaNVTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NgayLapDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MaDHTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DonHangDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LoaiDHComboBox);
            this.panel1.Controls.Add(this.GiaTriTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.MaKHTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.MaKMComboBox);
            this.panel1.Controls.Add(this.MaNVTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.NgayLapDatePicker);
            this.panel1.Controls.Add(this.MaDHTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DonHangDataGrid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(897, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 630);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Loại Đơn hàng:";
            // 
            // LoaiDHComboBox
            // 
            this.LoaiDHComboBox.FormattingEnabled = true;
            this.LoaiDHComboBox.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.LoaiDHComboBox.Location = new System.Drawing.Point(375, 398);
            this.LoaiDHComboBox.Name = "LoaiDHComboBox";
            this.LoaiDHComboBox.Size = new System.Drawing.Size(121, 24);
            this.LoaiDHComboBox.TabIndex = 21;
            this.LoaiDHComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GiaTriTextBox
            // 
            this.GiaTriTextBox.Location = new System.Drawing.Point(375, 438);
            this.GiaTriTextBox.Name = "GiaTriTextBox";
            this.GiaTriTextBox.ReadOnly = true;
            this.GiaTriTextBox.Size = new System.Drawing.Size(120, 22);
            this.GiaTriTextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Giá trị:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 441);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 16);
            this.label.TabIndex = 18;
            this.label.Text = "Khuyến mãi:";
            // 
            // MaKHTextBox
            // 
            this.MaKHTextBox.Location = new System.Drawing.Point(115, 398);
            this.MaKHTextBox.Name = "MaKHTextBox";
            this.MaKHTextBox.Size = new System.Drawing.Size(121, 22);
            this.MaKHTextBox.TabIndex = 17;
            this.MaKHTextBox.TextChanged += new System.EventHandler(this.MaKHTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã KH:";
            // 
            // MaKMComboBox
            // 
            this.MaKMComboBox.FormattingEnabled = true;
            this.MaKMComboBox.Location = new System.Drawing.Point(115, 438);
            this.MaKMComboBox.Name = "MaKMComboBox";
            this.MaKMComboBox.Size = new System.Drawing.Size(121, 24);
            this.MaKMComboBox.TabIndex = 15;
            this.MaKMComboBox.SelectedIndexChanged += new System.EventHandler(this.MaKMComboBox_SelectedIndexChanged);
            // 
            // MaNVTextBox
            // 
            this.MaNVTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNVTextBox.Location = new System.Drawing.Point(107, 105);
            this.MaNVTextBox.Name = "MaNVTextBox";
            this.MaNVTextBox.ReadOnly = true;
            this.MaNVTextBox.Size = new System.Drawing.Size(99, 23);
            this.MaNVTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã NV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày lập:";
            // 
            // NgayLapDatePicker
            // 
            this.NgayLapDatePicker.CustomFormat = "dd/MM/yyyy";
            this.NgayLapDatePicker.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLapDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayLapDatePicker.Location = new System.Drawing.Point(398, 92);
            this.NgayLapDatePicker.Name = "NgayLapDatePicker";
            this.NgayLapDatePicker.Size = new System.Drawing.Size(97, 23);
            this.NgayLapDatePicker.TabIndex = 11;
            // 
            // MaDHTextBox
            // 
            this.MaDHTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDHTextBox.Location = new System.Drawing.Point(107, 77);
            this.MaDHTextBox.Name = "MaDHTextBox";
            this.MaDHTextBox.Size = new System.Drawing.Size(99, 23);
            this.MaDHTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // DonHangDataGrid
            // 
            this.DonHangDataGrid.AllowUserToAddRows = false;
            this.DonHangDataGrid.AllowUserToDeleteRows = false;
            this.DonHangDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DonHangDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.DonHangDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonHangDataGrid.Location = new System.Drawing.Point(14, 133);
            this.DonHangDataGrid.Name = "DonHangDataGrid";
            this.DonHangDataGrid.ReadOnly = true;
            this.DonHangDataGrid.RowHeadersWidth = 51;
            this.DonHangDataGrid.RowTemplate.Height = 24;
            this.DonHangDataGrid.Size = new System.Drawing.Size(482, 251);
            this.DonHangDataGrid.TabIndex = 1;
            this.DonHangDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giỏ Hàng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(867, 542);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fancy Ronal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 71);
            this.panel2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "label9";
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1405, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonHangDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DonHangDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox MaNVTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker NgayLapDatePicker;
        private System.Windows.Forms.TextBox MaDHTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaKHTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MaKMComboBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox GiaTriTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox LoaiDHComboBox;
        private System.Windows.Forms.Label label9;
    }
}