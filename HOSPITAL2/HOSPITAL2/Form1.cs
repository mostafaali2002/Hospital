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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pbone.BringToFront();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pdental1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            peye.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pblood.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pemergen.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string n = textname.Text;
            string p = textphone.Text;
            int a = int.Parse(textage.Text);
            if (a > 90 || a < 5)
            {
                MessageBox.Show("Enter a vaild age", "Eroor", MessageBoxButtons.OK);
            }
            else if (n == "" || p == "" || a == 0 || !radioButton1.Checked && !radioButton2.Checked || !radioButton26.Checked && !radioButton27.Checked && !radioButton29.Checked && !radioButton30.Checked)
            {
                MessageBox.Show("please complete form", "Eroor", MessageBoxButtons.OK);

            }
            else if (textphone.Text.Length > 11 || textphone.Text.Length < 11)
            {
                MessageBox.Show("Enter a vaild phone", "Eroor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Successfully Registered", "Congratulations", MessageBoxButtons.OK);
            }
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textname_PressKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textage_PressKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textphone_PressKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string n = textname2.Text;
            string p = textphone2.Text;
            int a = int.Parse(textage2.Text);
            if (a > 90 || a < 5)
            {
                MessageBox.Show("Enter a vaild age", "Eroor", MessageBoxButtons.OK);
            }
            else if (n == "" || p == "" || a == 0 || !radioButton5.Checked && !radioButton6.Checked || !radioButton19.Checked && !radioButton20.Checked)
            {
                MessageBox.Show("please complete form", "Eroor", MessageBoxButtons.OK);

            }
            else if (textphone2.Text.Length > 11 || textphone2.Text.Length < 11)
            {
                MessageBox.Show("Enter a vaild phone", "Eroor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Successfully Registered", "Congratulations", MessageBoxButtons.OK);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string n = textname3.Text;
            string p = textphone3.Text;
            int a = int.Parse(textage3.Text);
            if (a > 90 || a < 5)
            {
                MessageBox.Show("Enter a vaild age", "Eroor", MessageBoxButtons.OK);
            }
            else if (n == "" || p == "" || a == 0 || !radioButton7.Checked && !radioButton8.Checked || !radioButton9.Checked && !radioButton10.Checked && !radioButton11.Checked && !radioButton12.Checked && !radioButton13.Checked && !radioButton14.Checked && !radioButton15.Checked && !radioButton16.Checked)
            {
                MessageBox.Show("please complete form", "Eroor", MessageBoxButtons.OK);

            }
            else if (textphone3.Text.Length > 11 || textphone3.Text.Length < 11)
            {
                MessageBox.Show("Enter a vaild phone", "Eroor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Successfully Registered", "Congratulations", MessageBoxButtons.OK);
            }
        }

        private void Emergency_btn_Click(object sender, EventArgs e)
        {
            string n = textname4.Text;
            string p = textphone4.Text;
            int a = int.Parse(textage4.Text);
            if (a > 90 || a < 5)
            {
                MessageBox.Show("Enter a vaild age", "Eroor", MessageBoxButtons.OK);
            }
            else if (n == "" || p == "" || a == 0)
            {
                MessageBox.Show("please complete form", "Eroor", MessageBoxButtons.OK);

            }
            else if (textphone4.Text.Length > 11 || textphone4.Text.Length < 11)
            {
                MessageBox.Show("Enter a vaild phone", "Eroor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Successfully Registered", "Congratulations", MessageBoxButtons.OK);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string n = textname1.Text;
            string p = textphone1.Text;
            int a = int.Parse(textage1.Text);
            if (a > 90 || a < 5)
            {
                MessageBox.Show("Enter a vaild age", "Eroor", MessageBoxButtons.OK);
            }
            else if (n == "" || p == "" || a == 0 || !radioButton3.Checked && !radioButton4.Checked || !radioButton21.Checked && !radioButton22.Checked && !radioButton23.Checked && !radioButton24.Checked && !radioButton25.Checked)
            {
                MessageBox.Show("please complete form", "Eroor", MessageBoxButtons.OK);

            }
            else if (textphone1.Text.Length > 11 || textphone1.Text.Length < 11)
            {
                MessageBox.Show("Enter a vaild phone", "Eroor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Successfully Registered", "Congratulations", MessageBoxButtons.OK);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string n = textBox3.Text;
            string p = textBox1.Text;
            int a = int.Parse(textBox2.Text);
            if (a > 90 || a < 5)
            {
                MessageBox.Show("Enter a vaild age", "Eroor", MessageBoxButtons.OK);
            }
            else if (n == "" || p == "" || a == 0 || !radioButton35.Checked && !radioButton34.Checked || !radioButton28.Checked && !radioButton31.Checked && !radioButton32.Checked && !radioButton33.Checked)
            {
                MessageBox.Show("please complete form", "Eroor", MessageBoxButtons.OK);

            }
            else if (textBox1.Text.Length > 11 || textBox1.Text.Length < 11)
            {
                MessageBox.Show("Enter a vaild phone", "Eroor", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Successfully Registered", "Congratulations", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            serialPort1.Close();
        }
    }
}
