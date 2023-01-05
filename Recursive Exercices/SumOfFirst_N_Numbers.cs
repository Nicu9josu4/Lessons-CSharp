using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion. Go to the editor
    //Test Data :
    //How many numbers to sum : 10
    //Expected Output :
    //The sum of first 10 natural numbers is : 55
    internal class SumOfFirst_N_Numbers
    {
        internal static int SumNumbers(int n)
        {
            if (n == 1) return 1;
            return SumNumbers(n - 1) + n;
        }
    }
}
