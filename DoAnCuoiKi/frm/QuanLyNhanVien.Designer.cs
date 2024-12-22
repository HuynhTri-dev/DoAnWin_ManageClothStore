namespace DoAnCuoiKi
{
    partial class QuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSDTS = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.nhanVienDataGrid = new System.Windows.Forms.DataGridView();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.dtpStaff = new System.Windows.Forms.DateTimePicker();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.txtSDTS = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nuRadio = new System.Windows.Forms.RadioButton();
            this.namRadio = new System.Windows.Forms.RadioButton();
            this.taoTKButton = new System.Windows.Forms.Button();
            this.MaTKTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGrid)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1083, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí nhân viên";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(108, 33);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(86, 16);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Mã nhân viên";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(108, 75);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(52, 16);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "Họ Tên";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(108, 124);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính";
            // 
            // lblSDTS
            // 
            this.lblSDTS.AutoSize = true;
            this.lblSDTS.Location = new System.Drawing.Point(108, 171);
            this.lblSDTS.Name = "lblSDTS";
            this.lblSDTS.Size = new System.Drawing.Size(35, 16);
            this.lblSDTS.TabIndex = 4;
            this.lblSDTS.Text = "SDT";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(515, 33);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(67, 16);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(515, 81);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 16);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Chức vụ";
            // 
            // nhanVienDataGrid
            // 
            this.nhanVienDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.nhanVienDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nhanVienDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.nhanVienDataGrid.Location = new System.Drawing.Point(28, 289);
            this.nhanVienDataGrid.Name = "nhanVienDataGrid";
            this.nhanVienDataGrid.ReadOnly = true;
            this.nhanVienDataGrid.RowHeadersWidth = 51;
            this.nhanVienDataGrid.RowTemplate.Height = 24;
            this.nhanVienDataGrid.Size = new System.Drawing.Size(1030, 371);
            this.nhanVienDataGrid.TabIndex = 8;
            this.nhanVienDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhanVienDataGrid_CellContentClick);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(200, 30);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(187, 22);
            this.txtStaffID.TabIndex = 9;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(200, 75);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(187, 22);
            this.txtStaffName.TabIndex = 10;
            // 
            // dtpStaff
            // 
            this.dtpStaff.CustomFormat = "dd/MM/yyyy";
            this.dtpStaff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStaff.Location = new System.Drawing.Point(612, 28);
            this.dtpStaff.Name = "dtpStaff";
            this.dtpStaff.Size = new System.Drawing.Size(121, 22);
            this.dtpStaff.TabIndex = 12;
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(612, 75);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(121, 24);
            this.cboRole.TabIndex = 13;
            // 
            // txtSDTS
            // 
            this.txtSDTS.Location = new System.Drawing.Point(200, 165);
            this.txtSDTS.Name = "txtSDTS";
            this.txtSDTS.Size = new System.Drawing.Size(187, 22);
            this.txtSDTS.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(518, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 26);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm/Cập nhật";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(683, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nuRadio);
            this.groupBox1.Controls.Add(this.namRadio);
            this.groupBox1.Controls.Add(this.txtSDTS);
            this.groupBox1.Controls.Add(this.cboRole);
            this.groupBox1.Controls.Add(this.lblSDTS);
            this.groupBox1.Controls.Add(this.taoTKButton);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.MaTKTextBox);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.dtpStaff);
            this.groupBox1.Controls.Add(this.lblStaffName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.lblStaffID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDOB);
            this.groupBox1.Location = new System.Drawing.Point(28, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 213);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // nuRadio
            // 
            this.nuRadio.AutoSize = true;
            this.nuRadio.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuRadio.Location = new System.Drawing.Point(279, 123);
            this.nuRadio.Name = "nuRadio";
            this.nuRadio.Size = new System.Drawing.Size(44, 20);
            this.nuRadio.TabIndex = 25;
            this.nuRadio.TabStop = true;
            this.nuRadio.Text = "Nữ";
            this.nuRadio.UseVisualStyleBackColor = true;
            // 
            // namRadio
            // 
            this.namRadio.AutoSize = true;
            this.namRadio.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namRadio.Location = new System.Drawing.Point(200, 123);
            this.namRadio.Name = "namRadio";
            this.namRadio.Size = new System.Drawing.Size(54, 20);
            this.namRadio.TabIndex = 24;
            this.namRadio.TabStop = true;
            this.namRadio.Text = "Nam";
            this.namRadio.UseVisualStyleBackColor = true;
            // 
            // taoTKButton
            // 
            this.taoTKButton.Location = new System.Drawing.Point(751, 122);
            this.taoTKButton.Name = "taoTKButton";
            this.taoTKButton.Size = new System.Drawing.Size(75, 23);
            this.taoTKButton.TabIndex = 23;
            this.taoTKButton.Text = "Tạo TK";
            this.taoTKButton.UseVisualStyleBackColor = true;
            this.taoTKButton.Click += new System.EventHandler(this.taoTKButton_Click);
            // 
            // MaTKTextBox
            // 
            this.MaTKTextBox.Location = new System.Drawing.Point(610, 123);
            this.MaTKTextBox.Name = "MaTKTextBox";
            this.MaTKTextBox.ReadOnly = true;
            this.MaTKTextBox.Size = new System.Drawing.Size(121, 22);
            this.MaTKTextBox.TabIndex = 22;
            this.MaTKTextBox.TextChanged += new System.EventHandler(this.MaTKTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã TK";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1083, 672);
            this.Controls.Add(this.nhanVienDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSDTS;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridView nhanVienDataGrid;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.DateTimePicker dtpStaff;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.TextBox txtSDTS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MaTKTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button taoTKButton;
        private System.Windows.Forms.RadioButton nuRadio;
        private System.Windows.Forms.RadioButton namRadio;
    }
}