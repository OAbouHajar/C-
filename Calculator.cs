using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1Q2
{
    public partial class Calculator : Form
    {
        public string operand;
        public double results = 0;
        public bool another = true;
        public bool dotAssigned = false;
        public bool firstNumberfree = true;
        public bool secondNumberfree = true;

        public double number1 = 0;
        public double number2 = 0;



        public void printNumber(string number)
        {
            if (another)
            {
                txtScreen.Clear();
                another = false;
            }
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = number;
            }
            else
            {
                txtScreen.Text = txtScreen.Text + number;
            }
        }

        public void calc( double num, string oper)
        {
            switch(oper)
            {
                case "+":
                    results += num; 
                    break;
                case "-":
                    results -= num;
                    break;
                case "*":
                    results *= num;
                    break;
                case "/":
                    results /= num;
                    break;
                default:
                    results = num;
                    break; 
            }
           
            //System.Diagnostics.Debug.WriteLine("LOOK AT THE RESULT: "+ results);
        }


        public Calculator()
        {
            InitializeComponent();
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            printNumber("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            printNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            printNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            printNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            printNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            printNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            printNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            printNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            printNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            printNumber("9");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            number1 = Convert.ToDouble(txtScreen.Text);
            calc(number1, operand);
            operand = "+";
            txtScreen.Clear();
            txtScreen.Text = Convert.ToString(results);
            another = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtScreen.Text);
            calc(number1, operand);
            operand = "-";
            txtScreen.Clear();
            txtScreen.Text = Convert.ToString(results);
            another = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtScreen.Text);
            calc(number1, operand);
            operand = "*";
            txtScreen.Clear();
            txtScreen.Text = Convert.ToString(results);
            another = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtScreen.Text);
            calc(number1, operand);
            operand = "/";
            txtScreen.Clear();
            txtScreen.Text = Convert.ToString(results);
            another = true;
        }
        //equal
        private void btnEqul_Click(object sender, EventArgs e)
        {
            if(operand == "+")
            {
                results += Convert.ToDouble(txtScreen.Text);
                txtScreen.Clear();
            }
            else if (operand == "-")
            {
                results -= Convert.ToDouble(txtScreen.Text);
                txtScreen.Clear();
            }
            else if (operand == "*")
            {
                results *= Convert.ToDouble(txtScreen.Text);
                txtScreen.Clear();
            }
            else if (operand == "/")
            {
                results /= Convert.ToDouble(txtScreen.Text);
                txtScreen.Clear();
            }
            txtScreen.Text = Convert.ToString(results);
            operand = null;
            results = Convert.ToDouble(txtScreen.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtScreen.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtScreen.TextLength > 0)
                txtScreen.Text = txtScreen.Text.Substring(0, (txtScreen.TextLength - 1));
        }

        private void btnSignChange_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.StartsWith("-"))
            {
                txtScreen.Text = txtScreen.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(txtScreen.Text) && decimal.Parse(txtScreen.Text) != 0)
            {
                txtScreen.Text = "-" + txtScreen.Text;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!dotAssigned)
            {
                txtScreen.SelectionLength = txtScreen.TextLength;
                txtScreen.SelectedText += ".";
                dotAssigned = true;
            }
        }
    }
}
