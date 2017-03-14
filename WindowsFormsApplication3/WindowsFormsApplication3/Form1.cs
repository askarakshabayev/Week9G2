using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public static Calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (calculator.operation == Calculator.Operation.NONE ||
                calculator.operation == Calculator.Operation.NUMBER)
            {
                display.Text += btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.PLUS)
            {
                calculator.saveFirstNumber(display.Text);
                display.Text = btn.Text;
            }
            calculator.operation = Calculator.Operation.NUMBER;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculator.saveSecondNumber(display.Text);
            display.Text = calculator.getResultPlus().ToString();
            calculator.firstNumber = calculator.getResultPlus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calculator.operation = Calculator.Operation.PLUS;
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }
         */ 
    }
}
