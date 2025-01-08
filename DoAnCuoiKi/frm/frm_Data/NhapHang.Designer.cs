namespace DoAnCuoiKi.frm.frm_Data
{
    partial class NhapHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NhapHangButton = new System.Windows.Forms.Button();
            this.MaSPText = new System.Windows.Forms.TextBox();
            this.SoLuongNhapText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TenSPText = new System.Windows.Forms.TextBox();
            this.TenNCCText = new System.Windows.Forms.TextBox();
            this.DongButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 79);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP:";
            // 
            // NhapHangButton
            // 
            this.NhapHangButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapHangButton.Location = new System.Drawing.Point(172, 269);
            this.NhapHangButton.Name = "NhapHangButton";
            this.NhapHangButton.Size = new System.Drawing.Size(114, 40);
            this.NhapHangButton.TabIndex = 2;
            this.NhapHangButton.Text = "Nhập hàng";
            this.NhapHangButton.UseVisualStyleBackColor = true;
            this.NhapHangButton.Click += new System.EventHandler(this.NhapHangButton_Click);
            // 
            // MaSPText
            // 
            this.MaSPText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSPText.Location = new System.Drawing.Point(172, 106);
            this.MaSPText.Name = "MaSPText";
            this.MaSPText.Size = new System.Drawing.Size(292, 28);
            this.MaSPText.TabIndex = 0;
            this.MaSPText.TextChanged += new System.EventHandler(this.MaSPText_TextChanged);
            // 
            // SoLuongNhapText
            // 
            this.SoLuongNhapText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongNhapText.Location = new System.Drawing.Point(172, 175);
            this.SoLuongNhapText.Name = "SoLuongNhapText";
            this.SoLuongNhapText.Size = new System.Drawing.Size(292, 28);
            this.SoLuongNhapText.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên NCC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // TenSPText
            // 
            this.TenSPText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenSPText.Location = new System.Drawing.Point(172, 141);
            this.TenSPText.Name = "TenSPText";
            this.TenSPText.ReadOnly = true;
            this.TenSPText.Size = new System.Drawing.Size(292, 28);
            this.TenSPText.TabIndex = 9;
            // 
            // TenNCCText
            // 
            this.TenNCCText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNCCText.Location = new System.Drawing.Point(172, 211);
            this.TenNCCText.Name = "TenNCCText";
            this.TenNCCText.ReadOnly = true;
            this.TenNCCText.Size = new System.Drawing.Size(292, 28);
            this.TenNCCText.TabIndex = 10;
            // 
            // DongButton
            // 
            this.DongButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DongButton.Location = new System.Drawing.Point(370, 269);
            this.DongButton.Name = "DongButton";
            this.DongButton.Size = new System.Drawing.Size(94, 40);
            this.DongButton.TabIndex = 3;
            this.DongButton.Text = "Đóng";
            this.DongButton.UseVisualStyleBackColor = true;
            this.DongButton.Click += new System.EventHandler(this.DongButton_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 336);
            this.Controls.Add(this.DongButton);
            this.Controls.Add(this.TenNCCText);
            this.Controls.Add(this.TenSPText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SoLuongNhapText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaSPText);
            this.Controls.Add(this.NhapHangButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "NhapHang";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NhapHangButton;
        private System.Windows.Forms.TextBox MaSPText;
        private System.Windows.Forms.TextBox SoLuongNhapText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TenSPText;
        private System.Windows.Forms.TextBox TenNCCText;
        private System.Windows.Forms.Button DongButton;
    }
}