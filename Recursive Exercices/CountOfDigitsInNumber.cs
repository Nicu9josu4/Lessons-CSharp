using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //5. Write a program in C# Sharp to count the number of digits in a number using recursion. Go to the editor
    //Test Data :
    //Input any number : 12345
    //Expected Output :
    //The number 12345 contains number of digits : 5
    internal class CountOfDigitsInNumber
    {
        static public int CountOfDigits(int number) 
        {
            if ( number == 0) return 0;
            return CountOfDigits(number / 10) + 1;
        }
    }
}
