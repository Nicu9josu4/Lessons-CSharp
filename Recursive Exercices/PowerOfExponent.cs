using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //15. Write a program in C# Sharp to calculate the power of any number using recursion. Go to the editor
    //Test Data :
    //Input the base value : 5
    //Input the exponent : 3
    //Expected Output :
    //The value of 5 to the power of 3 is : 125
    internal class PowerOfExponent
    {

        internal static int GetPower(int number, int exponent)
        {
            if (exponent == 1) return number;
            return number * GetPower(number, exponent - 1);
        }
    }
}
