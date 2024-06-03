using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL2
{
    public partial class Form2 : Form
    {
        Form1 f = new Form1();
        Form3 x = new Form3();


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f == null)
            {
                f = new Form1();
                f.Show();
            }
            else
            {
                f.Show();
                f.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "MMFMM")
            {
                MessageBox.Show("The Username is Wrong", "ERROR", MessageBoxButtons.OK);
            }
            else if (textBox2.Text != "MMFMM")
            {
                MessageBox.Show("The Password is Wrong", "ERROR", MessageBoxButtons.OK);
            }
            else if (textBox1.Text != "MMFMM" && textBox2.Text != "MMFMM")
            {
                MessageBox.Show("Enter vaild information", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                if (x == null)
                {
                    x = new Form3();
                    x.Show();
                }
                else
                {
                    x.Show();
                    x.Focus();
                }
            }
        }
    }
}
