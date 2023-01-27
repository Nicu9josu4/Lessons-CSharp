using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_.NET_Classes_and_Structures
{
    internal class _7_Tuples
    {
        internal static void Main()
        {
            int[] array = { 1, 4, 5, 3, 8, 6, 0, 10, 13, 15, 2, 22, 23 };
            Console.WriteLine("After sorting");
            foreach(var i in array)  Console.Write(i+","); 
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++) 
                    if(array[j] > array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]); // Tuples
            Console.WriteLine("\nBefore sorting");
            foreach (var i in array) Console.Write(i + ",");

        }
    }
}
