using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Input
    {

        public bool TakeInput(ref decimal num1, ref decimal num2, ref char ope)
        {
            char[] opes = { '+', '-', '/', '*' };
            bool Rope = false;
            Console.WriteLine("========================================================");
            Console.WriteLine("Enter Num1 :");
            var input = Console.ReadLine();

            if (decimal.TryParse(input, out num1)){}
            else
            {
                Console.WriteLine("Invalid Number");
                return false;
            }

            Console.WriteLine("Enter Num2 :");
            input = Console.ReadLine();

            if (decimal.TryParse(input, out num2)) { }
            else
            {
                Console.WriteLine("Invalid Number");
                return false;
            }

            Console.WriteLine("Enter Ope :");
            input = Console.ReadLine();
            
            if (char.TryParse(input, out ope)) { }
            else
            {
                Console.WriteLine("Invalid Operation");
                return false;
            }

            for (int i = 0; i < opes.Length; i++) 
            {
                if (ope == opes[i])
                 Rope = true;
                
            }

            if(!Rope)
            {
                Console.WriteLine("Invalid Operation");
                return false;
            }

            return true;

        }



    }
}
