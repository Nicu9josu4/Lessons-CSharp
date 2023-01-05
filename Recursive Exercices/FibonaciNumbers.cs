using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //10. Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series using recursion. Go to the editor
    //Test Data :
    //Input number of terms for the Fibonacci series : 10
    //Expected Output :
    //The Fibonacci series of 10 terms is : 0 1 1 2 3 5 8 13 21 34
    internal class FibonaciNumbers
    {
        internal static void FibonaciGetNumbers(int n, int numbers = 0, int lastNumber = 1)
        {
            if (n == 0) return;
            Console.Write(numbers + " ");
            FibonaciGetNumbers(n - 1, numbers + lastNumber, numbers);

        }
    }
}
