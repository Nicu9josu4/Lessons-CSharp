using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_.NET_Classes_and_Structures
{
    internal class _7_Tuples
    {
        internal static void main()
        {
            int[] array = { 1, 4, 5, 3, 8, 6, 0, 10, 13, 15, 2, 22, 23 };
            Console.WriteLine("before sorting");
            foreach (var i in array) Console.Write(i + ",");
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]); // tuples
            Console.WriteLine("\nafter sorting");
            foreach (var i in array) Console.Write(i + ",");

            var tuple = (25, 26, "Home");


        }
    }
}
