﻿using System.Reflection.PortableExecutable;
using System.Threading;

namespace Multithreading // Потоки
{
    /*
     * Un flux este definit ca calea de execuție a unui program. 
     * Fiecare thread definește un flux unic de control. 
     * Dacă aplicația implică operații complicate și consumatoare de timp, 
     *  atunci este util să setați diferite căi de execuție sau fluxuri de execuție, 
     *  fiecare flux de execuție efectuând o anumită sarcină.
     */
    internal class Threads
    {
        internal static void Main1()
        {
            Thread currentThread = Thread.CurrentThread; // Create a new thread
            Console.WriteLine("Created name:" + currentThread.Name); // print thread name
            currentThread.Name = "Thread001"; // set a new name for thread
            Console.WriteLine("After adding name:" + currentThread.Name); // print thread name

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

            #region Crearea si pornirea a 5 fluxuri unul dupa altul

            int x = 0;
            object locker = new(); // Obiectul care va stopa executarea fluxurilor concomitent

            #region UseLocker

            // Pornim 5 Fluxuri
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(PrintWithLocker);
                myThread.Name = $"Fluxul {i}";   // Adaugam un nume pentru Flux
                myThread.Start();
            }
            void PrintWithLocker()
            {
                lock (locker) // pentru ca fiecare Flux sa-si execute lucrul intr-un rand
                {
                    x = 1; // Pentru ca fiecare Flux sa se inceapa numerotarea de la cifra 1
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                        Thread.Sleep(100);
                    }
                }
            }

            #endregion
            #region UseMonitors

            // Pornim 5 Fluxuri
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(PrintWithMonitor)
                {
                    Name = $"Fluxul {i}"   // Adaugam un nume pentru Flux
                };
                myThread.Start();
            }

            void PrintWithMonitor()
            {
                bool acquiredLock = false;
                try
                {
                    Monitor.Enter(locker, ref acquiredLock);
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                        Thread.Sleep(100);
                    }
                }
                finally
                {
                    if (acquiredLock) Monitor.Exit(locker);
                }
            }

            #endregion
            #region Use Mutex

            Mutex mutexObj = new();
            // Pornim 5 Fluxuri
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(PrintWithMutex)
                {
                    Name = $"Fluxul {i}"   // Adaugam un nume pentru Flux
                };
                myThread.Start();
            }

            void PrintWithMutex()
            {
                mutexObj.WaitOne();     // приостанавливаем поток до получения мьютекса
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
                mutexObj.ReleaseMutex();    // освобождаем мьютекс
            }

            #endregion
            #region UseSemaphore
            Semaphore sem = new Semaphore(3, 3);
            // Pornim 5 Fluxuri
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Read)
                {
                    Name = $"Fluxul {i}"   // Adaugam un nume pentru Flux
                };
                myThread.Start();
            }

            void Read()
            {
                sem.WaitOne();  // ожидаем, когда освободиться место

                Console.WriteLine($"{Thread.CurrentThread.Name} intra");

                Console.WriteLine($"{Thread.CurrentThread.Name} sta la masa");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} iese");

                sem.Release();  // освобождаем место

                Thread.Sleep(1000);
            }

            #endregion

            #endregion Crearea si pornirea a 5 fluxuri concomitent
        }
    }
}