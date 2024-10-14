namespace Lab02
{
    partial class Bai3
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
            Guna.UI2.WinForms.Guna2Button btnWrite;
            this.btnOpenFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.txtExpression = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            btnWrite = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(9, 232);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(109, 49);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Chọn file";
            this.btnOpenFile.TextFormatNoPrefix = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(149, 232);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 49);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Tính";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnWrite
            // 
            btnWrite.Animated = true;
            btnWrite.AnimatedGIF = true;
            btnWrite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            btnWrite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            btnWrite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            btnWrite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            btnWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnWrite.ForeColor = System.Drawing.Color.White;
            btnWrite.Location = new System.Drawing.Point(283, 232);
            btnWrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new System.Drawing.Size(102, 49);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Ghi";
            btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpression.DefaultText = "";
            this.txtExpression.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtExpression.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtExpression.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpression.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtExpression.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExpression.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpression.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtExpression.Location = new System.Drawing.Point(9, 12);
            this.txtExpression.Multiline = true;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.PasswordChar = '\0';
            this.txtExpression.PlaceholderText = "";
            this.txtExpression.SelectedText = "";
            this.txtExpression.Size = new System.Drawing.Size(253, 199);
            this.txtExpression.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.DefaultText = "";
            this.txtResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResult.Location = new System.Drawing.Point(269, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.PlaceholderText = "";
            this.txtResult.SelectedText = "";
            this.txtResult.Size = new System.Drawing.Size(253, 199);
            this.txtResult.TabIndex = 4;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(420, 232);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 49);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(btnWrite);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnOpenFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bai3";
            this.Text = "Bai 3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnOpenFile;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2TextBox txtExpression;
        private Guna.UI2.WinForms.Guna2TextBox txtResult;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}