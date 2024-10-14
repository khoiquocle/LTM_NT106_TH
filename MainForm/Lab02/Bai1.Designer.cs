namespace Lab02
{
    partial class Bai1
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
            this.btn_Read = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Write = new Guna.UI2.WinForms.Guna2Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btn_Read.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Read.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Read.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Read.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Read.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.White;
            this.btn_Read.Location = new System.Drawing.Point(93, 320);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(143, 53);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "ĐỌC FILE";
            this.btn_Read.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.btn_Read.Click += new System.EventHandler(this.btn_ReadFile);
            // 
            // btn_Write
            // 
            this.btn_Write.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Write.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Write.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Write.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Write.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Write.ForeColor = System.Drawing.Color.White;
            this.btn_Write.Location = new System.Drawing.Point(325, 320);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(137, 53);
            this.btn_Write.TabIndex = 1;
            this.btn_Write.Text = "GHI FILE";
            this.btn_Write.Click += new System.EventHandler(this.btn_WriteFiles);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(534, 290);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 396);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Read);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai1";
            this.Text = "Bai 1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Read;
        private Guna.UI2.WinForms.Guna2Button btn_Write;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}