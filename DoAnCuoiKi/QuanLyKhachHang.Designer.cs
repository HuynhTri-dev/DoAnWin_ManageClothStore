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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCDOB = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCGender = new System.Windows.Forms.Label();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpCus = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCustomerID,
            this.dgvCustomerName,
            this.dgvCustomerGender,
            this.dgvCDOB,
            this.dgvCAddress,
            this.dgvKM});
            this.dataGridView1.Location = new System.Drawing.Point(54, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgvCustomerID
            // 
            this.dgvCustomerID.HeaderText = "Mã khách hàng";
            this.dgvCustomerID.MinimumWidth = 6;
            this.dgvCustomerID.Name = "dgvCustomerID";
            this.dgvCustomerID.Width = 125;
            // 
            // dgvCustomerName
            // 
            this.dgvCustomerName.HeaderText = "Họ Tên";
            this.dgvCustomerName.MinimumWidth = 6;
            this.dgvCustomerName.Name = "dgvCustomerName";
            this.dgvCustomerName.Width = 125;
            // 
            // dgvCustomerGender
            // 
            this.dgvCustomerGender.HeaderText = "Giới tính";
            this.dgvCustomerGender.MinimumWidth = 6;
            this.dgvCustomerGender.Name = "dgvCustomerGender";
            this.dgvCustomerGender.Width = 125;
            // 
            // dgvCDOB
            // 
            this.dgvCDOB.HeaderText = "Ngày sinh";
            this.dgvCDOB.MinimumWidth = 6;
            this.dgvCDOB.Name = "dgvCDOB";
            this.dgvCDOB.Width = 125;
            // 
            // dgvCAddress
            // 
            this.dgvCAddress.HeaderText = "Địa chỉ";
            this.dgvCAddress.MinimumWidth = 6;
            this.dgvCAddress.Name = "dgvCAddress";
            this.dgvCAddress.Width = 125;
            // 
            // dgvKM
            // 
            this.dgvKM.HeaderText = "Khuyến Mãi";
            this.dgvKM.MinimumWidth = 6;
            this.dgvKM.Name = "dgvKM";
            this.dgvKM.Width = 125;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(90, 93);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Mã khách hàng";
            // 
            // lblCDOB
            // 
            this.lblCDOB.AutoSize = true;
            this.lblCDOB.Location = new System.Drawing.Point(492, 93);
            this.lblCDOB.Name = "lblCDOB";
            this.lblCDOB.Size = new System.Drawing.Size(67, 16);
            this.lblCDOB.TabIndex = 3;
            this.lblCDOB.Text = "Ngày sinh";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(90, 144);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 16);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Họ Tên";
            // 
            // lblCGender
            // 
            this.lblCGender.AutoSize = true;
            this.lblCGender.Location = new System.Drawing.Point(90, 199);
            this.lblCGender.Name = "lblCGender";
            this.lblCGender.Size = new System.Drawing.Size(54, 16);
            this.lblCGender.TabIndex = 5;
            this.lblCGender.Text = "Giới tính";
            // 
            // lblCAddress
            // 
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.Location = new System.Drawing.Point(492, 141);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(47, 16);
            this.lblCAddress.TabIndex = 6;
            this.lblCAddress.Text = "Địa chỉ";
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(492, 199);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(76, 16);
            this.lblPromo.TabIndex = 7;
            this.lblPromo.Text = "Khuyến Mãi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(606, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox1.Location = new System.Drawing.Point(229, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // dtpCus
            // 
            this.dtpCus.CustomFormat = "dd/MM/yyyy";
            this.dtpCus.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCus.Location = new System.Drawing.Point(606, 91);
            this.dtpCus.Name = "dtpCus";
            this.dtpCus.Size = new System.Drawing.Size(136, 22);
            this.dtpCus.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10%",
            "20%",
            "50%",
            "75%"});
            this.comboBox2.Location = new System.Drawing.Point(606, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 24);
            this.comboBox2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cập Nhật";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(645, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Quay lại";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(73, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 209);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(947, 521);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dtpCus);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.lblCAddress);
            this.Controls.Add(this.lblCGender);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCDOB);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyKhachHang";
            this.Text = "Thông tin khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKM;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCDOB;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCGender;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpCus;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}