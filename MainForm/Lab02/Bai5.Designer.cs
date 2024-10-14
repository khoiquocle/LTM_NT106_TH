namespace Lab02
{
    partial class Bai5
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
            this.labelPath = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.btbBack = new Guna.UI2.WinForms.Guna2Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.BackColor = System.Drawing.Color.Transparent;
            this.labelPath.Location = new System.Drawing.Point(11, 15);
            this.labelPath.Margin = new System.Windows.Forms.Padding(2);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(28, 15);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path:";
            this.labelPath.Click += new System.EventHandler(this.labelPath_Click);
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
            this.txtPath.Location = new System.Drawing.Point(43, 9);
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PlaceholderText = "";
            this.txtPath.SelectedText = "";
            this.txtPath.Size = new System.Drawing.Size(341, 23);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(389, 9);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 21);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btbBack
            // 
            this.btbBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btbBack.ForeColor = System.Drawing.Color.White;
            this.btbBack.Location = new System.Drawing.Point(463, 9);
            this.btbBack.Margin = new System.Windows.Forms.Padding(2);
            this.btbBack.Name = "btbBack";
            this.btbBack.Size = new System.Drawing.Size(64, 21);
            this.btbBack.TabIndex = 3;
            this.btbBack.Text = "Back";
            this.btbBack.Click += new System.EventHandler(this.btbBack_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(-2, 50);
            this.listViewFiles.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(529, 240);
            this.listViewFiles.TabIndex = 4;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.btbBack);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.labelPath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai5";
            this.Text = "Duyet thu muc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel labelPath;
        private Guna.UI2.WinForms.Guna2TextBox txtPath;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2Button btbBack;
        private System.Windows.Forms.ListView listViewFiles;
    }
}