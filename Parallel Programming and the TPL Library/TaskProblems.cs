using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Parallel_Programming_and_the_TPL_Library
{
    internal class TaskProblems
    {
        internal static void MainTaskProblems()
        {
            //DeadLock();
            //FibonacciNumbers(33);
            UseHttpRequestAsync();
        }

        #region TaskExercices


        // Create a program that uses a task to perform a background calculation, such as calculating prime numbers or finding the nth Fibonacci number.
        #region Создайте программу, которая использует задачу для выполнения фоновых вычислений, таких как вычисление простых чисел или нахождение n-го числа Фибоначчи.

        internal static void FibonacciNumbers(int n)
        {
            // 0, 1, 1, 2, 3, 5, 8, 13, 21...
            Task getNumbers = Task.Run(() => GetFibonacciNumbers(n));
            Task sumNumbers = Task.Factory.StartNew(() => 
            {
                int sum = 0;
                for (int i = 0; i < n; i++) sum += (i + n) / 2;
                Task printSum = Task.Factory.StartNew(() => { Console.WriteLine("\nSum numbers is: " + sum); }, TaskCreationOptions.AttachedToParent);
            });
            Task.WaitAll(getNumbers, sumNumbers);
        }
        internal static void GetFibonacciNumbers(int n, int numbers = 0, int lastNumber = 1)
        {
            if (n == 0) return;
            Console.Write(numbers + " ");
            GetFibonacciNumbers(n - 1, numbers + lastNumber, numbers);
        }

        #endregion
        // Develop a program that uses multiple tasks to perform a data scraping, where each task is responsible for scraping a portion of the data.
        #region Разработайте программу, которая использует несколько задач для очистки данных, где каждая задача отвечает за очистку части данных.



        #endregion
        // Create a program that uses a task to perform a network communication, such as sending an HTTP request or receiving data over a socket connection.
        #region Создайте программу, которая использует задачу для выполнения сетевого взаимодействия, такого как отправка HTTP-запроса или получение данных через соединение через сокет.

        internal static async void UseHttpRequestAsync()
        {

            HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Student of TUM");

            await ProcessRepositoriesAsync(httpClient);

            
        }
        static async Task ProcessRepositoriesAsync(HttpClient client)
        {
            var json = await client.GetStringAsync("https://en.wikipedia.org/wiki/Signal_Corps_in_the_American_Civil_War");

            Console.WriteLine(json);
        }
        static async Task GetAsync(HttpClient httpClient)
        {
            using var response = await httpClient.GetAsync("todos/3");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");

            // Expected output:
            //   GET https://jsonplaceholder.typicode.com/todos/3 HTTP/ 1.1
            //   {
            //     "userId": 1,
            //     "id": 3,
            //     "title": "fugiat veniam minus",
            //     "completed": false
            //   }

        }

        #endregion
        // Develop a program that uses tasks to perform a data visualization, where each task is responsible for visualizing a portion of the data.
        #region Разработайте программу, которая использует задачи для визуализации данных, где каждая задача отвечает за визуализацию части данных.



        #endregion
        // Create a program that uses tasks to perform a data compression, where each task is responsible for compressing a portion of the data.
        #region Создайте программу, которая использует задачи для сжатия данных, где каждая задача отвечает за сжатие части данных.



        #endregion
        // Develop a program that uses tasks to perform a data encryption, where each task is responsible for encrypting a portion of the data.
        #region Разработайте программу, которая использует задачи для выполнения шифрования данных, где каждая задача отвечает за шифрование части данных.



        #endregion
        // Create a program that uses tasks to perform a data migration, where each task is responsible for migrating a portion of the data.
        #region Создайте программу, которая использует задачи для переноса данных, где каждая задача отвечает за перенос части данных.



        #endregion
        // Develop a program that uses tasks to perform a machine learning task, such as training a model or making predictions, where each task is responsible for performing a portion of the task.
        #region Разработайте программу, которая использует задачи для выполнения задачи машинного обучения, такой как обучение модели или создание прогнозов, где каждая задача отвечает за выполнение части задачи.



        #endregion
        // Create a program that uses tasks to perform a financial calculation, such as calculating interest or performing a budget analysis, where each task is responsible for performing a portion of the calculation.
        #region Создайте программу, которая использует задачи для выполнения финансовых расчетов, таких как расчет процентов или выполнение анализа бюджета, где каждая задача отвечает за выполнение части расчета.



        #endregion
        // Develop a program that uses tasks to perform a data indexing, where each task is responsible for indexing a portion of the data.
        #region Разработайте программу, которая использует задачи для выполнения индексации данных, где каждая задача отвечает за индексацию части данных.



        #endregion

        #endregion

        #region TaskErrors

        // Deadlocks: Tasks can potentially cause deadlocks if they are not managed properly. This can occur when two or more tasks are waiting for each other to complete, resulting in a situation where the tasks cannot progress.
        #region Взаимоблокировки: задачи потенциально могут вызывать взаимоблокировки, если они не управляются должным образом. Это может произойти, когда две или более задач ожидают завершения друг друга, что приводит к ситуации, когда задачи не могут выполняться.

        public static void DeadLock()
        {
            object lock1 = new(), lock2 = new();
            Console.WriteLine("Starting...");
            var task1 = Task.Run(() => // Pornirea primului task
            {
                lock (lock1) // Folosirea unui obiect de stopare pentru ca sa se finalizeze executia apoi sa treaca la urmatorul task
                {
                    Thread.Sleep(1000);
                    lock (lock2) // Folosirea unui obiect de stopare pentru ca sa se finalizeze executia apoi sa treaca la urmatorul task
                    {
                        Console.WriteLine("Finished Thread 1");
                    }
                }
            });

            var task2 = Task.Run(() =>
            {
                lock (lock2)
                {
                    Thread.Sleep(1000);
                    lock (lock1)
                    {
                        Console.WriteLine("Finished Thread 2");
                    }
                }
            });

            Task.WaitAll(task1, task2); // Metoda WaitAll permite ca Taskurile create anterior sa fie executate pana la capat,
                                        // Apoi sa se termine task-ul principal
                                        // In cazul dat este o problema de neeliberare a obiectului de blocare.
                                        // Din acest motiv executarea task-urilor nu poate fi finalizata
            Console.WriteLine("Finished...");
        }

        #endregion
        // Performance Overhead: Creating and managing tasks can incur a performance overhead, especially if a large number of tasks are used. This can lead to reduced application performance and longer response times.
        #region Накладные расходы на производительность. Создание задач и управление ими может привести к снижению производительности, особенно если используется большое количество задач.Это может привести к снижению производительности приложений и увеличению времени отклика.

        #endregion
        // Exception Handling: Task exceptions can be difficult to handle, especially if the task is running in the background. This can lead to unhandled exceptions that may crash the application.
        #region Обработка исключений. Обработка исключений задачи может быть затруднена, особенно если задача выполняется в фоновом режиме. Это может привести к необработанным исключениям, которые могут привести к сбою приложения.

        #endregion
        // Task Scheduling: Tasks are scheduled by the.NET runtime, which can lead to unpredictable behavior and result in tasks not being executed in the order they were created.
        #region Планирование задач. Задачи планируются средой выполнения .NET, что может привести к непредсказуемому поведению и привести к тому, что задачи не будут выполняться в том порядке, в котором они были созданы.

        #endregion
        // Task Leaks: If tasks are not properly cleaned up, they can cause memory leaks, leading to increased memory usage and potentially affecting application performance.
        #region Утечки задач: если задачи не очищены должным образом, они могут вызвать утечку памяти, что приведет к увеличению использования памяти и может повлиять на производительность приложения.

        #endregion
        // Synchronization: Synchronizing tasks can be challenging, especially if the tasks are running in parallel and accessing shared resources.This can result in race conditions and incorrect behavior.
        #region Синхронизация.Синхронизация задач может быть сложной задачей, особенно если задачи выполняются параллельно и имеют доступ к общим ресурсам. Это может привести к условиям гонки и неправильному поведению.

        #endregion
        // Debugging: Debugging multithreaded applications can be difficult, as it may not be immediately clear which task is causing an issue or where the problem is occurring.
        #region Отладка.Отладка многопоточных приложений может быть затруднена, так как может быть не сразу ясно, какая задача вызывает проблему или где возникает проблема.

        #endregion
        // Thread Pool Exhaustion: If too many tasks are created, the thread pool can become exhausted, leading to reduced performance and longer response times.
        #region Исчерпание пула потоков: если создается слишком много задач, пул потоков может быть исчерпан, что приведет к снижению производительности и увеличению времени отклика.

        #endregion
        // Cancellation: Cancelling tasks can be difficult, especially if the task is running in the background and performing a long-running operation.This can result in the task continuing to execute, even after it has been cancelled.
        #region Отмена.Отмена задач может быть затруднена, особенно если задача выполняется в фоновом режиме и выполняет длительную операцию.Это может привести к тому, что задача будет продолжать выполняться даже после ее отмены.

        #endregion
        // Parallelism: Parallelism is not always appropriate, and using tasks in a single-threaded application can lead to reduced performance and longer response times.
        #region Параллелизм.Параллелизм не всегда уместен, а использование задач в однопоточном приложении может привести к снижению производительности и увеличению времени отклика.

        #endregion

        #endregion

        
    }
}
