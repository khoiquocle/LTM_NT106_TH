using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bai1 bai1 = new Bai1();
            this.Hide();
            bai1.FormClosed += (s, args) => this.Show();
            bai1.ShowDialog();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            this.Hide();
            bai2.FormClosed += (s, args) => this.Show();
            bai2.ShowDialog();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            this.Hide();
            bai3.FormClosed += (s, args) => this.Show();
            bai3.ShowDialog();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            this.Hide();
            bai4.FormClosed += (s, args) => this.Show();
            bai4.ShowDialog();
        }

        private void btn_bai5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            this.Hide();
            bai5.FormClosed += (s, args) => this.Show();
            bai5.ShowDialog();
        }
    }
}
