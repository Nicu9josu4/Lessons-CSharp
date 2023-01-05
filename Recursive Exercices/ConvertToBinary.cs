using System.ComponentModel;

namespace Recursive_Exercices
{
    internal class ConvertToBinary
    {
        //13. Write a program in C# Sharp to convert a decimal number to binary using recursion. Go to the editor
        //Test Data :
        //Input a decimal number : 66
        //Expected Output :
        //The binary equivalent of 66 is : 1000010
        internal static void Convertor(int number)
        {
            if (number == 1) { Console.Write(number % 2); return; }
            Convertor(number / 2);
            Console.Write(number % 2);
        }
    }
}
