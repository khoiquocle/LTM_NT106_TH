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
    public partial class Bai4_DuLieu : Form
    {
        public Bai4_DuLieu()
        {
            InitializeComponent();
        }

        

        private void Bai4_DuLieu_Load(object sender, EventArgs e)
        {
            Data.Columns.Add("MSSV", "MSSV");
            Data.Columns.Add("HoTen", "Họ Tên");
            Data.Columns.Add("DienThoai", "Điện Thoại");
            Data.Columns.Add("DiemToan", "Điểm Toán");
            Data.Columns.Add("DiemVan", "Điểm Văn");
            Data.Columns.Add("DTB", "Điểm Trung Bình");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files|*.txt",
                Title = "Chọn file dữ liệu"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đọc tất cả các dòng từ file được chọn
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                // Xóa dữ liệu cũ trong DataGridView (nếu cần)
                Data.Rows.Clear();

                foreach (string line in lines)
                {
                    // Tách các phần từ mỗi dòng
                    string[] parts = line.Split(';');

                    if (parts.Length < 5) // Kiểm tra số lượng phần từ
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ trong dòng: " + line);
                        continue; // Bỏ qua dòng không hợp lệ
                    }

                    string mssv = parts[0];
                    string hoTen = parts[1];
                    string dienThoai = parts[2];
                    double diemToan = double.Parse(parts[3]);
                    double diemVan = double.Parse(parts[4]);

                    if (!double.TryParse(parts[3], out diemToan))
                    {
                        MessageBox.Show("Điểm Toán không hợp lệ trong dòng: " + line);
                        continue; // Bỏ qua dòng không hợp lệ
                    }

                    if (!double.TryParse(parts[4], out diemVan))
                    {
                        MessageBox.Show("Điểm Văn không hợp lệ trong dòng: " + line);
                        continue; // Bỏ qua dòng không hợp lệ
                    }

                    double dtb = (diemToan + diemVan) / 2;

                    // Thêm dữ liệu vào DataGridView
                    Data.Rows.Add(mssv, hoTen, dienThoai, diemToan, diemVan, dtb);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
