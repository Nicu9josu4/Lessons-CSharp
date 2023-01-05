using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Recursive_Exercices
{
    internal class PermutationOfArray
    {
        //11. Write a program in C# Sharp to generate all possible permutations of an array using recursion. Go to the editor
        //Test Data :
        //Input the number of elements to store in the array[maximum 5 digits] :3
        //Input 3 number of elements in the array :
        //element - 0 : 1
        //element - 1 : 2
        //element - 2 : 3
        //Expected Output :
        //The Permutations with a combination of 3 digits are :
        //123 132 213 231 321 312
        static List<int[]> result = new();
        internal static void Permutation(int[] numbers, int position = 0)
        {
            int[] tempArray = new int[numbers.Length];
            if (position == numbers.Length - 1) 
            {
                foreach(var rez in result)
                {
                    foreach (int i in rez)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                return;
            } 
            for(int i = position; i < numbers.Length - 1; i++)
            {
                result.Add(numbers);
                (numbers[i + 1], numbers[i]) = (numbers[i], numbers[i + 1]);
                Permutation(numbers, position + 1);
                result.Add(numbers);
                (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
            }
        }
    }
}
