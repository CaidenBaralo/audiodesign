using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Begining of Program
namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;       //String storing user input
        string operand1 = string.Empty;    //String storing first operand (number)
        string operand2 = string.Empty;    //String storing second operand (number)
        char operation;                    //Char (action) for operation
        double result = 0.0;               //Calculated result (output)
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //These are errors, no additional action will happen when these buttons are selected, just practice 
        {

        }

        private void button4_Click(object sender, EventArgs e) //These are errors, no additional action will happen when these buttons are selected, just practice 
        {

        }

        private void button13_Click(object sender, EventArgs e) //These are errors, no additional action will happen when these buttons are selected, just practice 
        {

        }

        private void button5_Click(object sender, EventArgs e) //These are errors, no additional action will happen when these buttons are selected, just practice 
        {

        }

        private void Num0_Click(object sender, EventArgs e) // When the number "0" is clicked, 0 will appear in the text box and the value 0 will be used
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void Num7_Click(object sender, EventArgs e) // When the number "7" is clicked, 0 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void OpEquals_Click(object sender, EventArgs e) // When the "=" symbol is clicked, the program uses the vraibles input by the user to get the result
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+') // If "+" was selected, use the opperation addition
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-') // If "-" was selected, use the opperation subtraction
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*') // If "*" was selected, use the opperation multiplication
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/') // If "/" was selected, use the opperation division
            {
                if (num2 != 0) // But, if the user divides by 0, give the error "DIV/Zero!"
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                }

            }
        }

        private void OpDivide_Click(object sender, EventArgs e) // When "/" is selected, the program saves the operation for the end (see lines 61-92)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Num8_Click(object sender, EventArgs e) // When the number "8" is clicked, 8 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Num9_Click(object sender, EventArgs e) // When the number "9" is clicked, 9 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void OpMultiply_Click(object sender, EventArgs e) //When "*" is selected, the program saves the operation for the end (see lines 61-92)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Num4_Click(object sender, EventArgs e) // When the number "4" is clicked, 4 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Num5_Click(object sender, EventArgs e) // When the number "5" is clicked, 5 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Num6_Click(object sender, EventArgs e) // When the number "6" is clicked, 6 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void OpMinus_Click(object sender, EventArgs e) //When "-" is selected, the program saves the operation for the end (see lines 61-92)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Num2_Click(object sender, EventArgs e) // When the number "2" is clicked, 2 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void OpPlus_Click(object sender, EventArgs e) //When "+" is selected, the program saves the operation for the end (see lines 61-92)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Num1_Click(object sender, EventArgs e) // When the number "1" is clicked, 1 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Num3_Click(object sender, EventArgs e) // When the number "3" is clicked, 3 will appear in the text box and the value 7 will be used
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void NumDot_Click(object sender, EventArgs e) // When the symbol "." is clicked, a decimal will be used
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void OpClear_Click(object sender, EventArgs e) // When "clear" is selected, the text box is filled with blank text, meaning it clears
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
