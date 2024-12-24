namespace DoAnCuoiKi
{
    partial class NhanHieu
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
            this.label1 = new System.Windows.Forms.Label();
            this.NhanHieuDataGirdView = new System.Windows.Forms.DataGridView();
            this.MaTHTextBox = new System.Windows.Forms.TextBox();
            this.TenTHTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XoaButton = new System.Windows.Forms.Button();
            this.ThemSuaButton = new System.Windows.Forms.Button();
            this.TroLaiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NhanHieuDataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(258, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhãn Hiệu";
            // 
            // NhanHieuDataGirdView
            // 
            this.NhanHieuDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NhanHieuDataGirdView.Location = new System.Drawing.Point(371, 111);
            this.NhanHieuDataGirdView.Name = "NhanHieuDataGirdView";
            this.NhanHieuDataGirdView.RowHeadersWidth = 51;
            this.NhanHieuDataGirdView.RowTemplate.Height = 24;
            this.NhanHieuDataGirdView.Size = new System.Drawing.Size(322, 184);
            this.NhanHieuDataGirdView.TabIndex = 18;
            // 
            // MaTHTextBox
            // 
            this.MaTHTextBox.Location = new System.Drawing.Point(167, 115);
            this.MaTHTextBox.Name = "MaTHTextBox";
            this.MaTHTextBox.Size = new System.Drawing.Size(148, 22);
            this.MaTHTextBox.TabIndex = 19;
            // 
            // TenTHTextBox
            // 
            this.TenTHTextBox.Location = new System.Drawing.Point(165, 212);
            this.TenTHTextBox.Name = "TenTHTextBox";
            this.TenTHTextBox.Size = new System.Drawing.Size(184, 22);
            this.TenTHTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã thương hiệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên thương hiệu";
            // 
            // XoaButton
            // 
            this.XoaButton.Location = new System.Drawing.Point(290, 350);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(117, 39);
            this.XoaButton.TabIndex = 22;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // ThemSuaButton
            // 
            this.ThemSuaButton.Location = new System.Drawing.Point(167, 350);
            this.ThemSuaButton.Name = "ThemSuaButton";
            this.ThemSuaButton.Size = new System.Drawing.Size(117, 39);
            this.ThemSuaButton.TabIndex = 22;
            this.ThemSuaButton.Text = "Thêm / Sửa";
            this.ThemSuaButton.UseVisualStyleBackColor = true;
            this.ThemSuaButton.Click += new System.EventHandler(this.ThemSuaButton_Click);
            // 
            // TroLaiButton
            // 
            this.TroLaiButton.Location = new System.Drawing.Point(413, 350);
            this.TroLaiButton.Name = "TroLaiButton";
            this.TroLaiButton.Size = new System.Drawing.Size(117, 39);
            this.TroLaiButton.TabIndex = 22;
            this.TroLaiButton.Text = "Trờ Lại";
            this.TroLaiButton.UseVisualStyleBackColor = true;
            this.TroLaiButton.Click += new System.EventHandler(this.TroLaiButton_Click);
            // 
            // NhanHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.TroLaiButton);
            this.Controls.Add(this.ThemSuaButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenTHTextBox);
            this.Controls.Add(this.MaTHTextBox);
            this.Controls.Add(this.NhanHieuDataGirdView);
            this.Controls.Add(this.label1);
            this.Name = "NhanHieu";
            this.Text = "NhanHieu";
            this.Load += new System.EventHandler(this.NhanHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanHieuDataGirdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView NhanHieuDataGirdView;
        private System.Windows.Forms.TextBox MaTHTextBox;
        private System.Windows.Forms.TextBox TenTHTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ThemSuaButton;
        private System.Windows.Forms.Button TroLaiButton;
    }
}