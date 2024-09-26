using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_23520769_LeQuocKhoi
{
	public partial class BT3 : Form
	{
		public BT3()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void BT3_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				// Lấy số từ TextBox1
				long number = long.Parse(textBox1.Text);
				// Kiểm tra giới hạn 12 chữ số
				if (textBox1.Text.Length > 12)
				{
					MessageBox.Show("Vui lòng nhập 1 số nguyên không quá 12 chữ số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Gọi hàm chuyển đổi số thành chữ và hiển thị kết quả
				textBox2.Text = ConvertNumberToWords(number);
			}
			catch (FormatException)
			{
				MessageBox.Show("Vui lòng nhập 1 số nguyên không quá 12 chữ số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (OverflowException)
			{
				MessageBox.Show("Vui lòng nhập 1 số nguyên không quá 12 chữ số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private string ConvertNumberToWords(long number)
		{
			if (number == 0)                // Trường hợp number = 0
				return "Không";             // đọc là " không "
			string words = "";              // khai báo biến words có KDL string
			if (number < 0)                 // Kiểm tra trường hợp số âm
				return "Âm" + ConvertNumberToWords(Math.Abs(number));
            if ((number / 1000000000) > 0)  // Thử xem số có lớn hơn bằng 1 tỷ hay không ? Bằng cách chia cho 1 tỷ xem có lớn hơn 0 hay không ?
			{                               // Nếu lớn hơn thì sẽ gọi lại hàm Convert và bắt đầu thêm số lượng "tỷ"
				words += ConvertNumberToWords(number/1000000000) + " tỷ ";
				number %= 1000000000;       // Lấy phần dư khi chia cho 1 tỷ
			}

			if ((number / 1000000) > 0)     // Kiểm tra xem số có lơn hơn 1 triệu hay không ? Bằng cách chia cho 1 triệu xem có lớn hơn 0 hay không ?
			{                                // Nếu lớn hơn thì sẽ gọi lại hàm Convert và thêm "triệu" vào chuỗi
				words += ConvertNumberToWords(number/1000000) + " triệu ";  
				number %= 1000000;          // Lấy phần dư khi chia cho 1 triệu để tiếp tục xử lý
			}

			if ((number / 1000) > 0)    //Kiểm tra xem số có lớn hơn 1 ngàn hay không?Bằng cách chia cho 1 ngàn xem có lớn hơn 0 hay không ?
            {                           // Nếu lớn hơn thì sẽ gọi lại hàm Convert và thêm "triệu" vào chuỗi
                words += ConvertNumberToWords(number / 1000) + " nghìn ";
				number %= 1000;//Lấy phần dư khi chia cho 1000 để tiếp tục xử lý
				if (number > 0 && number < 100) // trường hợp số dư < 100 và > 0 thì sẽ là"không trăm"
				{
					words += "không trăm ";
				}
			}

			if ((number / 100) > 0)		// Kiểm tra giống như trên
			{
				words += ConvertNumberToWords(number / 100) + " trăm ";	// Nếu thỏa thì thêm "trăm" vào chuỗi
				number %= 100;
			}
		   

			if (number > 0) //Kiểm tra hàng đơn vị xem có >0 và <10
			{
				if (words != "" && number < 10) // Nếu chuỗi không rỗng và number<10 thì sẽ thêm "lẻ" vào chuỗi
					words += "lẻ";		

				switch (number / 10)	// Kiểm tra xem có chẵn chục không bằng cách chia cho 10 và sử dụng swtich case
				{
					case 0:				
						break;
					case 1:
						words += "mười";
						break;
					case 2:
						words += "hai mươi";
						break;
					case 3:
						words += "ba mươi";
						break;
					case 4:
						words += "bốn mươi";
						break;
					case 5:
						words += "năm mươi";
						break;
					case 6:
						words += "sáu mươi";
						break;
					case 7:
						words += "bảy mươi";
						break;
					case 8:
						words += "tám mươi";
						break;
					case 9:
						words += "chín mươi";
						break;
				}

				switch (number % 10) //Xử lý hàng đơn vị bằng cách chia lấy dư cho 10
				{
					case 1:
						if (number / 10 > 1)
							words += " mốt";	// Điều chỉnh cách đọc cho số một
						else
							words += " một";
						break;
					case 2:
						words += " hai";
						break;
					case 3:
						words += " ba";
						break;
					case 4:
						words += " bốn";
						break;
					case 5:
						if (number / 10 > 0)
							words += " lăm";	// Điều chỉnh cách đọc cho số năm
						else
							words += " năm";
						break;
					case 6:
						words += " sáu";
						break;
					case 7:
						words += " bảy";
						break;
					case 8:
						words += " tám";
						break;
					case 9:
						words += " chín";
						break;
				}
			}

			return words.Trim();
		}


		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
