using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Exercices
{
    //14. Write a program in C# Sharp to get the reverse of a string using recursion. Go to the editor
    //Test Data :
    //Input the string : w3resource
    //Expected Output :
    //The reverse of the string is : ecruoser3w
    internal class ReverseString
    {
        internal static void Reverse(string str, int position = 0)
        {
            if (position == str.Length - 1) { Console.Write(str[position]); return; }
            Reverse(str, position + 1);
            Console.Write(str[position]);
        }
    }
}
