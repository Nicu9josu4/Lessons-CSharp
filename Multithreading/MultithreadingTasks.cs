using System.Text;

namespace Multithreading
{
    internal class MultithreadingTasks
    {
        internal static void MainTasks()
        {
            //PrintNumbers();
            //FactorialOfLargeNumber(6);
            //GetMaxAndMin(200);
            //SortList(200);
            GetText();

        }
        
        //  Create a program that starts two threads to print the numbers 1 to 100, where one thread prints the odd numbers and the other prints the even numbers.
        #region Создайте программу, которая запускает два потока для печати чисел от 1 до 100, где один поток печатает нечетные числа, а другой печатает четные числа.

        internal static void PrintNumbers()
        {
            Thread printOddThread = new (PrintOdd);
            Thread printEvenThread = new (PrintEven);
            printOddThread.Start();
            printEvenThread.Start();
            
        }
        internal static void PrintOdd()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1) Console.WriteLine(" Odd: " + i);
                //Thread.Sleep(i);
            }
            
        }
        internal static void PrintEven()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0) Console.WriteLine("Even: " + i);
                //Thread.Sleep(i);
            }
        }

        #endregion
        //  Create a program that uses multiple threads to process a large amount of data, where each thread is responsible for processing a portion of the data.
        #region Создайте программу, использующую несколько потоков для обработки большого объема данных, где каждый поток отвечает за обработку части данных.



        #endregion
        //  Develop a program that uses multiple threads to calculate the factorial of a large number, where each thread is responsible for calculating a portion of the factorial.
        #region Разработайте программу, использующую несколько потоков для вычисления факториала большого числа, где каждый поток отвечает за вычисление части факториала.
        internal static void FactorialOfLargeNumber(int factorialOf)
        {
            int numberOfThreads = (factorialOf / 3) < 3 ? factorialOf / 3 : factorialOf % 3 ;
            int factorial = 1;
            while (factorialOf > 0)
            {
                Thread thread = new(() =>
                {
                    factorial *= PartOfFactorial(factorialOf, factorialOf -= numberOfThreads);
                });
                thread.Start();
            }
            Console.WriteLine(factorial);

        }
        internal static int PartOfFactorial(int start, int end)
        {
            int fact = 1;
            for (int i = start; i > end; i--) fact *= i;
            return fact;
        }

        #endregion
        //  Create a program that uses multiple threads to generate random numbers and keep track of the maximum and minimum values generated.
        #region Создайте программу, которая использует несколько потоков для генерации случайных чисел и отслеживает сгенерированные максимальные и минимальные значения.

        internal static void GetMaxAndMin(int numbers) // how many numbers
        {
            Random random = new();
            int max = int.MinValue, min=int.MaxValue, num;
            for(int i = 0; i < numbers; i++)
            {
                new Thread(() =>
                {
                    num = random.Next(0, 5000);
                    if(num < min) min = num;
                    if(num > max) max = num;
                    Console.WriteLine("Created number is: " + num);
                }).Start();
            }
            Thread.Sleep(100);
            Console.WriteLine("Max number is: " + max + " Min number is: " + min);
        }

        #endregion
        //  Develop a program that uses multiple threads to sort a large list of numbers, where each thread is responsible for sorting a portion of the list.
        #region Разработайте программу, которая использует несколько потоков для сортировки большого списка чисел, где каждый поток отвечает за сортировку части списка.

        internal static void SortList(int n)
        {
            Random random = new();
            List<int> list = new();
            for (int i = 0; i < n; i++) list.Add(random.Next(100, 1000));
            Thread[] threads = new Thread[list.Count];
            for (int i = 0;i < list.Count; i++)
            {
                new Thread(() => 
                {
                    list.ToArray();
                    for(int j = 0; j < list.Count-1; j++)
                    {
                        if (list[j] > list[j+1])
                        {
                            (list[j], list[j + 1]) = (list[j + 1], list[j]);
                        }
                    }
                }).Start();
                //Thread.Sleep(1);
            }
            list.ToList();
            foreach (var element in list) Console.Write(element + ",");

        }

        #endregion
        //  Create a program that uses multiple threads to search for a specific word in a large text file, where each thread is responsible for searching a portion of the file.
        #region Создайте программу, которая использует несколько потоков для поиска определенного слова в большом текстовом файле, где каждый поток отвечает за поиск части файла.

        internal static void GetText()
        {
            string text = File.ReadAllText("D:\\VisualStudio Projects\\Lessons-CSharp\\Multithreading\\Text.txt", Encoding.UTF8);
            string[] lines = text.Split('\n');
            int numOfFinds = 0;
            string word = "m";
            for (int i=0;i<lines.Length - 1;i++)
            {
                Thread thread = new(() =>
                {
                    numOfFinds += SearchFromText(lines[i], word);
                });
                thread.Start();
                thread.Join(); // Sincronizeaza fluxurile programului
            }
            Console.WriteLine(numOfFinds);
            //Console.WriteLine(text);
        }
        internal static int SearchFromText(string str, string word)
        {
            return str.Split(" ")
                .Count(words => words.Contains(word));
        }

        #endregion
        //  Develop a program that uses multiple threads to perform a web request and return the response, where each thread is responsible for performing a separate request. 
        #region Разработайте программу, использующую несколько потоков для выполнения веб-запроса и возврата ответа, где каждый поток отвечает за выполнение отдельного запроса.



        #endregion
    }
}
