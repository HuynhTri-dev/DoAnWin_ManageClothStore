namespace DoAnCuoiKi
{
    partial class Mau
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
            this.MauDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TenMauTextBox = new System.Windows.Forms.TextBox();
            this.ThemSuaButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.TroLaiButton = new System.Windows.Forms.Button();
            this.MaMauTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MauDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MauDataGridView
            // 
            this.MauDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MauDataGridView.Location = new System.Drawing.Point(272, 88);
            this.MauDataGridView.Name = "MauDataGridView";
            this.MauDataGridView.RowHeadersWidth = 51;
            this.MauDataGridView.RowTemplate.Height = 24;
            this.MauDataGridView.Size = new System.Drawing.Size(337, 207);
            this.MauDataGridView.TabIndex = 0;
            this.MauDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MauDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Màu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã màu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên màu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TenMauTextBox
            // 
            this.TenMauTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMauTextBox.Location = new System.Drawing.Point(97, 143);
            this.TenMauTextBox.Name = "TenMauTextBox";
            this.TenMauTextBox.Size = new System.Drawing.Size(151, 23);
            this.TenMauTextBox.TabIndex = 5;
            this.TenMauTextBox.TextChanged += new System.EventHandler(this.TenMauTextBox_TextChanged);
            // 
            // ThemSuaButton
            // 
            this.ThemSuaButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemSuaButton.Location = new System.Drawing.Point(23, 202);
            this.ThemSuaButton.Name = "ThemSuaButton";
            this.ThemSuaButton.Size = new System.Drawing.Size(99, 32);
            this.ThemSuaButton.TabIndex = 6;
            this.ThemSuaButton.Text = "Thêm / Sửa";
            this.ThemSuaButton.UseVisualStyleBackColor = true;
            this.ThemSuaButton.Click += new System.EventHandler(this.ThemSuaButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaButton.Location = new System.Drawing.Point(149, 202);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(99, 32);
            this.XoaButton.TabIndex = 6;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // TroLaiButton
            // 
            this.TroLaiButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroLaiButton.Location = new System.Drawing.Point(147, 264);
            this.TroLaiButton.Name = "TroLaiButton";
            this.TroLaiButton.Size = new System.Drawing.Size(101, 31);
            this.TroLaiButton.TabIndex = 7;
            this.TroLaiButton.Text = "Trở lại";
            this.TroLaiButton.UseVisualStyleBackColor = true;
            this.TroLaiButton.Click += new System.EventHandler(this.TroLaiButton_Click);
            // 
            // MaMauTextBox
            // 
            this.MaMauTextBox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaMauTextBox.Location = new System.Drawing.Point(97, 106);
            this.MaMauTextBox.Name = "MaMauTextBox";
            this.MaMauTextBox.Size = new System.Drawing.Size(151, 23);
            this.MaMauTextBox.TabIndex = 8;
            this.MaMauTextBox.TextChanged += new System.EventHandler(this.MaMauTextBox_TextChanged);
            // 
            // Mau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 324);
            this.Controls.Add(this.MaMauTextBox);
            this.Controls.Add(this.TroLaiButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.ThemSuaButton);
            this.Controls.Add(this.TenMauTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MauDataGridView);
            this.Name = "Mau";
            this.Text = "Mau";
            this.Load += new System.EventHandler(this.Mau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MauDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MauDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenMauTextBox;
        private System.Windows.Forms.Button ThemSuaButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button TroLaiButton;
        private System.Windows.Forms.TextBox MaMauTextBox;
    }
}