namespace DoAnCuoiKi
{
    partial class LoaiSanPham
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
            this.LoaiSanPhamDataGirdView = new System.Windows.Forms.DataGridView();
            this.MaDMTextBox = new System.Windows.Forms.TextBox();
            this.TenDMTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XoaButton = new System.Windows.Forms.Button();
            this.ThemSuaButton = new System.Windows.Forms.Button();
            this.TroLaiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiSanPhamDataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(233, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // LoaiSanPhamDataGirdView
            // 
            this.LoaiSanPhamDataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoaiSanPhamDataGirdView.Location = new System.Drawing.Point(413, 107);
            this.LoaiSanPhamDataGirdView.Name = "LoaiSanPhamDataGirdView";
            this.LoaiSanPhamDataGirdView.RowHeadersWidth = 51;
            this.LoaiSanPhamDataGirdView.RowTemplate.Height = 24;
            this.LoaiSanPhamDataGirdView.Size = new System.Drawing.Size(347, 230);
            this.LoaiSanPhamDataGirdView.TabIndex = 3;
            // 
            // MaDMTextBox
            // 
            this.MaDMTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaDMTextBox.Location = new System.Drawing.Point(166, 144);
            this.MaDMTextBox.Name = "MaDMTextBox";
            this.MaDMTextBox.Size = new System.Drawing.Size(207, 23);
            this.MaDMTextBox.TabIndex = 4;
            // 
            // TenDMTextBox
            // 
            this.TenDMTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDMTextBox.Location = new System.Drawing.Point(166, 193);
            this.TenDMTextBox.Name = "TenDMTextBox";
            this.TenDMTextBox.Size = new System.Drawing.Size(207, 23);
            this.TenDMTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã danh mục";
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(198, 236);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(105, 30);
            this.XoaButton.TabIndex = 7;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // ThemSuaButton
            // 
            this.ThemSuaButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemSuaButton.Location = new System.Drawing.Point(49, 236);
            this.ThemSuaButton.Name = "ThemSuaButton";
            this.ThemSuaButton.Size = new System.Drawing.Size(105, 30);
            this.ThemSuaButton.TabIndex = 7;
            this.ThemSuaButton.Text = "Thêm / Sửa";
            this.ThemSuaButton.UseVisualStyleBackColor = true;
            this.ThemSuaButton.Click += new System.EventHandler(this.ThemSuaButton_Click);
            // 
            // TroLaiButton
            // 
            this.TroLaiButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroLaiButton.Location = new System.Drawing.Point(281, 308);
            this.TroLaiButton.Name = "TroLaiButton";
            this.TroLaiButton.Size = new System.Drawing.Size(92, 29);
            this.TroLaiButton.TabIndex = 7;
            this.TroLaiButton.Text = "Trờ lại";
            this.TroLaiButton.UseVisualStyleBackColor = true;
            this.TroLaiButton.Click += new System.EventHandler(this.TroLaiButton_Click);
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.ThemSuaButton);
            this.Controls.Add(this.TroLaiButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenDMTextBox);
            this.Controls.Add(this.MaDMTextBox);
            this.Controls.Add(this.LoaiSanPhamDataGirdView);
            this.Controls.Add(this.label1);
            this.Name = "LoaiSanPham";
            this.Text = "Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoaiSanPhamDataGirdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LoaiSanPhamDataGirdView;
        private System.Windows.Forms.TextBox MaDMTextBox;
        private System.Windows.Forms.TextBox TenDMTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button ThemSuaButton;
        private System.Windows.Forms.Button TroLaiButton;
    }
}