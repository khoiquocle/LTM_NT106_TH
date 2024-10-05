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
using OfficeOpenXml;
using OfficeOpenXml.Style;
using LicenseContext = OfficeOpenXml.LicenseContext;

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
            dataGridView1.Columns.Add("MSSV", "MSSV");
            dataGridView1.Columns.Add("HoTen", "Họ Tên");
            dataGridView1.Columns.Add("DienThoai", "Điện Thoại");
            dataGridView1.Columns.Add("DiemToan", "Điểm Toán");
            dataGridView1.Columns.Add("DiemVan", "Điểm Văn");
            dataGridView1.Columns.Add("DTB", "Điểm Trung Bình");
        }

            private void guna2Button1_Click(object sender, EventArgs e)
            {
            
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Lưu thông tin sinh viên";
                saveFileDialog.FileName = "input.txt";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string mssv = row.Cells["MSSV"].Value?.ToString().Trim();
                            string hoTen = row.Cells["HoTen"].Value?.ToString().Trim();
                            string dienThoai = row.Cells["DienThoai"].Value?.ToString().Trim();
                            string diemToan = row.Cells["DiemToan"].Value?.ToString().Trim();
                            string diemVan = row.Cells["DiemVan"].Value?.ToString().Trim();
                            string dtb = row.Cells["DTB"].Value?.ToString().Trim();

                            // Kiểm tra nếu cột MSSV, Họ Tên, Điện Thoại, Điểm Toán, Điểm Văn bị bỏ trống
                            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoTen) ||
                                string.IsNullOrEmpty(dienThoai) || string.IsNullOrEmpty(diemToan) || string.IsNullOrEmpty(diemVan))
                            {
                                MessageBox.Show($"Dữ liệu chưa được nhập đầy đủ ở dòng {row.Index + 1}, vui lòng kiểm tra lại.", "Lỗi nhập liệu");
                                continue; // Bỏ qua dòng này nếu có cột trống
                            }

                            // Kiểm tra MSSV (chỉ toàn số)
                            if (!IsDigitsOnly(mssv))
                            {
                                MessageBox.Show($"Nhập sai định dạng MSSV ở dòng {row.Index + 1}, vui lòng nhập lại.");
                                continue;
                            }

                            // Kiểm tra họ tên (không chứa số)
                            if (ContainsDigits(hoTen))
                            {
                                MessageBox.Show($"Nhập sai định dạng tên ở dòng {row.Index + 1}, vui lòng nhập lại.");
                                continue;
                            }

                            // Kiểm tra số điện thoại (phải có 10 số)
                            if (!IsDigitsOnly(dienThoai) || dienThoai.Length != 10)
                            {
                                MessageBox.Show($"Nhập sai định dạng SDT ở dòng {row.Index + 1}, vui lòng nhập lại.");
                                continue;
                            }

                            // Kiểm tra điểm Toán (phải là số từ 0.0 đến 10.0)
                            if (!IsValidScore(diemToan))
                            {
                                MessageBox.Show($"Nhập sai định dạng điểm Toán ở dòng {row.Index + 1}, vui lòng nhập lại.");
                                continue;
                            }

                            // Kiểm tra điểm Văn (phải là số từ 0.0 đến 10.0)
                            if (!IsValidScore(diemVan))
                            {
                                MessageBox.Show($"Nhập sai định dạng điểm Văn ở dòng {row.Index + 1}, vui lòng nhập lại.");
                                continue;
                            }

                            // Nếu tất cả kiểm tra đều hợp lệ, ghi dòng dữ liệu vào file
                            string line = $"{mssv};{hoTen};{dienThoai};{diemToan};{diemVan}";
                            writer.WriteLine(line);
                        }
                    }
                }

            }
        }

        // Hàm kiểm tra chỉ chứa số
        private bool IsDigitsOnly(string str)
        {
            return str.All(char.IsDigit);
        }

        // Hàm kiểm tra chứa ký tự số
        private bool ContainsDigits(string str)
        {
            return str.Any(char.IsDigit);
        }

        // Hàm kiểm tra điểm hợp lệ (từ 0.0 đến 10.0)
        private bool IsValidScore(string str)
        {
            if (double.TryParse(str, out double score))
            {
                return score >= 0.0 && score <= 10.0;
            }
            return false;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại để người dùng chọn file Excel
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx|All files (*.*)|*.*",
                Title = "Chọn file Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Kiểm tra nếu file tồn tại
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file Excel.");
                    return;
                }

                // Đọc dữ liệu từ file Excel
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0]; // Lấy sheet đầu tiên

                    // Xóa dữ liệu cũ trong DataGridView
                    dataGridView1.Rows.Clear();

                    // Duyệt qua các dòng trong sheet và thêm vào DataGridView
                    int rowCount = worksheet.Dimension.Rows; // Số lượng dòng trong sheet
                    for (int row = 2; row <= rowCount; row++) // Bắt đầu từ dòng 2 để bỏ qua tiêu đề
                    {
                        // Đọc từng cột trong dòng
                        string mssv = worksheet.Cells[row, 1].Value?.ToString();
                        string hoTen = worksheet.Cells[row, 2].Value?.ToString();
                        string dienThoai = worksheet.Cells[row, 3].Value?.ToString();
                        double diemToan = double.Parse(worksheet.Cells[row, 4].Value?.ToString());
                        double diemVan = double.Parse(worksheet.Cells[row, 5].Value?.ToString());
                        double dtb = double.Parse(worksheet.Cells[row, 6].Value?.ToString());

                        // Thêm dòng dữ liệu vào DataGridView
                        dataGridView1.Rows.Add(mssv, hoTen, dienThoai, diemToan, diemVan, dtb);
                    }
                }

                MessageBox.Show("Dữ liệu đã được tải lên thành công.");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file Excel.");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại để người dùng chọn file input
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Chọn file input"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file input.txt");
                    return;
                }

                // Tạo một danh sách để chứa thông tin sinh viên
                List<string[]> sinhVienData = new List<string[]>();

                // Đọc dữ liệu từ file input.txt
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 5)
                    {
                        sinhVienData.Add(parts);
                    }
                }

                // Kiểm tra nếu không có dữ liệu
                if (sinhVienData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu sinh viên trong file input.txt");
                    return;
                }

                // Mở hộp thoại để lưu file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu dữ liệu sinh viên ra file Excel",
                    FileName = "output.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = saveFileDialog.FileName;

                    // Thiết lập chế độ cấp phép của EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    // Sử dụng thư viện EPPlus để tạo file Excel
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Tạo sheet mới
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("SinhVien");

                        // Thêm tiêu đề các cột
                        worksheet.Cells[1, 1].Value = "MSSV";
                        worksheet.Cells[1, 2].Value = "Họ Tên";
                        worksheet.Cells[1, 3].Value = "Điện Thoại";
                        worksheet.Cells[1, 4].Value = "Điểm Toán";
                        worksheet.Cells[1, 5].Value = "Điểm Văn";
                        worksheet.Cells[1, 6].Value = "Điểm Trung Bình";

                        // Duyệt qua danh sách sinh viên, tính điểm trung bình và ghi vào Excel
                        int row = 2;
                        foreach (string[] sv in sinhVienData)
                        {
                            string mssv = sv[0];
                            string hoTen = sv[1];
                            string dienThoai = sv[2];
                            double diemToan = double.Parse(sv[3]);
                            double diemVan = double.Parse(sv[4]);
                            double dtb = (diemToan + diemVan) / 2;

                            worksheet.Cells[row, 1].Value = mssv;
                            worksheet.Cells[row, 2].Value = hoTen;
                            worksheet.Cells[row, 3].Value = dienThoai;
                            worksheet.Cells[row, 4].Value = diemToan;
                            worksheet.Cells[row, 5].Value = diemVan;
                            worksheet.Cells[row, 6].Value = dtb;

                            row++;
                        }

                        // Lưu file Excel
                        File.WriteAllBytes(outputPath, excelPackage.GetAsByteArray());
                    }

                    MessageBox.Show("Đã lưu dữ liệu sinh viên vào file Excel!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file input.");
            }
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
