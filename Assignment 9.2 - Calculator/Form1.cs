using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9._2___Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "8 + 8 = " + (8 + 8) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "8 - 8 = " + (8 - 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "8 x 8 = " + (8 * 8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "8 ÷ 8 = " + (8 / 8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "8 _ 8 = _" ;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
