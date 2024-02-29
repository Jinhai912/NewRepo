using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(TextBox1.Text);
            string s = TextBox3.Text;
            int b = Int32.Parse(TextBox2.Text);
            PictureBox1.Show();
            Label5.Text = Count(a, b, s);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private string Count(int a,int b,string s)
        {
            int c = 0;
            switch (s)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
                case "%":
                    c = a % b;
                    break;
            }
            string result = c.ToString();
            return result;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
