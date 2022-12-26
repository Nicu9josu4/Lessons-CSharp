namespace Multithreading // Потоки
{
    internal class Threads
    {
        internal static void Main()
        {
            Thread currentThread = Thread.CurrentThread; // Create a new thread
            Console.WriteLine(currentThread.Name); // print thread name
            currentThread.Name = "Thread001"; // set a new name for thread
            Console.WriteLine(currentThread.Name);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Thread myThread1 = new(PrintMessage); // Pentru a chema metoda este necesar doar de creat un Thread cu numele acestei metode
            Thread myThread2 = new(new ThreadStart(PrintMessage1));
            Thread myThread3 = new(() => Console.WriteLine("Thread n.3"));

            myThread1.Start("Thread n.1"); // ca parametri de trimitere contine un text
            myThread2.Start();
            myThread3.Start();

            static void PrintMessage(object? message) => Console.WriteLine(message);
            static void PrintMessage1() => Console.WriteLine("Thread n.2");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            #region Crearea si pornirea a 5 firuri concomitent

            int x = 0;
            object propka = new(); // Obiectul care va stopa executarea firurilor concomitent

            // Pornim 5 Firuri
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";   // Adaugam un nume pentru Fire
                myThread.Start();
            }

            void Print()
            {
                lock (propka) // pentru ca fiecare Fir sa-si execute lucrul intr-un rand
                {
                    x = 1; // Pentru ca fiecare Fir sa se inceapa numerotarea de la cifra 1
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                        Thread.Sleep(100);
                    }
                }
            }

            #endregion Crearea si pornirea a 5 firuri concomitent
        }
    }
}