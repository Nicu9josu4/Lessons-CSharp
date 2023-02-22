using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    internal class AsyncHronic
    {

        /*
            Develop a program that uses async-await to perform a long-running calculation, 
                where the calculation is performed asynchronously and the result is displayed when it becomes available.
        */
        public static void MainHronic()
        {
            while (true)
            {
                // Start computation.
                WaitAsync();
                // Handle user input.
                string? result = Console.ReadLine();
                Console.WriteLine("You typed: " + result);
            }
        }
        internal async static void WaitAsync()
        {
            int t = await Task.Run( () => Allocate()); // ??????????????
            Console.WriteLine("Compute: " + t);
            return;
        }

        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }

}
