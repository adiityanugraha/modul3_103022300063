using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_03_103022300063
{
    public partial class Form1: Form
    {
        String number;
        String hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "1";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "6";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "5";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "3";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "2";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "4";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "7";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "8";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "9";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            number = number + "0";
            int result = Int32.Parse(number);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            hasil = number;
            number = "+";
            textBox1.Text = number;
            textBox1.Show();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            int result = Int32.Parse(number) + Int32.Parse(hasil);
            textBox1.Text = result.ToString();
            textBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
