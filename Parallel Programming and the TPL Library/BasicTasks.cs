using System.Runtime.CompilerServices;

namespace Parallel_Programming_and_the_TPL_Library // TPL - Task Parallel Library
{
    internal class BasicTasks
    {
        internal static void Main()
        {
            /*
                Un flux este o construcție de sistem de operare de nivel scăzut care vă permite să executați cod într-un context separat. 
                Când creați un flux în C#, îl puteți folosi pentru a rula o metodă sau un bloc de cod în fundal, 
                în timp ce fluxul principal al aplicației dumneavoastră continuă să execute alt cod.

                Un task, pe de altă parte, este o abstractizare de nivel superior care reprezintă o unitate de lucru care poate fi executată asincron. 
                Când creați un task în C#, o puteți utiliza pentru a reprezenta o operație care poate dura ceva timp pentru a finaliza, 
                cum ar fi citirea datelor dintr-un fișier sau apelarea unui serviciu web.
             */


            //TaskProblems.MainTaskProblems(); // Task problems
            //ParallelTasks.MainParallel(); // using Parallel exemples
            //GraphicallyTasks.MainGraphicaly(); // ??????
            //CancelationToken.MainCT(); // using Cancellation Token examples

            //Task<int> task1 = new(() => MyMethod(12));
            //task1.Start();

            //Task<int> task2 = Task.Factory.StartNew(() => MyMethod(12));

            //Task<int> task3 = Task.Run(() => MyMethod(12));

            //task1.Wait();   // Asteptarea finalizarii taskului
            //task2.Wait();   // Asteptarea finalizarii taskului
            //task3.Wait();   // Asteptarea finalizarii taskului


            // ---> Use WhenAll to wait all tasks before Main method is end <---
            //Task.WaitAll(task1,task2,task3);
            //Console.WriteLine("Tasks are complete");
            //MethodAsync();

            // ---> Use WhenAny to wait one of tasks before Main method is end <---
            //      WhenAny has return a value
            //Task<int> variableTask = await Task.WhenAny(task1,task2,task3);
            //Console.WriteLine(variableTask.Result);


            #region Methods to Catch exceptions from tasks

            //try // Catch an exception when create a task
            //{
            //    Task<int> task = Task.Run(() =>
            //    {
            //        int zero = 0;
            //        var value = (1 + 2) / zero;
            //        return 42;
            //    });

            //    int result = task.Result; // This line may throw an exception

            //    // Use the result here
            //}
            //catch (AggregateException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Task<int> task1 = Task.Run(() =>
            //{
            //    int zero = 0;
            //    var value = (1 + 2) / zero;
            //    return 42;
            //});

            //task1.ContinueWith(t => // Catch an exception with ContinueWith 
            //{
            //    if (t.Exception != null)
            //    {
            //        Console.WriteLine("Is an exception");
            //    }
            //    else
            //    {
            //        int result = t.Result;
            //        Console.WriteLine(result);
            //    }
            //});

            #endregion

        }

        internal static async void MethodAsync()
        {
            while (true)
            {
                Task<int> task1 = Task.Run(() => MyMethod(0));
                Task<int> task2 = Task.Run(() => MyMethod(1));
                Task<int> task3 = Task.Run(() => MyMethod(2));
                Task<int> variableTask = await Task.WhenAny(task1, task2, task3);
                Console.WriteLine(variableTask.Result);
            }
        }

        internal static int MyMethod(int n)
        {
            return 1+n;
        }
    }


}