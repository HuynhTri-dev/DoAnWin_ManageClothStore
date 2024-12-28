namespace DoAnCuoiKi.frm.frm_Data
{
    partial class QuanLyKhuyenMai
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
            this.KhuyenMaiDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ketThucDatePicker = new System.Windows.Forms.DateTimePicker();
            this.batDauDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.giaTriTextBox = new System.Windows.Forms.TextBox();
            this.maTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.themSuaButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KhuyenMaiDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 99);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(550, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHUYẾN MÃI";
            // 
            // KhuyenMaiDataGrid
            // 
            this.KhuyenMaiDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KhuyenMaiDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.KhuyenMaiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KhuyenMaiDataGrid.Location = new System.Drawing.Point(557, 132);
            this.KhuyenMaiDataGrid.Name = "KhuyenMaiDataGrid";
            this.KhuyenMaiDataGrid.RowHeadersWidth = 51;
            this.KhuyenMaiDataGrid.RowTemplate.Height = 24;
            this.KhuyenMaiDataGrid.Size = new System.Drawing.Size(837, 540);
            this.KhuyenMaiDataGrid.TabIndex = 1;
            this.KhuyenMaiDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KhuyenMaiDataGrid_CellContentClick);
            this.KhuyenMaiDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KhuyenMaiDataGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ketThucDatePicker);
            this.groupBox1.Controls.Add(this.batDauDatePicker);
            this.groupBox1.Controls.Add(this.tenTextBox);
            this.groupBox1.Controls.Add(this.giaTriTextBox);
            this.groupBox1.Controls.Add(this.maTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ketThucDatePicker
            // 
            this.ketThucDatePicker.CustomFormat = "dd/MM/yyyy";
            this.ketThucDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ketThucDatePicker.Location = new System.Drawing.Point(172, 211);
            this.ketThucDatePicker.Name = "ketThucDatePicker";
            this.ketThucDatePicker.Size = new System.Drawing.Size(267, 32);
            this.ketThucDatePicker.TabIndex = 9;
            // 
            // batDauDatePicker
            // 
            this.batDauDatePicker.CustomFormat = "dd/MM/yyyy";
            this.batDauDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.batDauDatePicker.Location = new System.Drawing.Point(172, 166);
            this.batDauDatePicker.Name = "batDauDatePicker";
            this.batDauDatePicker.Size = new System.Drawing.Size(267, 32);
            this.batDauDatePicker.TabIndex = 3;
            this.batDauDatePicker.Value = new System.DateTime(2024, 12, 25, 9, 0, 13, 0);
            // 
            // tenTextBox
            // 
            this.tenTextBox.Location = new System.Drawing.Point(172, 74);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(267, 32);
            this.tenTextBox.TabIndex = 1;
            // 
            // giaTriTextBox
            // 
            this.giaTriTextBox.Location = new System.Drawing.Point(172, 118);
            this.giaTriTextBox.Name = "giaTriTextBox";
            this.giaTriTextBox.Size = new System.Drawing.Size(267, 32);
            this.giaTriTextBox.TabIndex = 2;
            // 
            // maTextBox
            // 
            this.maTextBox.Location = new System.Drawing.Point(172, 31);
            this.maTextBox.Name = "maTextBox";
            this.maTextBox.Size = new System.Drawing.Size(267, 32);
            this.maTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã";
            // 
            // themSuaButton
            // 
            this.themSuaButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themSuaButton.Location = new System.Drawing.Point(75, 490);
            this.themSuaButton.Name = "themSuaButton";
            this.themSuaButton.Size = new System.Drawing.Size(168, 40);
            this.themSuaButton.TabIndex = 3;
            this.themSuaButton.Text = "Thêm / Sửa";
            this.themSuaButton.UseVisualStyleBackColor = true;
            this.themSuaButton.Click += new System.EventHandler(this.themSuaButton_Click);
            // 
            // xoaButton
            // 
            this.xoaButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaButton.Location = new System.Drawing.Point(392, 490);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(89, 40);
            this.xoaButton.TabIndex = 4;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.themSuaButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KhuyenMaiDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhuyenMai";
            this.Text = "QuanLyKhuyenMai";
            this.Load += new System.EventHandler(this.QuanLyKhuyenMai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KhuyenMaiDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KhuyenMaiDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ketThucDatePicker;
        private System.Windows.Forms.DateTimePicker batDauDatePicker;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox giaTriTextBox;
        private System.Windows.Forms.TextBox maTextBox;
        private System.Windows.Forms.Button themSuaButton;
        private System.Windows.Forms.Button xoaButton;
    }
}