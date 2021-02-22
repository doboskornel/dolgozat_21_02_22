using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOlgozat_21_02_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(bt.Text);
            int c = Convert.ToInt32(ct.Text);
            double a = 0;
            double k = 0;
            double t = 0;
            a = (double) Math.Sqrt(b*b + c*c);
            k = (double) a+b+c;
            t = (double) b*c/2;

            at.Text = Convert.ToString(a);
            kt.Text = Convert.ToString(k);
            tt.Text = Convert.ToString(t);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = button1.Text.ToUpper();
                button2.Text = button2.Text.ToUpper();
                button3.Text = button3.Text.ToUpper();
                button4.Text = button4.Text.ToUpper();
            }
            else
            {
                button1.Text = button1.Text.ToLower();
                button2.Text = button2.Text.ToLower();
                button3.Text = button3.Text.ToLower();
                button4.Text = button4.Text.ToLower();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
