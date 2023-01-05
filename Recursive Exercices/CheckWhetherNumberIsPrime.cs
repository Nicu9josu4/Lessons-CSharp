using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    internal class CheckWhetherNumberIsPrime
    {
        //7. Write a program in C# Sharp to check whether a number is prime or not using recursion. Go to the editor
        //Test Data :
        //Input any positive number : 37
        //Expected Output :
        //The number 37 is a prime number.
        internal static void CheckNumber(int number, int floatNumber = 0)
        {
            if (number <= 2 && number > 0)
            {
                Console.WriteLine("Number is prime"); return;
            }
            else
                if (floatNumber % (number - 1) == 0)
            {
                Console.WriteLine("Number is not prime");
                return;
            }
            else CheckNumber(number - 1, floatNumber);
        }
    }
}
