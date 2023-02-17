namespace Parallel_Programming_and_the_TPL_Library
{
    internal class CancelationToken
    {
        internal static void MainCT()
        {
            CancellationTokenSource cts = new();
            CancellationToken ct = cts.Token;
            //Task task = new(() => { Console.WriteLine("hello you"); }, ct); //
            //task.Start();
            //Thread.Sleep(1000);
            //Thread.Sleep(1000);
            //cts.Cancel();
            //Console.WriteLine($"Task Status: {task.Status}");

            Task task1 = new(() =>
            {
                int i = 0;
                while (true)
                {
                    if (i % 10 == 0) Console.Write("\n");
                    Console.Write("*"); Console.Write("-");
                    Thread.Sleep(10);
                    i++;
                }
            }, ct);
            task1.Start();
            Thread.Sleep(1000);
            // Dupa ce se termina timpul se va inchide Tokenul
            cts.Cancel();
            // Asteptam finalizarea task-ului
            Thread.Sleep(1000);
            Console.WriteLine($"Task Status: {task1.Status}");
            
            cts.Dispose(); // Eliberam resursele
        }
    }
}