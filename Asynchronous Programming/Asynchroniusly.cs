using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    internal class Asynchroniusly
    {
        internal static void MainAsync()
        {
            int i = 0;
            CancellationTokenSource cts = new CancellationTokenSource();
            while (i != 10)
            {
                Console.WriteLine("Porniti metoda care o doriti:");
                i = Convert.ToInt32(Console.ReadLine());
                Method(i, cts);
            }
            cts.Cancel();


            Console.ReadLine();

        }
        internal static async void Method(int n, CancellationTokenSource cts)
        {
            while (!cts.IsCancellationRequested)
            {
                Console.WriteLine("Metoda nr." + n + " Ruleaza");
                await Task.Delay(1500);
            }
            Console.WriteLine($"Metoda nr.{n} s-a finalizat din cauza opririi cts");
        }
    }
}
