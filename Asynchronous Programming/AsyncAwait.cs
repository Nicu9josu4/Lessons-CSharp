//internal class AsyncAwait
//{
//    //private static void Main()
//    //{
//    //    //for(int i = 0; i < 5; i++)
//    //    Task.Run(() => { AsyncMethod(4); }).Wait();
//    //}

//    public static async Task PrintAsync(int n)
//    { Console.WriteLine("Iteration {0}", n); await Task.Delay(100); } // Ce se va intampla daca scoatem await de la Task.Delay

//    public static async void AsyncMethod(int n)
//    {
//        var task = Task.Run(async () =>
//        {
//            Console.WriteLine("Task from AsyncMethod");
//            await Task.Delay(1000);
//            for (int i = 0; i < n; i++)
//                await PrintAsync(i);
//            await Task.Run(async () =>
//            {
//                Console.WriteLine("Task from AsyncMethod.FirstTask");
//                await Task.Delay(1000);
//                for (int i = 0; i < n; i++)
//                    await PrintAsync(i);
//                await Task.Run(async () =>
//                {
//                    Console.WriteLine("Task from AsyncMethod.FirstTask.SecondTask");
//                    await Task.Delay(1000);
//                    for (int i = 0; i < n; i++)
//                        await PrintAsync(i);
//                    await Task.Run(() =>
//                    {
//                        Console.WriteLine("Task from AsyncMethod.FirstTask.SecondTask.ThirdTask");
//                        Task.Delay(1000);
//                        for (int i = 0; i < n; i++)
//                            PrintAsync(i);
//                    });
//                });
//            });
//        });
//        var task1 = Task.Run(async () =>
//        {
//            Console.WriteLine("Task from AsyncMethod");
//            await Task.Delay(1000);
//            await PrintAsync(n - 2);
//            await Task.Run(async () =>
//            {
//                Console.WriteLine("Task from AsyncMethod.FirstTask1");
//                await Task.Delay(1000);
//                await PrintAsync(n - 2);
//                await Task.Run(() =>
//                {
//                    Console.WriteLine("Task from AsyncMethod.FirstTask1.SecondTask1");
//                    Task.Delay(1000);
//                    PrintAsync(n - 2);
//                    Task.Run(() =>
//                    {
//                        Console.WriteLine("Task from AsyncMethod.FirstTask1.SecondTask1.ThirdTask1");
//                        Task.Delay(1000);
//                        PrintAsync(n - 2);
//                    });
//                });
//            });
//        });
//        var task2 = Task.Run(async () =>
//        {
//            Console.WriteLine("Task from AsyncMethod");
//            await Task.Delay(1000);
//            PrintAsync(n + 1);
//            await Task.Run(async () =>
//            {
//                Console.WriteLine("Task from AsyncMethod.FirstTask2");
//                await Task.Delay(1000);
//                PrintAsync(n + 1);
//                await Task.Run(() =>
//                {
//                    Console.WriteLine("Task from AsyncMethod.FirstTask2.SecondTask2");
//                    Task.Delay(1000);
//                    PrintAsync(n + 1);
//                    Task.Run(() =>
//                    {
//                        Console.WriteLine("Task from AsyncMethod.FirstTask2.SecondTask2.ThirdTask2");
//                        Task.Delay(1000);
//                        PrintAsync(n + 1);
//                    });
//                });
//            });
//        });
//        task.Wait();
//        task1.Wait();
//        task2.Wait();
//    }
//}