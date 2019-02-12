using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator : ICalculations
    {

        public Calculator(string[] expression)
        {           
        }


        /// <summary>
        /// Parses the expression, and then sends it to the switch statament in the evaluate method to be evaluated it. 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public int ExpressionParser(string[] expression)
        {
            
            if (expression.Length == 3) // Check how many calculations are going to be executed. In this case 1 
            {
                int number1 = ExeCalculatioInOrder((string)expression.GetValue(0)); // Get the value from the expression array, cast the value to a string for the ExeCalculatioInOrder which takes string parameters. 
                int number2 = ExeCalculatioInOrder((string)expression.GetValue(2));
                string operation = (string)expression.GetValue(1);
                return Evaluate(number1, number2, operation);
            }
            else if (expression.Length == 5) // Check how many calculations are going to be executed. In this case 2 
            {

                if (expression.Contains("/"))
                {
                    if ((string)expression.GetValue(1) == "/") // look if the operation starts from left e.g. 1/2-5 not 1-3/5
                    {
                        int number1 = ExeCalculatioInOrder((string)expression.GetValue(0));
                        int number2 = ExeCalculatioInOrder((string)expression.GetValue(2));
                        string operation = (string)expression.GetValue(1);
                        int result = Evaluate(number1, number2, operation);
                        int number3 = ExeCalculatioInOrder((string)expression.GetValue(4));
                        string operation2 = (string)expression.GetValue(3);
                        return Evaluate(result, number3, operation2);
                    }
                    else // if the operation does have / sign on the right hand side  
                    {
                        int number1 = ExeCalculatioInOrder((string)expression.GetValue(2));
                        int number2 = ExeCalculatioInOrder((string)expression.GetValue(4));
                        string operation = (string)expression.GetValue(3);
                        int result = Evaluate(number1, number2, operation);
                        int number3 = ExeCalculatioInOrder((string)expression.GetValue(0));
                        string operation2 = (string)expression.GetValue(1);
                        return Evaluate(number3, result, operation2);
                    }
                }
                else if (expression.Contains("*"))
                {
                    if ((string)expression.GetValue(1) == "*") // look if the operation starts from left e.g. 1/2-5 not 1-3/5
                    {
                        int number1 = ExeCalculatioInOrder((string)expression.GetValue(0));
                        int number2 = ExeCalculatioInOrder((string)expression.GetValue(2));
                        string operation = (string)expression.GetValue(1);
                        int result = Evaluate(number1, number2, operation);
                        int number3 = ExeCalculatioInOrder((string)expression.GetValue(4));
                        string operation2 = (string)expression.GetValue(3);
                        return Evaluate(result, number3, operation2);
                    }
                    else // if the operation does have / sign on the right hand side  
                    {
                        int number1 = ExeCalculatioInOrder((string)expression.GetValue(2));
                        int number2 = ExeCalculatioInOrder((string)expression.GetValue(4));
                        string operation = (string)expression.GetValue(3);
                        int result = Evaluate(number1, number2, operation);
                        int number3 = ExeCalculatioInOrder((string)expression.GetValue(0));
                        string operation2 = (string)expression.GetValue(1);
                        return Evaluate(number3, result, operation2);
                    }
                }
                else if (expression.Contains("+"))
                {
                    if ((string)expression.GetValue(1) == "+") // look if the operation starts from left e.g. 1/2-5 not 1-3/5
                    {
                        int number1 = ExeCalculatioInOrder((string)expression.GetValue(0));
                        int number2 = ExeCalculatioInOrder((string)expression.GetValue(2));
                        string operation = (string)expression.GetValue(1);
                        int result = Evaluate(number1, number2, operation);
                        int number3 = ExeCalculatioInOrder((string)expression.GetValue(4));
                        string operation2 = (string)expression.GetValue(3);
                        return Evaluate(result, number3, operation2);
                    }
                    else // if the operation does have / sign on the right hand side  
                    {
                        int number1 = ExeCalculatioInOrder((string)expression.GetValue(2));
                        int number2 = ExeCalculatioInOrder((string)expression.GetValue(4));
                        string operation = (string)expression.GetValue(3);
                        int result = Evaluate(number1, number2, operation);
                        int number3 = ExeCalculatioInOrder((string)expression.GetValue(0));
                        string operation2 = (string)expression.GetValue(1);
                        return Evaluate(number3, result, operation2);
                    }
                }
                else
                {
                    int number1 = ExeCalculatioInOrder((string)expression.GetValue(0));
                    int number2 = ExeCalculatioInOrder((string)expression.GetValue(2));
                    string operation = (string)expression.GetValue(1);
                    int result = Evaluate(number1, number2, operation);
                    int number3 = ExeCalculatioInOrder((string)expression.GetValue(4));
                    string operation2 = (string)expression.GetValue(3);
                    return Evaluate(result, number3, operation2);
                }
            }           
            return 0;            
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// Divide
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        /// <summary>
        /// Multiply
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        /// <summary>
        /// Subtract
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// The switch statement evaluates the expression 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public int Evaluate(int number1 , int number2, string operation)
        {

            int result = 0;
            

            // Look back at the interface usage ??

            switch (operation)
            {
                case"+":
                    result = Addition(number1, number2);
                    
                    break;
                case "*":
                   result = Multiplication(number1, number2);
                    
                    break;
                case "-":
                    result = Subtraction(number1, number2);
                    
                    break;
                case "/":
                    result = Division(number1, number2);
                    
                    break;                   
            }

            return result;  

        }

        /// <summary>
        /// Parse the string in an integer. 
        /// </summary>
        /// <param name="toParse"></param>
        /// <returns></returns>
        public int ExeCalculatioInOrder(string toParse)
        {;
            int parsedNumber = Int32.Parse(toParse); // use of the Int32 immutable class to convert the string in an integer

            return parsedNumber; 
        }
    }

}
