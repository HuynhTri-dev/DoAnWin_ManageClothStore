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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSDTS = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpStaff = new System.Windows.Forms.DateTimePicker();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.txtSDTS = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(924, 58);
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
            this.lblStaffID.Location = new System.Drawing.Point(43, 103);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(86, 16);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Mã nhân viên";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(43, 164);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(52, 16);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "Họ Tên";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(43, 224);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 16);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính";
            // 
            // lblSDTS
            // 
            this.lblSDTS.AutoSize = true;
            this.lblSDTS.Location = new System.Drawing.Point(43, 288);
            this.lblSDTS.Name = "lblSDTS";
            this.lblSDTS.Size = new System.Drawing.Size(35, 16);
            this.lblSDTS.TabIndex = 4;
            this.lblSDTS.Text = "SDT";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(402, 103);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(67, 16);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(402, 170);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 16);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Chức vụ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(402, 229);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 16);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvStaffName,
            this.dgvSGender,
            this.dgvSDOB,
            this.dgvSPN,
            this.dgvRole,
            this.dgvSAddress});
            this.dataGridView1.Location = new System.Drawing.Point(0, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 268);
            this.dataGridView1.TabIndex = 8;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "Mã nhân viên";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.Width = 125;
            // 
            // dgvStaffName
            // 
            this.dgvStaffName.HeaderText = "Họ Tên";
            this.dgvStaffName.MinimumWidth = 6;
            this.dgvStaffName.Name = "dgvStaffName";
            this.dgvStaffName.Width = 125;
            // 
            // dgvSGender
            // 
            this.dgvSGender.HeaderText = "Giới tính";
            this.dgvSGender.MinimumWidth = 6;
            this.dgvSGender.Name = "dgvSGender";
            this.dgvSGender.Width = 125;
            // 
            // dgvSDOB
            // 
            this.dgvSDOB.HeaderText = "Ngày Sinh";
            this.dgvSDOB.MinimumWidth = 6;
            this.dgvSDOB.Name = "dgvSDOB";
            this.dgvSDOB.Width = 125;
            // 
            // dgvSPN
            // 
            this.dgvSPN.HeaderText = "SDT";
            this.dgvSPN.MinimumWidth = 6;
            this.dgvSPN.Name = "dgvSPN";
            this.dgvSPN.Width = 125;
            // 
            // dgvRole
            // 
            this.dgvRole.HeaderText = "Chức Vụ";
            this.dgvRole.MinimumWidth = 6;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.Width = 125;
            // 
            // dgvSAddress
            // 
            this.dgvSAddress.HeaderText = "Địa chỉ";
            this.dgvSAddress.MinimumWidth = 6;
            this.dgvSAddress.Name = "dgvSAddress";
            this.dgvSAddress.Width = 125;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(135, 100);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(187, 22);
            this.txtStaffID.TabIndex = 9;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(135, 164);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(187, 22);
            this.txtStaffName.TabIndex = 10;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGender.Location = new System.Drawing.Point(135, 221);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 24);
            this.cboGender.TabIndex = 11;
            // 
            // dtpStaff
            // 
            this.dtpStaff.CustomFormat = "dd/MM/yyyy";
            this.dtpStaff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStaff.Location = new System.Drawing.Point(499, 98);
            this.dtpStaff.Name = "dtpStaff";
            this.dtpStaff.Size = new System.Drawing.Size(121, 22);
            this.dtpStaff.TabIndex = 12;
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Quản lý"});
            this.cboRole.Location = new System.Drawing.Point(499, 164);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(121, 24);
            this.cboRole.TabIndex = 13;
            // 
            // txtSDTS
            // 
            this.txtSDTS.Location = new System.Drawing.Point(135, 282);
            this.txtSDTS.Name = "txtSDTS";
            this.txtSDTS.Size = new System.Drawing.Size(187, 22);
            this.txtSDTS.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(499, 229);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 22);
            this.txtAddress.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(405, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(515, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(582, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(697, 215);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Location = new System.Drawing.Point(28, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 260);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(924, 614);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSDTS);
            this.Controls.Add(this.dtpStaff);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSDTS);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpStaff;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.TextBox txtSDTS;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}