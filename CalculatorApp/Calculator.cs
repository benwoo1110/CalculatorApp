using System;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // pass
        }

        private void One_Click(object sender, EventArgs e)
        {
            Expression.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Expression.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Expression.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Expression.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Expression.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Expression.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Expression.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Expression.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Expression.Text += "9";
        }
        
        private void Zero_Click(object sender, EventArgs e)
        {
            Expression.Text += "0";
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            Expression.Text += ".";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Expression.Text += "+";

        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            Expression.Text += "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Expression.Text += "x";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Expression.Text += "÷";
        }

        private void OpenBracket_Click(object sender, EventArgs e)
        {
            Expression.Text += "(";
        }

        private void CloseBracket_Click(object sender, EventArgs e)
        {
            Expression.Text += ")";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            double result;
            try
            {
                result = new ExpressionBuilder(Expression.Text).Calculate();
            }
            catch (Exception error)
            {
                var caption = "ERROR";
                var message = error.Message;
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Expression.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Expression.Text = "";
        }

        private void Expression_Click(object sender, EventArgs e)
        {
            // pass
        }
        
    }
}
