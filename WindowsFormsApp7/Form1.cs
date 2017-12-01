using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    { Int32 x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnloop1_Click(object sender, EventArgs e)
        {
            lblmessage1.ResetText();
            // use aloop to display numbers from 100-120
            for(Int32 counter=100;counter<=120;counter+=2)
            {
                lblmessage1.Text += counter+" ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Int32 counter=100;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 x = Convert.ToInt32(textBox1.Text);
            Int32 y  = Convert.ToInt32(textBox2.Text);
            Int32 result = addnumbers(x, y);
            label2.Text = Convert.ToString(result);
        }
        private Int32 addnumbers(Int32 x,Int32 y)
        {
            Int32 sum = x + y;
            return sum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
