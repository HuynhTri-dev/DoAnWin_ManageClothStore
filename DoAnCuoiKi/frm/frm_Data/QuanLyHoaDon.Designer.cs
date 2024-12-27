namespace DoAnCuoiKi.frm.frm_Data
{
    partial class QuanLyHoaDon
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
            this.HoaDonAdvance = new Zuby.ADGV.AdvancedDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(113)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 99);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // HoaDonAdvance
            // 
            this.HoaDonAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoaDonAdvance.FilterAndSortEnabled = true;
            this.HoaDonAdvance.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.HoaDonAdvance.Location = new System.Drawing.Point(23, 123);
            this.HoaDonAdvance.MaxFilterButtonImageHeight = 23;
            this.HoaDonAdvance.Name = "HoaDonAdvance";
            this.HoaDonAdvance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HoaDonAdvance.RowHeadersWidth = 51;
            this.HoaDonAdvance.RowTemplate.Height = 24;
            this.HoaDonAdvance.Size = new System.Drawing.Size(703, 555);
            this.HoaDonAdvance.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.HoaDonAdvance.TabIndex = 7;
            this.HoaDonAdvance.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.HoaDonAdvance_FilterStringChanged);
            this.HoaDonAdvance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoaDonAdvance_CellContentClick);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.HoaDonAdvance);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHoaDon";
            this.Text = "QuanLyHoaDon";
            this.Load += new System.EventHandler(this.QuanLyHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonAdvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Zuby.ADGV.AdvancedDataGridView HoaDonAdvance;
    }
}