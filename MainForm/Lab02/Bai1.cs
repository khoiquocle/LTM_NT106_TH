using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bai1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        string content;
        byte[] bytes;
        public Bai1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Đặt bộ lọc để chỉ cho phép chọn file văn bản (.txt)
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Hiển thị hộp thoại mở file
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Mở file đã chọn và đọc nội dung
                using (StreamReader str = new StreamReader(ofd.FileName))
                {
                    string content = str.ReadToEnd();

                    // Kiểm tra nếu file rỗng
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        MessageBox.Show("File bạn chọn bị rỗng. Vui lòng chọn file khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Kết thúc hàm nếu file rỗng
                    }

                    // Hiển thị nội dung trong TextBox
                    richTextBox1.Text = content;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            // Thiết lập bộ lọc cho các loại file
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // Hiển thị hộp thoại SaveFileDialog
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file mà người dùng đã chọn
                string filePath = sfd.FileName;

                // Kiểm tra nếu file đã tồn tại, thông báo rằng nó sẽ ghi đè
                if (File.Exists(filePath))
                {
                    DialogResult result = MessageBox.Show("File đã tồn tại. Bạn có muốn ghi đè không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                // Lấy nội dung từ TextBox, chuyển sang in hoa
                string content = richTextBox1.Text.ToUpper();

                // Ghi nội dung vào file
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(content);
                sw.Close();

                MessageBox.Show("File đã được lưu thành công!");
            }
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
