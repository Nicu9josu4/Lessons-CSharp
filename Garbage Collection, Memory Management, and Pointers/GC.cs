using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection__Memory_Management__and_Pointers
{
    internal class GarbageColector
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Empty Project: " + GC.GetTotalMemory(false) + "cm"); // verificarea memoriei folosite pentru a porni acest program

            for(int i = 1; i < 10000; i++) // imitarea unei munci grele a programului
            {
                var obj = (object)i; // Boxing a value
                int j = (int)obj;
            }
            Console.WriteLine("Memory after iterations: " + GC.GetTotalMemory(false) + "cm"); // verificarea memoriei folosite dupa efectuarea unei iteratii de la 1 la 10000

            GC.Collect(); // Colectarea memoriei nefolosite, eliberarea 

            Console.WriteLine("Memory after GC.Collect: " + GC.GetTotalMemory(false) + "cm");

            Console.ReadLine();
        }
    }
}
