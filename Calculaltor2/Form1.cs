using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultBox.MaxLength = 5;  // set the maximum length of the textbox to 5.       
            MessageBox.Show("The calculator can only compute calculation with single digits for exampel: 2-2/2, it can't compute 22-2/2. Error will be diplayed.  Press OK, to calculate :)"); 
        }

        /// <summary>
        /// Button are inserted to the form. 
        /// </summary>
        /// <param name="sender"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length < 5) // The user can't type more than 5 digits
            {
                Button button = (Button)sender;  // Cast the sender object to a button, to avoid multiple handling event declarations.
                resultBox.Text += button.Text;
            }

           
        }

        /// <summary>
        /// Prepares the expression for the evaluation
        /// </summary>
        /// <param name="sender"></param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {

            string stringToSplit = resultBox.Text; 

            string[] expression = new string[stringToSplit.Length];  // create an array of strings

            for (int i = 0; i < stringToSplit.Length; i++)
            {
                expression[i] = stringToSplit.ElementAt(i).ToString();  // get the elements in the i index of the string, convert it to theri string representation, add that representation to the array. 
            }

            resultBox.Clear();



            if (expression.Length == 3) // Check if the user wants to execute one calculation e.g. 2+3 or 5-5 or 5/5 etc.
            {
                ValidateExpressionLength3(expression);
            }
            else if (expression.Length == 5)// Check if the user wants to execute 2 calculation e.g. 2+3*5 or 5-5/8 or 5-5+5 etc.
            {
                ValidateExpressionLength5(expression);
            }
            else
            {
                Error(); 
            }


        }

        /// <summary>
        /// Clears the textbox 
        /// </summary>
        /// <param name="sender"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            resultBox.Clear(); 
        }

        /// <summary>
        /// Validate if the expression is executable or not. 
        /// </summary>
        /// <param name="expression"></param>
        private void ValidateExpressionLength3(string[] expression)
        {
            //string operation = {"* / + -"};
            string numbers = "1 2 3 4 5 6 7 8 9 0"; // I can compare the first and third value of the expression to make sure it's a number not an operation  
            string operation = "/ * + -";

            if ((operation.Contains((string)expression.GetValue(1))) && numbers.Contains((string)expression.GetValue(0)) && numbers.Contains((string)expression.GetValue(2))) // Look if the 
            {
                Calculate(expression); 
            }
            else
            {
                Error(); // display error
            }
        }

        /// <summary>
        /// Validate if the expression is executable or not. 
        /// </summary>
        /// <param name="expression"></param>
        private void ValidateExpressionLength5(string[] expression)
        {
            string numbers = "1 2 3 4 5 6 7 8 9 0"; // I can compare the first and third value of the expression to make sure it's a number not an operation  
            string operation = "/ * + -";

            if (((operation.Contains((string)expression.GetValue(1)))) && (operation.Contains((string)expression.GetValue(3))) && numbers.Contains((string)expression.GetValue(0)) && numbers.Contains((string)expression.GetValue(2)) && numbers.Contains((string)expression.GetValue(4)))
            {
                Calculate(expression);
            }
            else
            {
                Error(); // display error
            }
        }

        /// <summary>
        /// Display the error on the text box
        /// </summary>
        /// <param name="sender"></param>
        private void Error()
        {
            string errorHandler = "Error, Try again";
            resultBox.Text += errorHandler;
        }

        /// <summary>
        /// Create Calculator object, call the calculator method to evaluate the expression. 
        /// </summary>
        /// <param name="expression"></param>
        private void Calculate(string[] expression)
        {
            Calculator calculator = new Calculator(expression);
            int resultExpression = calculator.ExpressionParser(expression); 
            resultBox.Text += resultExpression; // show the result on the result box 
        }

       
    }
}
