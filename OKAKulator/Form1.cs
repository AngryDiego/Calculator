using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace OKAKulator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double firstNum = 0;
        double secondNum = 0;
        string operation = "";



        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
            else
            {
                MessageBox.Show("Ти дебіл конченний?");
            }
           
        }

        private void DigitalButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            operation = btn.Text;
            firstNum = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondNum = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            double result = 0;

            switch (operation)
            {
                case ("+"): result = firstNum + secondNum; break;

                case ("-"): result = firstNum - secondNum; break;

                case ("*"): result = firstNum * secondNum; break;

                case ("/"):  
                    if( secondNum == 0)
                    {
                        MessageBox.Show("Ти дебіл конченний?");
                        break;
                    }
                    else
                    {
                        result = firstNum / secondNum; break;
                    }

            }

            textBox1.Text = result.ToString("0.###", CultureInfo.InvariantCulture);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNum = 0;
            secondNum = 0;
        }

        private void buttonEraseL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("Ти дебіл конченний?");
            }
        }
    }
}
