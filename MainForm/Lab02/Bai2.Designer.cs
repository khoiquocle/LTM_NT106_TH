﻿namespace Lab02
{
    partial class Bai2
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
            this.btn_ReadFile = new Guna.UI2.WinForms.Guna2Button();
            this.labelTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelUrl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelSodong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelSokytu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelSoTu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWordCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLineCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCharCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ReadFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ReadFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ReadFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ReadFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadFile.ForeColor = System.Drawing.Color.White;
            this.btn_ReadFile.Location = new System.Drawing.Point(31, 11);
            this.btn_ReadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(184, 48);
            this.btn_ReadFile.TabIndex = 0;
            this.btn_ReadFile.Text = "ĐỌC FILE";
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadFiles);
            // 
            // labelTen
            // 
            this.labelTen.BackColor = System.Drawing.Color.Transparent;
            this.labelTen.Location = new System.Drawing.Point(20, 92);
            this.labelTen.Margin = new System.Windows.Forms.Padding(2);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(38, 15);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Tên file";
            this.labelTen.Click += new System.EventHandler(this.labelTen_Click_1);
            // 
            // labelUrl
            // 
            this.labelUrl.BackColor = System.Drawing.Color.Transparent;
            this.labelUrl.Location = new System.Drawing.Point(20, 129);
            this.labelUrl.Margin = new System.Windows.Forms.Padding(2);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(25, 15);
            this.labelUrl.TabIndex = 2;
            this.labelUrl.Text = "URL";
            this.labelUrl.Click += new System.EventHandler(this.labelUrl_Click);
            // 
            // labelSodong
            // 
            this.labelSodong.BackColor = System.Drawing.Color.Transparent;
            this.labelSodong.Location = new System.Drawing.Point(20, 209);
            this.labelSodong.Margin = new System.Windows.Forms.Padding(2);
            this.labelSodong.Name = "labelSodong";
            this.labelSodong.Size = new System.Drawing.Size(43, 15);
            this.labelSodong.TabIndex = 3;
            this.labelSodong.Text = "Số dòng";
            this.labelSodong.Click += new System.EventHandler(this.labelSodong_Click);
            // 
            // labelSokytu
            // 
            this.labelSokytu.BackColor = System.Drawing.Color.Transparent;
            this.labelSokytu.Location = new System.Drawing.Point(20, 247);
            this.labelSokytu.Margin = new System.Windows.Forms.Padding(2);
            this.labelSokytu.Name = "labelSokytu";
            this.labelSokytu.Size = new System.Drawing.Size(42, 15);
            this.labelSokytu.TabIndex = 4;
            this.labelSokytu.Text = "Số ký tự";
            this.labelSokytu.Click += new System.EventHandler(this.labelSokytu_Click);
            // 
            // labelSoTu
            // 
            this.labelSoTu.BackColor = System.Drawing.Color.Transparent;
            this.labelSoTu.Location = new System.Drawing.Point(20, 168);
            this.labelSoTu.Margin = new System.Windows.Forms.Padding(2);
            this.labelSoTu.Name = "labelSoTu";
            this.labelSoTu.Size = new System.Drawing.Size(28, 15);
            this.labelSoTu.TabIndex = 5;
            this.labelSoTu.Text = "Số từ";
            // 
            // txtFileName
            // 
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.DefaultText = "";
            this.txtFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFileName.Location = new System.Drawing.Point(86, 89);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.PlaceholderText = "";
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(129, 17);
            this.txtFileName.TabIndex = 6;
            // 
            // txtPath
            // 
            this.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPath.DefaultText = "";
            this.txtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPath.Location = new System.Drawing.Point(86, 127);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(129, 17);
            this.txtPath.TabIndex = 7;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWordCount.DefaultText = "";
            this.txtWordCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWordCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWordCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWordCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWordCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWordCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWordCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWordCount.Location = new System.Drawing.Point(87, 166);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.PasswordChar = '\0';
            this.txtWordCount.PlaceholderText = "";
            this.txtWordCount.SelectedText = "";
            this.txtWordCount.Size = new System.Drawing.Size(129, 17);
            this.txtWordCount.TabIndex = 8;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLineCount.DefaultText = "";
            this.txtLineCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLineCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLineCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLineCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLineCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLineCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLineCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLineCount.Location = new System.Drawing.Point(87, 209);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.PasswordChar = '\0';
            this.txtLineCount.PlaceholderText = "";
            this.txtLineCount.SelectedText = "";
            this.txtLineCount.Size = new System.Drawing.Size(129, 17);
            this.txtLineCount.TabIndex = 9;
            this.txtLineCount.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // txtCharCount
            // 
            this.txtCharCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCharCount.DefaultText = "";
            this.txtCharCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCharCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCharCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCharCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCharCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCharCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCharCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCharCount.Location = new System.Drawing.Point(86, 245);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.PasswordChar = '\0';
            this.txtCharCount.PlaceholderText = "";
            this.txtCharCount.SelectedText = "";
            this.txtCharCount.Size = new System.Drawing.Size(129, 17);
            this.txtCharCount.TabIndex = 10;
            // 
            // txtContent
            // 
            this.txtContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContent.DefaultText = "";
            this.txtContent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContent.Location = new System.Drawing.Point(232, 10);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.PlaceholderText = "";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.SelectedText = "";
            this.txtContent.Size = new System.Drawing.Size(289, 270);
            this.txtContent.TabIndex = 11;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.labelSoTu);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.labelSokytu);
            this.Controls.Add(this.labelSodong);
            this.Controls.Add(this.btn_ReadFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai2";
            this.Text = "Bai 2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_ReadFile;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelUrl;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSodong;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSokytu;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSoTu;
        private Guna.UI2.WinForms.Guna2TextBox txtFileName;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2TextBox txtWordCount;
        private Guna.UI2.WinForms.Guna2TextBox txtLineCount;
        private Guna.UI2.WinForms.Guna2TextBox txtCharCount;
        private Guna.UI2.WinForms.Guna2TextBox txtContent;
    }
}