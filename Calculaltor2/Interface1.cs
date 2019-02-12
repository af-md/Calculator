using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{

    /// <summary>
    /// The interface is used to provid a loose couplind ability to the calculator. 
    /// If we want to make an even more sophisticated calculator, we can use these methods signatures in an another class, and provide the implementation for it.
    /// </summary>
    interface ICalculations
    {
        int Addition(int number1, int number2); 
        int Subtraction(int number1, int number2);
        int Multiplication(int number1, int number2);
        int Division(int number1, int number2);
        int ExpressionParser(string[] expression); // Method that handles how the expression is parsed. 
    }
}
