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
            resultBox.MaxLength = 5;  // se the maximum length of the textbox to 5            
        }

        /// <summary>
        /// This event is called when button 1 is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length < 5) // The user can't type more than 5 digits
            {
                Button button = (Button)sender;  // Cast the sender object to a button, to avoid multiple handling event declarations.
                resultBox.Text += button.Text;
            }

           
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            string stringToSplit = resultBox.Text;

            string[] expression = new string[stringToSplit.Length]; // Create the array expression 

            for (int i = 0; i<stringToSplit.Length; i++)
            {
                expression[i] = stringToSplit.ElementAt(i).ToString();  // 
            }

            resultBox.Clear();           

            //char[] expression = text.ToCharArray(); //convert text to character array. I could even deal with them as strings really. ??  

            if (expression.Length == 3 ) // Check if the user wants to execute one calculation e.g. 2+3 or 5-5 or 5/5 etc.
            {
              //string operation = {"* / + -"};
            string numbers = "1 2 3 4 5 6 7 8 9 0"; // I can compare the first and third value of the expression to make sure it's a number not an operation  
             string operation = "/ * + -";

                if ((operation.Contains((string)expression.GetValue(1))) && numbers.Contains((string)expression.GetValue(0)) && numbers.Contains((string)expression.GetValue(2)))
                    {
                        Calculator calculator = new Calculator(expression);
                         int resultExpression = calculator.BodmasParser(expression);
                    resultBox.Text += resultExpression;
                    } 
                    else
                    {
                        string errorHandler = "Error handler";
                    }
            }
            else if(expression.Length == 5)// Check if the user wants to execute 2 calculation e.g. 2+3*5 or 5-5/8 or 5-5+5 etc.
            {
                string numbers = "1 2 3 4 5 6 7 8 9 0"; // I can compare the first and third value of the expression to make sure it's a number not an operation  
                string operation = "/ * + -";

                if (((operation.Contains((string)expression.GetValue(1)))) && (operation.Contains((string)expression.GetValue(3))) && numbers.Contains((string)expression.GetValue(0)) && numbers.Contains((string)expression.GetValue(2)) && numbers.Contains((string)expression.GetValue(4)))
                    {
                        Calculator calculator = new Calculator(expression);
                        int resultTextBox = calculator.BodmasParser(expression);
                } 
                    else
                    {
                        string errorHandler = "Error handler";
                    }
            }
            else
            {
                string errorHandler = "Error handler"; 
            }
           

                // Create the calculator object to handle the mathematical functions 

            //resultLbl.Text = myCalc.Add(n1, n2).ToString();


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            resultBox.Clear(); 
        }
    }
}
