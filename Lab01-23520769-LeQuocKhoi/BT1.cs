using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Lab01_23520769_LeQuocKhoi
{
	public partial class BT1 : Form
	{
		public BT1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			this.label1.ForeColor = System.Drawing.Color.Red;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void BT1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			foreach (Control control in this.Controls)
			{
				// Kiểm tra xem control có phải là TextBox hay không
				if (control is TextBox textBox)
				{
					textBox.Clear();
				}
			}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)	// phép cộng
		{
			// Sử dụng cách TryParse như cô luôn thường nói
			// 2 số hạng là kiểu int
			// Để tránh việc cộng lại ra một số lớn hơn KDL nên sẽ khai báo tổng là kiểu long ( ép kiểu 2 biến khi tính )
			int num1, num2;
			bool s1 = Int32.TryParse(textBox1.Text.Trim(), out num1);
			bool s2 = Int32.TryParse(textBox2.Text.Trim(), out num2);
			if (s1 && s2)
			{
				long sum = (long)num1 + (long)num2;
				textBox3.Text = sum.ToString();
			}
			else
			{
				MessageBox.Show("Vui long nhap so nguyen.",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Cách làm giống như phép cộng
			// Khai báo hiệu là kiểu long để tránh tràn số khi trừ 2 số khác dấu
			int num1, num2;
			long sum = 0;
			bool s1 = Int32.TryParse(textBox1.Text.Trim(), out num1);
			bool s2 = Int32.TryParse(textBox2.Text.Trim(), out num2);
			if (s1 && s2)
			{
				 sum = (long)num1 - (long)num2;
				textBox3.Text = sum.ToString();
			}
			else
			{
				MessageBox.Show("Vui long nhap so nguyen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Cách làm vẫn giống như trên
			// Khai báo product là kiểu long
			int num1, num2;
		   long product = 0;
			bool s1 = Int32.TryParse(textBox1.Text.Trim(), out num1);
			bool s2 = Int32.TryParse(textBox2.Text.Trim(), out num2);
			if (s1 && s2)
			{
				product = (long)num1 * (long)num2;
				textBox3.Text = product.ToString();
			}
			else
			{
				MessageBox.Show("Vui long nhap so nguyen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Cách làm tương tự
			// Khai báo thương là kiểu double và ép kiểu khi tính
			int num1, num2;
			double quotient = 0;
			bool s1 = Int32.TryParse(textBox1.Text.Trim(), out num1);
			bool s2 = Int32.TryParse(textBox2.Text.Trim(), out num2);
			if (s1 && s2)
			{
				quotient = (double)num1 / (double)num2;
				textBox3.Text = quotient.ToString();
			}
			else
			{
				MessageBox.Show("Vui long nhap so nguyen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
