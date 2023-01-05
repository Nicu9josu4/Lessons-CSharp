using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //  1.Write a program in C# Sharp to print the first n natural number using recursion.
    //  Test Data :
    //  How many numbers to print : 10
    //  Expected Output :
    //  1 2 3 4 5 6 7 8 9 10
    class First_N_NaturalNumber
    {
        public static int FirstNumbers(int n)
        {
            if (n == 1)  return 1;
            return FirstNumbers(n - 1);
            Console.WriteLine();
        }
    }
}
