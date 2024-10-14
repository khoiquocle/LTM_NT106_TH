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

namespace Lab02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_ReadFiles(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Chọn file văn bản"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Đọc nội dung file
                string content = File.ReadAllText(filePath);

                // Kiểm tra nếu file rỗng
                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("File bạn chọn bị rỗng. Vui lòng chọn file khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Kết thúc hàm nếu file rỗng
                }

                // Nếu file không rỗng, hiển thị thông tin như bình thường
                txtFileName.Text = Path.GetFileName(filePath);
                txtPath.Text = Path.GetDirectoryName(filePath);

                txtContent.Text = content;

                int lineCount = content.Count(c => c == '\n') + 1;
                int wordCount = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int charCount = content.Length;

                txtLineCount.Text = lineCount.ToString();
                txtWordCount.Text = wordCount.ToString();
                txtCharCount.Text = charCount.ToString();
            }
        }

        private void labelSodong_Click(object sender, EventArgs e)
        {

        }

        private void labelSokytu_Click(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void labelTen_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUrl_Click(object sender, EventArgs e)
        {

        }
    }
}
