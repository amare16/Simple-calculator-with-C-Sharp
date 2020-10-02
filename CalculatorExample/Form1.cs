using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorExample
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int secondNumber;
        float result;
        string operatorType = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             

        }

        /// <summary>
        /// Adding two numbers by accepting two variables
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public int addTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }
       
        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void AcceptNumbers(object sender, EventArgs e)
        {
            txtResult.Text += (sender as Button).Text;
        }

        private void AcceptSecondNumber(object sender, EventArgs e)
        {
            operatorType = (sender as Button).Text;
            if(firstNumber == 0)
            {
                firstNumber = int.Parse(txtResult.Text);
                txtResult.Text = "";
            }
        }

        private void GetResult(object sender, EventArgs e)
        {
            secondNumber = int.Parse(txtResult.Text);
            if (operatorType == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorType == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operatorType == "X")
            {
                result = firstNumber * secondNumber;
            }
            else if (operatorType == "/")
            {
                result = firstNumber / secondNumber;
            }

            txtResult.Text = result.ToString();
        }

        private void clearResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
            firstNumber = 0;
            secondNumber = 0;
        }
    }
}
