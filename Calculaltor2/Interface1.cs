using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    interface ICalculations
    {
        int Addition(int number1, int number2);
        int Subtraction(int number1, int number2);
        int Multiplication(int number1, int number2);
        int Division(int number1, int number2);
    }
}
