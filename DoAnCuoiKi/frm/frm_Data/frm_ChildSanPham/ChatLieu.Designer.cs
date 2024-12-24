namespace DoAnCuoiKi
{
    partial class ChatLieu
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
            this.ChatLieuDataGridView = new System.Windows.Forms.DataGridView();
            this.MaCLTextBox = new System.Windows.Forms.TextBox();
            this.TenCLTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemSuaButton = new System.Windows.Forms.Button();
            this.TroLaiButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChatLieuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chất Liệu";
            // 
            // ChatLieuDataGridView
            // 
            this.ChatLieuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatLieuDataGridView.Location = new System.Drawing.Point(429, 106);
            this.ChatLieuDataGridView.Name = "ChatLieuDataGridView";
            this.ChatLieuDataGridView.RowHeadersWidth = 51;
            this.ChatLieuDataGridView.RowTemplate.Height = 24;
            this.ChatLieuDataGridView.Size = new System.Drawing.Size(337, 235);
            this.ChatLieuDataGridView.TabIndex = 3;
            // 
            // MaCLTextBox
            // 
            this.MaCLTextBox.Location = new System.Drawing.Point(139, 106);
            this.MaCLTextBox.Name = "MaCLTextBox";
            this.MaCLTextBox.Size = new System.Drawing.Size(123, 22);
            this.MaCLTextBox.TabIndex = 4;
            // 
            // TenCLTextBox
            // 
            this.TenCLTextBox.Location = new System.Drawing.Point(139, 180);
            this.TenCLTextBox.Name = "TenCLTextBox";
            this.TenCLTextBox.Size = new System.Drawing.Size(209, 22);
            this.TenCLTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã chất liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên chất liệu";
            // 
            // ThemSuaButton
            // 
            this.ThemSuaButton.Location = new System.Drawing.Point(139, 388);
            this.ThemSuaButton.Name = "ThemSuaButton";
            this.ThemSuaButton.Size = new System.Drawing.Size(100, 35);
            this.ThemSuaButton.TabIndex = 6;
            this.ThemSuaButton.Text = "Thêm / Sửa";
            this.ThemSuaButton.UseVisualStyleBackColor = true;
            this.ThemSuaButton.Click += new System.EventHandler(this.ThemSuaButton_Click);
            // 
            // TroLaiButton
            // 
            this.TroLaiButton.Location = new System.Drawing.Point(530, 388);
            this.TroLaiButton.Name = "TroLaiButton";
            this.TroLaiButton.Size = new System.Drawing.Size(103, 35);
            this.TroLaiButton.TabIndex = 6;
            this.TroLaiButton.Text = "Trở lại";
            this.TroLaiButton.UseVisualStyleBackColor = true;
            this.TroLaiButton.Click += new System.EventHandler(this.TroLaiButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Location = new System.Drawing.Point(334, 388);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(101, 35);
            this.XoaButton.TabIndex = 6;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.TroLaiButton);
            this.Controls.Add(this.ThemSuaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenCLTextBox);
            this.Controls.Add(this.MaCLTextBox);
            this.Controls.Add(this.ChatLieuDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ChatLieu";
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChatLieuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ChatLieuDataGridView;
        private System.Windows.Forms.TextBox MaCLTextBox;
        private System.Windows.Forms.TextBox TenCLTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ThemSuaButton;
        private System.Windows.Forms.Button TroLaiButton;
        private System.Windows.Forms.Button XoaButton;
    }
}