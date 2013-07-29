using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitMultidev01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world\r\nสวัสดี ชาวโลก");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ofrm2 = new Form2();
            ofrm2.Show();
        }
    }
}
