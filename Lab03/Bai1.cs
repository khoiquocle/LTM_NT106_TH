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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1Server server = new Bai1Server();
            server.ShowDialog();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Bai1Client client = new Bai1Client();
            client.ShowDialog();    
        }
    }
}
