using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
namespace Lab02
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All file (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                string filePath = openFileDialog.FileName;
                string content = File.ReadAllText(filePath);
                txtExpression.Text = content;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            string[] lines = txtExpression.Lines;
            foreach (string line in lines)
            {
                // Kiểm tra nếu dòng rỗng
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue; // Bỏ qua dòng trống
                }

                // Kiểm tra nếu biểu thức chứa ký tự không hợp lệ
                if (!IsValidExpression(line))
                {
                    MessageBox.Show("Vui lòng nhập biểu thức toán học hợp lệ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue; // Bỏ qua dòng không hợp lệ
                }

                try
                {
                    // Kiểm tra nếu biểu thức chứa phép chia cho 0
                    if (line.Contains("/0"))
                    {
                        txtResult.AppendText($"Không thể chia cho 0 trong biểu thức: {line}\r\n");
                    }
                    else
                    {
                        // Tính toán nếu không có phép chia cho 0
                        var result = new System.Data.DataTable().Compute(line, null);
                        txtResult.AppendText($"{line} = {result}\r\n");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ khi có lỗi trong quá trình tính toán
                    txtResult.AppendText($"Lỗi khi tính: {line}\r\n");
                }
            }

            
        }
        // Phương thức kiểm tra tính hợp lệ của biểu thức toán học
        private bool IsValidExpression(string expression)
        {
            // Kiểm tra xem biểu thức chỉ chứa các ký tự số, toán tử, và dấu ngoặc
            return Regex.IsMatch(expression, @"^[0-9+\-*/().\s]+$");
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All file (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtResult.Text);
                MessageBox.Show("Kết quả đã được lưu!", "Thông báo");
            }
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
