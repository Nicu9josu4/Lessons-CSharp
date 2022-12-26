namespace Parallel_Programming_and_the_TPL_Library
{
    internal class ParallelTasks
    {
        //internal static void Main(string[] args)
        //{
        //    Console.WriteLine("------>Parallel.Invoke()<------\n");
        //    Parallel.Invoke(
        //    Print,
        //    () =>
        //        {
        //            Console.WriteLine($"Progress of task: {Task.CurrentId}");
        //            Thread.Sleep(3000);
        //        },
        //    () => Square(5)
        //    ); // Se pornesc toate simultan

        //    Console.Clear();
        //    Console.WriteLine("------>Paralel.For()<------ \n");

        //    Parallel.For(1, 5, SquareFor);

        //    Console.Clear();
        //    Console.WriteLine("------>Paralel.ForEach()<------ \n");

        //    ParallelLoopResult result = Parallel.ForEach<int>(
        //        new List<int>() { 1, 3, 5, 8 }, SquareForEach);

        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //    void Print()
        //    {
        //        Console.WriteLine($"Progress of task: {Task.CurrentId}");
        //        Thread.Sleep(3000);
        //    }
        //    // Aflam patratul numarului "n"
        //    void Square(int n)
        //    {
        //        Console.WriteLine($"Progress of task: {Task.CurrentId}");
        //        Thread.Sleep(2000); // Simularea unui lucru greu
        //        Console.WriteLine($"Result: {n} * {n} = {n * n}");
        //    }
        //    void SquareFor(int n)
        //    {
        //        Console.WriteLine($"Progress of task: {Task.CurrentId}");
        //        Console.WriteLine($"Result: {n} * {n} = {n * n}");
        //        Thread.Sleep(3000); // Simularea unui lucru greu
        //    }void SquareForEach(int n)
        //    {
        //        Console.WriteLine($"Progress of task: {Task.CurrentId}");
        //        Thread.Sleep(2000); // Simularea unui lucru greu
        //        Console.WriteLine($"Result: {n} * {n} = {n * n}");
        //    }
        //}
    }
}