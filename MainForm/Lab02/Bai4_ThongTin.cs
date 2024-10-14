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
    public partial class Bai4_ThongTin : Form
    {
        public Bai4_ThongTin()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Lưu thông tin sinh viên";
            saveFileDialog.FileName = "input.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName; // Lấy đường dẫn file đã chọn

                // Lấy thông tin từ các TextBox
                string hoTen = textHT.Text.Trim();
                string mssv = textMSSV.Text.Trim();
                string dienThoai = textDT.Text.Trim();
                string diemToan = textToan.Text.Trim();
                string diemVan = textVan.Text.Trim();

                // Kiểm tra ký tự đặc biệt trong các trường
                

                // Kiểm tra MSSV (chỉ toàn số)
                if (!IsDigitsOnly(mssv))
                {
                    MessageBox.Show("Nhập sai định dạng MSSV, vui lòng nhập lại.");
                    return;
                }

                // Kiểm tra họ tên (không chứa số)
                if (ContainsDigits(hoTen))
                {
                    MessageBox.Show("Nhập sai định dạng tên, vui lòng nhập lại.");
                    return;
                }

                // Kiểm tra số điện thoại (phải có 10 số)
                if (!IsDigitsOnly(dienThoai) || dienThoai.Length != 10)
                {
                    MessageBox.Show("Nhập sai định dạng SDT, vui lòng nhập lại.");
                    return;
                }

                // Kiểm tra điểm Toán (phải là số từ 0.0 đến 10.0)
                if (!IsValidScore(diemToan))
                {
                    MessageBox.Show("Nhập sai định dạng điểm, vui lòng nhập lại.");
                    return;
                }

                // Kiểm tra điểm Văn (phải là số từ 0.0 đến 10.0)
                if (!IsValidScore(diemVan))
                {
                    MessageBox.Show("Nhập sai định dạng điểm, vui lòng nhập lại.");
                    return;
                }

                // Tất cả kiểm tra đều thành công, ghi dữ liệu vào file
                string line = $"{mssv};{hoTen};{dienThoai};{diemToan};{diemVan}";

                // Ghi vào file đã chỉ định
                File.AppendAllText(filePath, line + Environment.NewLine);

                MessageBox.Show("Đã lưu thông tin sinh viên!");
            }
        }
        // Hàm kiểm tra MSSV và số điện thoại (chỉ chứa số)
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }

        // Hàm kiểm tra họ tên (không chứa số)
        private bool ContainsDigits(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        // Hàm kiểm tra điểm (nằm trong khoảng 0.0 đến 10.0)
        private bool IsValidScore(string score)
        {
            if (double.TryParse(score, out double result))
            {
                return result >= 0.0 && result <= 10.0;
            }
            return false;
        }

        // Hàm kiểm tra ký tự đặc biệt
        private bool ContainsSpecialCharacters(string str)
        {
            foreach (char c in str)
            {
                // Nếu không phải chữ cái, số hoặc khoảng trắng thì là ký tự đặc biệt
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void Bai4_ThongTin_Load(object sender, EventArgs e)
        {

        }

        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            this.Close();
            Bai4_DuLieu bai4_dulieu = new Bai4_DuLieu();
            bai4_dulieu.ShowDialog();
        }
    }
}
