using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            string a = value1TextBox.Text;
            string b = value2TextBox.Text;
            int firstVariable = int.Parse(a);
            int secondVariable = int.Parse(b);

            int sum = firstVariable + secondVariable;
            string result = sum.ToString();
            resultLabel.Text = result;
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            string a = value1TextBox.Text;
            string b = value2TextBox.Text;
            int firstVariable = int.Parse(a);
            int secondVariable = int.Parse(b);

            int difference = firstVariable - secondVariable;
            string result = difference.ToString();
            resultLabel.Text = result;
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            string a = value1TextBox.Text;
            string b = value2TextBox.Text;
            int firstVariable = int.Parse(a);
            int secondVariable = int.Parse(b);

            int product = firstVariable * secondVariable;
            string result = product.ToString();
            resultLabel.Text = result;
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            string a = value1TextBox.Text;
            string b = value2TextBox.Text;
            double firstVariable = double.Parse(a);
            double secondVariable = double.Parse(b);

            double quotient = firstVariable / secondVariable;
            string result = quotient.ToString();
            resultLabel.Text = result;
        }
    }
}