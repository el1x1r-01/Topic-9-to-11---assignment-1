using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Topic_9_to_11___assignment_1
{
    public partial class FormSimpleCalculator : Form
    {
        public FormSimpleCalculator()
        {
            InitializeComponent();
        }

        string textBox, calculatorOperator, numBeingEntered;
        double numberOne, numberTwo, result;

        private void FormSimpleCalculator_Load(object sender, EventArgs e)
        {
            numBeingEntered = "1";
            calculatorOperator = "";

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = false;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = " Average ";
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = "^";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = "√";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = "% of ";
        }

        private void btnInput1_Click(object sender, EventArgs e)
        {
            textBox = textBox + "1";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInput2_Click(object sender, EventArgs e)
        {
            textBox = textBox + "2";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInput3_Click(object sender, EventArgs e)
        {
            textBox = textBox + "3";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }


        private void btnDivide_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = " ÷ ";
        }

        private void btnInput4_Click(object sender, EventArgs e)
        {
            textBox = textBox + "4";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false; ;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInput5_Click(object sender, EventArgs e)
        {
            textBox = textBox + "5";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInput6_Click(object sender, EventArgs e)
        {
            textBox = textBox + "6";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = " x ";
        }

        private void btnInput7_Click(object sender, EventArgs e)
        {
            textBox = textBox + "7";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInput8_Click(object sender, EventArgs e)
        {
            textBox = textBox + "8";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInput9_Click(object sender, EventArgs e)
        {
            textBox = textBox + "9";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = " - ";
        }

        private void btnInput0_Click(object sender, EventArgs e)
        {
            textBox = textBox + "0";
            lblOutput.Text = textBox;

            btnAverage.Enabled = true;
            btnExponent.Enabled = true;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = true;
            btnDivide.Enabled = true;
            btnMultiply.Enabled = true;
            btnSubtract.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnInputDecimal_Click(object sender, EventArgs e)
        {
            textBox = textBox + ".";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberTwo);

            if (calculatorOperator == " ÷ ")
            {
                result = (numberOne / numberTwo);
            }
            else if (calculatorOperator == " x ")
            {
                result = (numberOne * numberTwo);
            }
            else if (calculatorOperator == " + ")
            {
                result = (numberOne + numberTwo);
            }
            else if (calculatorOperator == " - ")
            {
                result = (numberOne - numberTwo);
            }
            else if (calculatorOperator == "^")
            {
                result = Math.Pow(numberOne, numberTwo);
            }
            else if (calculatorOperator == "% of ")
            {
                result = ((numberTwo * numberOne) / 100);
            }
            else if (calculatorOperator == "√")
            {
                result = Math.Sqrt(numberTwo);
            }
            else if (calculatorOperator == " Average ")
            {
                result = ((numberOne + numberTwo) / 2);
            }

                string num1 = numberOne.ToString();
            string num2 = numberTwo.ToString();
            if (calculatorOperator == "")
            {
                lblOutput.Text = "ERROR";
            }
            else if (calculatorOperator == "√")
            {
                lblOutput.Text = calculatorOperator + num2 + "\n = " + result;
            }
            else if (calculatorOperator == " Average ")
            {
                lblOutput.Text = "Average of " + num1 + " and " + num2 + "\n = " + result;
            }
            else
            {
                lblOutput.Text = num1 + calculatorOperator + num2 + "\n = " + result;
            }

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = false;
            btnInput1.Enabled = false;
            btnInput2.Enabled = false;
            btnInput3.Enabled = false;
            btnInput4.Enabled = false;
            btnInput5.Enabled = false;
            btnInput6.Enabled = false;
            btnInput7.Enabled = false;
            btnInput8.Enabled = false;
            btnInput9.Enabled = false;
            btnInput0.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox, out numberOne);
            textBox = "";
            lblOutput.Text = textBox;

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnSquareRoot.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = true;

            calculatorOperator = " + ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox = "";
            lblOutput.Text = "";
            numBeingEntered = "1";
            calculatorOperator = "";

            btnAverage.Enabled = false;
            btnExponent.Enabled = false;
            btnPercentage.Enabled = false;
            btnDivide.Enabled = false;
            btnMultiply.Enabled = false;
            btnSubtract.Enabled = false;
            btnAdd.Enabled = false;
            btnInputDecimal.Enabled = false;
            btnSquareRoot.Enabled = true;
            btnInput1.Enabled = true;
            btnInput2.Enabled = true;
            btnInput3.Enabled = true;
            btnInput4.Enabled = true;
            btnInput5.Enabled = true;
            btnInput6.Enabled = true;
            btnInput7.Enabled = true;
            btnInput8.Enabled = true;
            btnInput9.Enabled = true;
            btnInput0.Enabled = true;
        }
    }
}
