namespace Parallel_Programming_and_the_TPL_Library
{
    internal class ParallelTasks
    {
        internal static void MainParallel()
        {
            Console.WriteLine("------>Parallel.Invoke()<------\n");
            Parallel.Invoke(
            Print,
            () =>
                {
                    Console.WriteLine($"Progress of task: {Task.CurrentId}");
                    Thread.Sleep(3000);
                },
            () => Square(5)
            ); // Se pornesc toate simultan
            // se executa 3 metode diferite. Metoda Invoke permite pornirea simultan a 2 sau mai multe metode

            Console.Clear();
            Console.WriteLine("------>Paralel.For()<------ \n");

            Parallel.For(1, 5, SquareFor); // De la 1 pana la 5 executa ridicarea la putere a numerelor

            Console.Clear();
            Console.WriteLine("------>Paralel.ForEach()<------ \n");
            List<int> ints = new() { 1, 3, 5, 8 };
            ParallelLoopResult result = Parallel.ForEach(ints, SquareForEach);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            void Print()
            {
                Console.WriteLine($"Progress of task: {Task.CurrentId}");
                Thread.Sleep(3000);
            }
            // Aflam patratul numarului "n"
            void Square(int n) // Patratul din metoda Invoke
            {
                Console.WriteLine($"Progress of task: {Task.CurrentId}");
                Thread.Sleep(2000); // Simularea unui lucru greu
                Console.WriteLine($"Result: {n} * {n} = {n * n}");
            }
            void SquareFor(int n) // Patratul din metoda For
            {
                Console.WriteLine($"Progress of task: {Task.CurrentId}");
                Console.WriteLine($"Result: {n} * {n} = {n * n}");
                Thread.Sleep(3000); // Simularea unui lucru greu
            }
            void SquareForEach(int n) // Patrarul din metoda forEach
            {
                Console.WriteLine($"Progress of task: {Task.CurrentId}");
                Thread.Sleep(2000); // Simularea unui lucru greu
                Console.WriteLine($"Result: {n} * {n} = {n * n}");
            }
        }
    }
}