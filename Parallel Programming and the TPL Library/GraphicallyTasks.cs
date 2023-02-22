namespace Parallel_Programming_and_the_TPL_Library
{
    internal class GraphicallyTasks
    {
        // aplicatia consola are doar un singur Task si in cazul in care creem await Task.Delay(100) si neavand alte task-uri de indeplinit, aplicatia se inchide

        public static void MainGraphicaly()
        {
            #region Gud Tasks
            Task task1 = Task.Run(async () =>
            {
                while (true)
                {
                    Console.Write(".");
                    //Thread.Sleep(10);
                    await Task.Delay(10);
                }
            });
            Task task2 = Task.Run(async () =>
            {
                while (true)
                {
                    Console.WriteLine("->");
                    //Thread.Sleep(100);
                    await Task.Delay(100);
                }
            });
            Task.WaitAll(task1, task2);

            #endregion Gud Tasks

            #region Trying Tasks

            //Task task1 = new(() => { Method(); });
            //task1.Start();
            //Task task2 = new(() => { Method(); });
            //task2.Start();
            //task1.Wait();
            //task2.Wait();

            #endregion Trying Tasks
        }

        #region Trying methods with async

        //public static void Method()
        //{
        //    //await Task.Run(() =>
        //    //{
        //    while (true)
        //    {
        //        Console.Write(".");
        //        Thread.Sleep(100);
        //    }
        //    //});
        //}
        //public static void MethodNewLine()
        //{
        //    //await Task.Run(() =>
        //    //{
        //    while (true)
        //    {
        //        Console.WriteLine();
        //        Thread.Sleep(10000);
        //    }
        //    //});

        //}

        #endregion Trying methods with async
    }
}