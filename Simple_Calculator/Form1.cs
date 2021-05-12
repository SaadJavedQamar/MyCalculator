using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        decimal firstNumber, secondNumber, result;
        int opp;
        public void clearZero()
        {
            if (textBox.Text == "0")

                textBox.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            opp = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            opp = 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                textBox.Clear();
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDecimal(textBox.Text);

            switch (opp)
            {
                case 1:
                    
                    result = firstNumber + secondNumber;
                    textBox.Text = result.ToString();
                    break;

                case 2:
                    result = firstNumber - secondNumber;
                    textBox.Text = result.ToString();
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    textBox.Text = result.ToString();
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    textBox.Text = result.ToString();
                    break;


                default:
                    break;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            opp = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            clearZero();
            textBox.Text = textBox.Text + "3";
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            clearZero();
            textBox.Text = textBox.Text + "0";

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            opp = 1;


        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
