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

                // Ghi thông tin sinh viên vào file
                string hoTen = textHT.Text;
                string mssv = textMSSV.Text;
                string dienThoai = textDT.Text;
                string diemToan = textToan.Text;
                string diemVan = textVan.Text;

                string line = $"{mssv};{hoTen};{dienThoai};{diemToan};{diemVan}";

                // Ghi vào file đã chỉ định
                File.AppendAllText(filePath, line + Environment.NewLine);

                MessageBox.Show("Đã lưu thông tin sinh viên!");
            }
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
