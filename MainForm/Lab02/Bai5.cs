﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Lab02
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            InitializeListView();
        }
        private void InitializeListView()
        {
            listViewFiles.Columns.Add("Tên File", 200);
            listViewFiles.Columns.Add("Type", 100);
            listViewFiles.Columns.Add("Ngày Tạo", 150);
            listViewFiles.Columns.Add("Kích thước (KB)", 150);
        }

        private void labelPath_Click(object sender, EventArgs e)
        {

        }
        private List<string> directoryHistory = new List<string>();
        private string currentDirectory;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    if (currentDirectory != null)
                    {
                        directoryHistory.Add(currentDirectory); // Thêm đường dẫn hiện tại vào lịch sử
                    }

                    currentDirectory = folderBrowserDialog.SelectedPath; // Cập nhật thư mục hiện tại
                    txtPath.Text = currentDirectory; // Hiển thị đường dẫn
                    LoadFiles(currentDirectory); // Tải các tệp trong thư mục
                }
            }
        }
        private List<string> selectedFiles = new List<string>();
        private void LoadFiles(string directoryPath)
        {
            listViewFiles.Items.Clear();
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            // Lấy tất cả các thư mục trong thư mục
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo directory in directories)
            {
                ListViewItem item = new ListViewItem(directory.Name);
                item.SubItems.Add("Folder"); // Hiển thị là folder
                item.SubItems.Add(directory.LastWriteTime.ToString()); // Hiển thị ngày sửa đổi
                item.SubItems.Add(""); // Thư mục không có kích thước
                listViewFiles.Items.Add(item);
            }

            // Lấy tất cả các tệp trong thư mục
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add("File"); // Hiển thị là file
                item.SubItems.Add(file.LastWriteTime.ToString()); // Hiển thị ngày sửa đổi
                item.SubItems.Add((file.Length / 1024.0).ToString("F2") + " KB"); // Hiển thị kích thước tệp (tính bằng KB)
                listViewFiles.Items.Add(item);
            }
        }

        private void btbBack_Click(object sender, EventArgs e)
        {
            if (directoryHistory.Count > 0) // Kiểm tra nếu có đường dẫn trong lịch sử
            {
                currentDirectory = directoryHistory[directoryHistory.Count - 1]; // Lấy đường dẫn thư mục cha
                directoryHistory.RemoveAt(directoryHistory.Count - 1); // Xóa đường dẫn đó khỏi lịch sử
                txtPath.Text = currentDirectory; // Cập nhật TextBox
                LoadFiles(currentDirectory); // Tải lại các tệp trong thư mục cha
            }
            else
            {
                MessageBox.Show("Đã ở thư mục gốc, không còn thư mục cha để quay lại.");
            }
        }
        private void EnterDirectory(string newDirectory)
        {
            directoryHistory.Add(currentDirectory); // Lưu lại thư mục hiện tại vào lịch sử
            currentDirectory = newDirectory; // Cập nhật thư mục hiện tại
            txtPath.Text = currentDirectory; // Cập nhật TextBox với đường dẫn mới
            LoadFiles(currentDirectory); // Tải lại các tệp trong thư mục mới
        }
    }
}
