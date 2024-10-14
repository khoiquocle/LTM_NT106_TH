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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BT1 bt1 = new BT1();
            this.Hide();
            bt1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BT3 bt3 = new BT3();
            this.Hide();
            bt3.ShowDialog();
        }
    }
}
