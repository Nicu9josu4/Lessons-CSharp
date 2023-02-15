namespace Parallel_Programming_and_the_TPL_Library // TPL - Task Parallel Library
{
    internal class BasicTasks
    {
        internal static void Main()
        {
            //TaskProblems.MainTaskProblems(); // Task problems
            //ParallelTasks.MainParallel(); // using Parallel exemples
            //GraphicallyTasks.MainGraphicaly();
            CancelationToken.MainCT(); // using Cancellation Token examples

            //Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
            //task1.Start();

            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

            //Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

            //task1.Wait();   // Asteptarea finalizarii taskului
            //task2.Wait();   // Asteptarea finalizarii taskului
            //task3.Wait();   // Asteptarea finalizarii taskului
        }
    }
}