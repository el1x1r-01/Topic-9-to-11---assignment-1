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

        string textBox, calculatorOperator;
        int numberOne, numberTwo;

        private void FormSimpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            textBox = textBox + "Average";
            lblOutput.Text = textBox;
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            textBox = textBox + "^";
            lblOutput.Text = textBox;
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            textBox = textBox + "√";
            lblOutput.Text = textBox;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            textBox = textBox + "%";
            lblOutput.Text = textBox;
        }

        private void btnInput1_Click(object sender, EventArgs e)
        {
            textBox = textBox + "1";
            lblOutput.Text = textBox;
        }

        private void btnInput2_Click(object sender, EventArgs e)
        {
            textBox = textBox + "2";
            lblOutput.Text = textBox;
        }

        private void btnInput3_Click(object sender, EventArgs e)
        {
            textBox = textBox + "3";
            lblOutput.Text = textBox;
        }


        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBox = textBox + " ÷ ";
            lblOutput.Text = textBox;
        }

        private void btnInput4_Click(object sender, EventArgs e)
        {
            textBox = textBox + "4";
            lblOutput.Text = textBox;
        }

        private void btnInput5_Click(object sender, EventArgs e)
        {
            textBox = textBox + "5";
            lblOutput.Text = textBox;
        }

        private void btnInput6_Click(object sender, EventArgs e)
        {
            textBox = textBox + "6";
            lblOutput.Text = textBox;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox = textBox + " x ";
            lblOutput.Text = textBox;
        }

        private void btnInput7_Click(object sender, EventArgs e)
        {
            textBox = textBox + "7";
            lblOutput.Text = textBox;
        }

        private void btnInput8_Click(object sender, EventArgs e)
        {
            textBox = textBox + "8";
            lblOutput.Text = textBox;
        }

        private void btnInput9_Click(object sender, EventArgs e)
        {
            textBox = textBox + "9";
            lblOutput.Text = textBox;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            textBox = textBox + " - ";
            lblOutput.Text = textBox;
        }

        private void btnInput0_Click(object sender, EventArgs e)
        {
            textBox = textBox + "0";
            lblOutput.Text = textBox;
        }

        private void btnInputDecimal_Click(object sender, EventArgs e)
        {
            textBox = textBox + ".";
            lblOutput.Text = textBox;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox = textBox + " + ";
            lblOutput.Text = textBox;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox = "";
            lblOutput.Text = "";
        }
    }
}
