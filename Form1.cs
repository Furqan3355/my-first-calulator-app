using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

private viod oe(){console.write("talha u ma");}


namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float value1, value2, result;
        char sign;
        bool isOperationPerformed = false;

        private void one_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                textBox1.Clear();
                isOperationPerformed = false;
            }
            textBox1.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Multiplication button
        {
            value1 = float.Parse(textBox1.Text);
            sign = '*';
            isOperationPerformed = true;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // Subtraction button
        {
            value1 = float.Parse(textBox1.Text);
            sign = '-';
            isOperationPerformed = true;
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e) // Division button
        {
            value1 = float.Parse(textBox1.Text);
            sign = '/';
            isOperationPerformed = true;
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e) // Addition button
        {
            value1 = float.Parse(textBox1.Text);
            sign = '+';
            isOperationPerformed = true;
            textBox1.Clear();
        }

        private void button7_Click(object sender, EventArgs e) // Equals button
        {
            value2 = float.Parse(textBox1.Text);

            switch (sign)
            {
                case '*':
                    result = value1 * value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '/':
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                    }
                    else
                    {
                        textBox1.Text = "Cannot divide by zero";
                        return;
                    }
                    break;
                case '+':
                    result = value1 + value2;
                    break;
            }
            textBox1.Text = result.ToString();
            value1 = result; // To allow for continued operations
            isOperationPerformed = true;
        }

        private void button9_Click(object sender, EventArgs e) // Clear button
        {
            textBox1.Text = "";
            value1 = 0;
            value2 = 0;
            result = 0;
            sign = '\0';
            isOperationPerformed = false;
        }
    }
}

