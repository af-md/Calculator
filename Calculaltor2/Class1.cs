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
        public string[] expression;

        public Calculator(string[] expression)
        {           
                this.expression = expression; 
               // BodmasParser(expression);  
        }
        
        public int BodmasParser(string[] expression)
        {
            
            if (expression.Length == 3) // Check how many calculations are going to be executed. In this case 1 
            {

                if (expression.Contains("/"))
                {

                    string firstNumber = (string)expression.GetValue(0);
                    int number1 = Int32.Parse(firstNumber);
                    string secondNumber = (string)expression.GetValue(2);
                    int number2 = Int32.Parse(secondNumber);                   
                    string operation = (string)expression.GetValue(1);
                    return Evaluate(number1, number2, operation);
                }
                else if (expression.Contains("*"))
                {
                    string firstNumber = (string)expression.GetValue(0);
                    int number1 = Int32.Parse(firstNumber);
                    string secondNumber = (string)expression.GetValue(2);
                    int number2 = Int32.Parse(secondNumber);
                    string operation = (string)expression.GetValue(1);
                    return Evaluate(number1, number2, operation);
                }
                else if (expression.Contains("+"))
                {
                    string firstNumber = (string)expression.GetValue(0);
                    int number1 = Int32.Parse(firstNumber);
                    string secondNumber = (string)expression.GetValue(2);
                    int number2 = Int32.Parse(secondNumber);
                    string operation = (string)expression.GetValue(1);
                    return Evaluate(number1, number2, operation);
                }
                else if (expression.Contains("-"))
                {
                    string firstNumber = (string)expression.GetValue(0);
                    int number1 = Int32.Parse(firstNumber);
                    string secondNumber = (string)expression.GetValue(2);
                    int number2 = Int32.Parse(secondNumber);
                    string operation = (string)expression.GetValue(1);
                    return Evaluate(number1, number2, operation);
                }
            }
            else if (expression.Length == 5) // Check how many calculations are going to be executed. In this case 2 
            {

                if (expression.Contains("/"))
                {
                    if ((string)expression.GetValue(1) == "/") // look if the operation starts from left e.g. 1/2-5 not 1-3/5
                    {

                        string firstNumber = (string)expression.GetValue(0);
                        int number1 = Int32.Parse(firstNumber);
                        string secondNumber = (string)expression.GetValue(2);
                        int number2 = Int32.Parse(secondNumber);
                        string operation = (string)expression.GetValue(1);
                        int result = Evaluate(number1, number2, operation);
                        string thirdNumber = (string)expression.GetValue(4);
                        int number3 = Int32.Parse(thirdNumber);
                        string operation2 = (string)expression.GetValue(3);
                        return Evaluate(result, number3, operation2);
                    }
                    else // if the operation does have / sign on the right hand side  
                    {
                        string firstNumber = (string)expression.GetValue(2);
                        int number1 = Int32.Parse(firstNumber);
                        string secondNumber = (string)expression.GetValue(4);
                        int number2 = Int32.Parse(secondNumber);
                        string operation = (string)expression.GetValue(3);
                        int result = Evaluate(number1, number2, operation);
                        string thirdNumber = (string)expression.GetValue(0);
                        int number3 = Int32.Parse(thirdNumber);
                        string operation2 = (string)expression.GetValue(1);
                        return Evaluate(number3, result, operation2);
                    }
                }
                else if (expression.Contains("*"))
                {
                    if ((string)expression.GetValue(1) == "*") // look if the operation starts from left e.g. 1/2-5 not 1-3/5
                    {
                        string firstNumber = (string)expression.GetValue(0);
                        int number1 = Int32.Parse(firstNumber);
                        string secondNumber = (string)expression.GetValue(2);
                        int number2 = Int32.Parse(secondNumber);
                        string operation = (string)expression.GetValue(1);
                        int result = Evaluate(number1, number2, operation);
                        string thirdNumber = (string)expression.GetValue(4);
                        int number3 = Int32.Parse(thirdNumber);
                        string operation2 = (string)expression.GetValue(3);
                        return Evaluate(result, number3, operation2);
                    }
                    else // if the operation does have / sign on the right hand side  
                    {
                        string firstNumber = (string)expression.GetValue(2);
                        int number1 = Int32.Parse(firstNumber);
                        string secondNumber = (string)expression.GetValue(4);
                        int number2 = Int32.Parse(secondNumber);
                        string operation = (string)expression.GetValue(3);
                        int result = Evaluate(number1, number2, operation);
                        string thirdNumber = (string)expression.GetValue(0);
                        int number3 = Int32.Parse(thirdNumber);
                        string operation2 = (string)expression.GetValue(1);
                        return Evaluate(result, number3, operation2);
                    }
                }
                else if (expression.Contains("+"))
                {
                    if ((string)expression.GetValue(1) == "+") // look if the operation starts from left e.g. 1/2-5 not 1-3/5
                    {
                        string firstNumber = (string)expression.GetValue(0);
                        int number1 = Int32.Parse(firstNumber);
                        string secondNumber = (string)expression.GetValue(2);
                        int number2 = Int32.Parse(secondNumber);
                        string operation = (string)expression.GetValue(1);
                        int result = Evaluate(number1, number2, operation);
                        string thirdNumber = (string)expression.GetValue(4);
                        int number3 = Int32.Parse(thirdNumber);
                        string operation2 = (string)expression.GetValue(3);
                        return Evaluate(result, number3, operation2);
                    }
                    else // if the operation does have / sign on the right hand side  
                    {
                        string firstNumber = (string)expression.GetValue(2);
                        int number1 = Int32.Parse(firstNumber);
                        string secondNumber = (string)expression.GetValue(4);
                        int number2 = Int32.Parse(secondNumber);
                        string operation = (string)expression.GetValue(3);
                        int result = Evaluate(number1, number2, operation);
                        string thirdNumber = (string)expression.GetValue(0);
                        int number3 = Int32.Parse(thirdNumber);
                        string operation2 = (string)expression.GetValue(1);
                        return Evaluate(result, number3, operation2);
                    }
                }
                else
                {
                    string firstNumber = (string)expression.GetValue(2);
                    int number1 = Int32.Parse(firstNumber);
                    string secondNumber = (string)expression.GetValue(4);
                    int number2 = Int32.Parse(secondNumber);
                    string operation = (string)expression.GetValue(3);
                    int result = Evaluate(number1, number2, operation);
                    string thirdNumber = (string)expression.GetValue(0);
                    int number3 = Int32.Parse(thirdNumber);
                    string operation2 = (string)expression.GetValue(1);
                    return Evaluate(result, number3, operation2);
                }
            }



            
                return 0; 

                     
            
        }

        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

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
    }
}
