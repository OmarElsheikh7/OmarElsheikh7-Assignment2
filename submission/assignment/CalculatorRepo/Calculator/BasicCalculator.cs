using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class BasicCalculator
    {
        public decimal Calc( decimal num1, decimal num2,char ope)
        {
            decimal res = 0 ;
            switch (ope)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Undifend");
                        break;
                    }
                    res = num1 / num2;
                    break;
            }
            return res;
        }

    }
}
