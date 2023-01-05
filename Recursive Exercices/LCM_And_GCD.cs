using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    internal class LCM_And_GCD
    {
        //  12. Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion. Go to the editor
        //  Test Data :
        //  Input the first number : 10
        //  Input the second number : 15
        //  Expected Output :
        //  The GCD of 10 and 15 = 5
        //  The LCM of 10 and 15 = 30
        internal static int LCM(int fNumber, int sNumber) // Least common multiple {Cel mai mic multiplu comun}
        {
            return (fNumber * sNumber) / GCD(fNumber, sNumber);
        }
        internal static int GCD(int fNumber, int sNumber, int result = 0) // Greatest common divisor {Cel mai mare divizor comun}
        {
            if (result == 0) result = Math.Min(fNumber, sNumber);
            if (fNumber % result == 0 && sNumber % result == 0 && result > 1) return result;
            else
            {
                return GCD(fNumber, sNumber, result - 1);
            }
        }
    }
}
