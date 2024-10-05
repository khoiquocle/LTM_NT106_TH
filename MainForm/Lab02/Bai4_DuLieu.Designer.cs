namespace Lab02
{
    partial class Bai4_DuLieu
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
            this.btn_Nhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienThi = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Nhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Nhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Nhap.ForeColor = System.Drawing.Color.White;
            this.btn_Nhap.Location = new System.Drawing.Point(21, 59);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(144, 44);
            this.btn_Nhap.TabIndex = 1;
            this.btn_Nhap.Text = "Nhập dữ liệu ";
            this.btn_Nhap.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(21, 167);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 44);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(21, 278);
            this.btnHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(144, 44);
            this.btnHienThi.TabIndex = 3;
            this.btnHienThi.Text = "Hiển thị thông tin ";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 372);
            this.dataGridView1.TabIndex = 4;
            // 
            // Bai4_DuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btn_Nhap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai4_DuLieu";
            this.Text = "Dữ liệu sinh viên";
            this.Load += new System.EventHandler(this.Bai4_DuLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Nhap;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHienThi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}