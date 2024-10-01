using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 bai4 = new Bai4();
            bai4.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 bai5 = new Bai5();
            bai5.Show();
        }
    }
}
