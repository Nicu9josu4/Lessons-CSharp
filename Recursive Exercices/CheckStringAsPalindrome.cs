using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //8. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion. Go to the editor
    //Test Data :
    //Input a string : RADAR
    //Expected Output :
    //The string is Palindrome.
    internal class CheckStringAsPalindrome
    {
        internal static void CheckString(string str, int i = 0)
        {
            if (i == str.Length / 2) { Console.WriteLine($"String {str} is a palindrome"); return; }
            if (str[i] == str[^(i + 1)]) CheckString(str, i + 1);
            else { Console.WriteLine($"String {str} is not a palindrome");  return; }
        }
    }
}
