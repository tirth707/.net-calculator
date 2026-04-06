using System;
using System.Windows.Forms;

namespace Unit4_Calculator
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
                txtDisplay.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEquals.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtDisplay.Text);
                isOperationPerformed = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultValue / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txtDisplay.Text);
            operationPerformed = "";
        }
    }
}
