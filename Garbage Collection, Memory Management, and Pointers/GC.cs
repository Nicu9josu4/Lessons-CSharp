using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection__Memory_Management__and_Pointers
{
    internal class GarbageColector
    {
        internal static void Main()
        {
            Console.WriteLine("To run an EMPTY PROJECT we used " + GC.GetTotalMemory(false) + " bytes"); // verificarea memoriei folosite pentru a porni acest program

            for(int i = 1; i < 100000000; i++) // imitarea unei munci grele a programului
            {
                var obj = (object)i; // Boxing a value
                int j = (int)obj;
            }
            Console.WriteLine("To EXECUTE OPERATIONS we use    " + GC.GetTotalMemory(false) + " bytes"); // verificarea memoriei folosite dupa efectuarea unei iteratii de la 1 la 10000

            GC.Collect(); // Colectarea memoriei nefolosite, eliberarea 

            Console.WriteLine("Memory after GC.Collect:        " + GC.GetTotalMemory(false) + " bytes");


            using(Product product = new()) // To use "using" for any class, We need to implement IDisposable interface
            {
                product.Name = "Test";
                Console.WriteLine(product.Name);
            }
        }
    }

    internal class Product: IDisposable 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Dispose()
        {
            Console.WriteLine(Name + " Has disposed");
        }
    }
}
