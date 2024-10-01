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
                try
                {
                    var result = new System.Data.DataTable().Compute(line, null);
                    txtResult.AppendText($"{line} = {result}\r\n");
                }
                catch (Exception ex)
                {
                    txtResult.AppendText($"Lỗi khi tính: {line}\r\n");
                }
            }
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
