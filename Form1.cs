using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculatorProject
{
    public partial class Calculator : Form
    {
        string operand= "";
        double num1 = 0;
        double num2 = 0;
        double denominator = 0;
        double val = 0;
        string operandSymbol = "";

        public Calculator()
        {
            InitializeComponent();
            this.answerScreen.Text = 0.ToString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //when button five is clicked
        private void button10_Click(object sender, EventArgs e)
        {
            
                if (this.answerScreen.Text == "0" || this.displayScreen.Text == "0")
                {
                    this.answerScreen.Text = "5";
                    this.displayScreen.Text = "5";
            }
                else
                {
                    this.answerScreen.Text = this.answerScreen.Text + "5";
                    this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 5;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            
            if (this.answerScreen.Text == "0" || this.displayScreen.Text == "0")
            {
                this.answerScreen.Text = "0";
                this.displayScreen.Text = "0";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "0";
                this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 0;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            
            if (this.answerScreen.Text == "0" || this.displayScreen.Text == "0")
            {
                this.answerScreen.Text = "1";
                this.displayScreen.Text = "1";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "1";
                this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 1;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            
            if (this.answerScreen.Text == "0" || this.displayScreen.Text == "0")
            {
                this.answerScreen.Text = "2";
                this.displayScreen.Text = "2";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "2";
                this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 2;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            
            if (this.answerScreen.Text == "0")
            {
                this.answerScreen.Text = "3";
                this.displayScreen.Text = "3";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "3";
                this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 3;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 4;
            if (this.answerScreen.Text == "0")
            {
                this.answerScreen.Text = "4";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "4";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 6;
            if (this.answerScreen.Text == "0")
            {
                this.answerScreen.Text = "6";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 7;
            if (this.answerScreen.Text == "0")
            {
                this.answerScreen.Text = "7";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 8;
            if (this.answerScreen.Text == "0")
            {
                this.answerScreen.Text = "8";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + 9;
            if (this.answerScreen.Text == "0")
            {
                this.answerScreen.Text = "9";
            }
            else
            {
                this.answerScreen.Text = this.answerScreen.Text + "9";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand = "division";
            num1 = Convert.ToDouble(this.answerScreen.Text);
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + "÷";
            this.answerScreen.Text = "";
            operandSymbol = "÷";

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand = "multiplication";
            num1 = Convert.ToDouble(this.answerScreen.Text);
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + "x";
            this.answerScreen.Text = "";
            operandSymbol = "x";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand = "subtraction";
            num1 = Convert.ToDouble(this.answerScreen.Text);
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + "-";
            this.answerScreen.Text = "";
            operandSymbol = "-";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand = "addition";
            num1 = Convert.ToDouble(this.answerScreen.Text);
            this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + "+";
            this.answerScreen.Text = "";
            operandSymbol = "+";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(this.answerScreen.Text);
            

            if (operand == "addition")
            {
                this.answerScreen.Text = Convert.ToString(num1 + num2);
            }
            else if (operand == "subtraction")
            {
                this.answerScreen.Text = Convert.ToString(num1 - num2);
            }
            else if (operand == "multiplication")
            {
                this.answerScreen.Text = Convert.ToString(num1 * num2);
            }
            else if (operand == "division")
            {
                if (num2 == 0)
                {
                    this.answerScreen.Text = "Invalid: ÷ 0";
                }
                else {
                    this.answerScreen.Text = Convert.ToString(num1 / num2);
                }
                    
            }
            operand = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.displayScreen.Text = "";
            this.answerScreen.Text = 0.ToString();
            num1 = 0;
            num2 = 0;
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            /*if (this.answerScreen.Text == "0")
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                this.answerScreen.Text = Convert.ToString(Convert.ToDouble(this.answerScreen.Text) / 100);
                this.displayScreen.Text = Convert.ToString(this.displayScreen.Text) + "%";
            }*/

            if (operand != "")
            {
                this.displayScreen.Text = 0.ToString();
                this.answerScreen.Text = Convert.ToString(Convert.ToDouble(this.answerScreen.Text) * num1 / 100 );
            }
            else
            {
                this.answerScreen.Text = Convert.ToString(Convert.ToDouble(this.answerScreen.Text)/100);
                this.displayScreen.Text = Convert.ToString(this.displayScreen.Text + "%");
            }
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            denominator = Convert.ToDouble(this.answerScreen.Text);
            double result = 1 / denominator;
            if (denominator == 0)
            {
                this.answerScreen.Text = "Invalid: ÷ 0";
                return;
            }

            if (operand != "")
            {
                this.displayScreen.Text = Convert.ToString(num1 + operandSymbol + "1 / " + denominator);
                this.answerScreen.Text = Convert.ToString(result);
            }
            else
            {
                this.answerScreen.Text = Convert.ToString(result);
                this.displayScreen.Text = Convert.ToString("1/" + denominator.ToString());
            }
        }

        private void power_Click(object sender, EventArgs e)
        {
            val = Convert.ToDouble(this.answerScreen.Text);
            double result = val * val;
            if (operand != "")
            {
                this.displayScreen.Text = Convert.ToString(num1 + operandSymbol + "sqr( " + val +  ")");
                this.answerScreen.Text = Convert.ToString(result);
            }
            else
            {
                this.answerScreen.Text = Convert.ToString(result);
                this.displayScreen.Text = Convert.ToString("sqr(" + val + ")");
            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            val = Convert.ToDouble(this.answerScreen.Text);
            double result = Math.Sqrt(val);
            if (operand != "")
            {
                this.displayScreen.Text = Convert.ToString(num1 + operandSymbol + "√(" + val + ")");
                this.answerScreen.Text = Convert.ToString(result);
            }
            else
            {
                this.answerScreen.Text = Convert.ToString(result);
                this.displayScreen.Text = Convert.ToString("√(" + val + ")");
            }
        }
    }
}
