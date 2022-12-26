using System;
using Lesons_Csharp.Lessons;

namespace Lesons_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine("Select chapter:");

            Console.WriteLine(" 1 - Fundamentals of C# Programming"); 
            Console.WriteLine(" 2 - Classes, structures and namespaces");
            Console.WriteLine(" 3 - Object Oriented Programming");
            Console.WriteLine(" 4 - Exception Handling");
            Console.WriteLine(" 5 - Delegates, events and lambdas");
            Console.WriteLine(" 6 - Interfaces");
            Console.WriteLine(" 7 - Advanced OOP Features in C#");
            Console.WriteLine(" 8 - Pattern matching");
            Console.WriteLine(" 9 - Collections");
            Console.WriteLine("10 - Working with Strings Dates and Times");
            Console.WriteLine("11 - Additional .NET Classes and Structures");
            Console.WriteLine("12 - Multithreading");
            Console.WriteLine("13 - Parallel Programming and the TPL Library");
            Console.WriteLine("14 - Asynchronous Programming");
            Console.WriteLine("15 - LINQ and Parallel LINQ");
            Console.WriteLine("16 - Dynamic Language Runtime");
            Console.WriteLine("17 - Garbage Collection, Memory Management, and Pointers");
            Console.WriteLine("18 - Working with JSON and XML");
            Console.WriteLine("19 - Processes and Application Domains");
            Console.WriteLine("20 - Menu");
            Console.WriteLine(" 0 - Exit");

            while (n != 0)
            {
                //n = Console.ReadLine() is not null && Console.ReadLine() != "" ? n = 100 : n = Convert.ToInt32(Console.ReadLine());
                var temp = Console.ReadLine();
                if (int.TryParse(temp, out _))
                    if (temp != null && temp != "") n = Convert.ToInt32(temp);
                    else n = 20;
                else n = 20;
                Console.Clear();
                switch (n)
                {
                    case 0:
                        Console.WriteLine("0 - Exit");
                        break;
                    case 1:
                        Console.WriteLine("1 - Fundamentals of C# Programming");
                        Fundamentals fund = new();
                        fund.StartLesson();
                        break;
                    case 2:
                        Console.WriteLine("2 - Classes, structures and namespaces");
                        break;
                    case 3:
                        Console.WriteLine("3 - Object Oriented Programming");
                        break;
                    case 4:
                        Console.WriteLine("4 - Exception Handling");
                        break;
                    case 5:
                        Console.WriteLine("5 - Delegates, events and lambdas");
                        break;
                    case 6:
                        Console.WriteLine("6 - Interfaces");
                        break;
                    case 7:
                        Console.WriteLine("7 - Advanced OOP Features in C#");
                        break;
                    case 8:
                        Console.WriteLine("8 - Pattern matching");
                        break;
                    case 9:
                        Console.WriteLine("9 - Collections");
                        break;
                    case 10:
                        Console.WriteLine("10 - Working with Strings Dates and Times");
                        break;
                    case 11:
                        Console.WriteLine("11 - Additional .NET Classes and Structures");
                        break;
                    case 12:
                        Console.WriteLine("12 - Multithreading");
                        break;
                    case 13:
                        Console.WriteLine("13 - Parallel Programming and the TPL Library");
                        break;
                    case 14:
                        Console.WriteLine("14 - Asynchronous Programming");
                        break;
                    case 15:
                        Console.WriteLine("15 - LINQ and Parallel LINQ");
                        break;
                    case 16:
                        Console.WriteLine("16 - Dynamic Language Runtime");
                        break;
                    case 17:
                        Console.WriteLine("17 - Garbage Collection, Memory Management, and Pointers");
                        break;
                    case 18:
                        Console.WriteLine("18 - Working with JSON and XML");
                        break;
                    case 19:
                        Console.WriteLine("19 - Processes and Application Domains");
                        break;
                    case 20:
                        Console.WriteLine(" 1 - Fundamentals of C# Programming");
                        Console.WriteLine(" 2 - Classes, structures and namespaces");
                        Console.WriteLine(" 3 - Object Oriented Programming");
                        Console.WriteLine(" 4 - Exception Handling");
                        Console.WriteLine(" 5 - Delegates, events and lambdas");
                        Console.WriteLine(" 6 - Interfaces");
                        Console.WriteLine(" 7 - Advanced OOP Features in C#");
                        Console.WriteLine(" 8 - Pattern matching");
                        Console.WriteLine(" 9 - Collections");
                        Console.WriteLine("10 - Working with Strings Dates and Times");
                        Console.WriteLine("11 - Additional .NET Classes and Structures");
                        Console.WriteLine("12 - Multithreading");
                        Console.WriteLine("13 - Parallel Programming and the TPL Library");
                        Console.WriteLine("14 - Asynchronous Programming");
                        Console.WriteLine("15 - LINQ and Parallel LINQ");
                        Console.WriteLine("16 - Dynamic Language Runtime");
                        Console.WriteLine("17 - Garbage Collection, Memory Management, and Pointers");
                        Console.WriteLine("18 - Working with JSON and XML");
                        Console.WriteLine("19 - Processes and Application Domains");
                        Console.WriteLine("20 - Menu");
                        Console.WriteLine(" 0 - Exit");
                        break;
                    default: Console.WriteLine("Don't Have this Chapter"); break;
                }

            }


            //Console.ReadLine();
        }
    }
}
