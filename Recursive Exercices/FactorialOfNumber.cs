using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //9. Write a program in C# Sharp to find the factorial of a given number using recursion. Go to the editor
    //Test Data :
    //Input any positive number : 5
    //Expected Output :
    //The factorial of 5 is : 120
    internal class FactorialOfNumber
    {
        internal static int GetFactorial(int factorial)
        {
            if (factorial == 1)  return 1;
           return GetFactorial(factorial - 1) * factorial;
        }
    }
}
