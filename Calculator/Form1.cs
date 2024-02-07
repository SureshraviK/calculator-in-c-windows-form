using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;    
        String operand1 = string.Empty;     
        String operand2 = string.Empty;     
        char operation;                     
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            if (string.IsNullOrEmpty(input))
            {
                this.textBox1.Text = "INValid Operator";
                operand1=string.Empty;

            }
            input = string.Empty;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            if (string.IsNullOrEmpty(input))
            {
                this.textBox1.Text = "INValid Operator";
                operand1 = string.Empty;

            }
            input = string.Empty;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            if (string.IsNullOrEmpty(input))
            {
                this.textBox1.Text = "INValid Operator";
                operand1 = string.Empty;

            }
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            if (string.IsNullOrEmpty(input))
            {
                this.textBox1.Text = "INValid Operator";
                operand1 = string.Empty;

            }
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double input1, input2;
            double.TryParse(operand1, out input1);
            double.TryParse(operand2, out input2);

            if (operation == '+')
            {
                result = input1 + input2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = input1 - input2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = input1 * input2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (input2 != 0)
                {
                    result = input1 / input2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "INPUT NOT VALILD";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                this.textBox1.Text = (textBox1.Text).Remove((textBox1.Text).Length - 1);
                this.input = (input).Remove((input).Length - 1);
            }
            
        }
    }
}
