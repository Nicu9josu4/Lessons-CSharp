using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //  6. Write a program in C to print even or odd numbers in a given range using recursion. Go to the editor
    //  Test Data :
    //  Input the range to print starting from 1 : 20
    //  Expected Output :
    //  All even numbers from 1 to 20 are :
    //  2 4 6 8 10 12 14 16 18 20
        
    //  All odd numbers from 1 to 20 are :
    //  1 3 5 7 9 11 13 15 17 19
    internal class EvenAndOddNumbers
    {
        internal static void GiveEvenNumbers(int n)
        {
            if(n == 0) return;
            if (n % 2 == 0) { GiveEvenNumbers(n - 2); Console.Write(n + " "); }
            if (n % 2 == 1) GiveEvenNumbers(n - 1);
            
        }
        internal static void GiveOddNumbers(int n)
        {
            if (n <= 0) return;
            if (n % 2 == 1) { GiveOddNumbers(n - 2); Console.Write(n + " "); }
            if (n % 2 == 0) GiveOddNumbers(n - 1);
            
        }
    }
}
