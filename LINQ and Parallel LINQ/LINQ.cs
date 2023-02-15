using Microsoft.VisualBasic;
using static System.Reflection.Metadata.BlobBuilder;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace LINQ
{
    internal class Linq
    {
        internal static void Main()
        {
            //StudentOrder();
            //TopProducts(3);
            GroupAndSumTransactions();
            //AvearageSalary();
            //UnicalElements(22);
            //SecondHighestMark(50);
            //JoinTwoLists("a");
            //OccurrenceNumber();
            //FindTemperature(7);
            //GroupBooks(24);

            /*
                         foreach (var str in GetSortedWords("A box of biscuits, a box of mixed biscuits, and a biscuit mixer."))
                        {
                            Console.WriteLine(str);
                        }
                        foreach (var str in GetSortedWords("Each Easter Eddie eats eighty Easter eggs."))
                        {
                            Console.WriteLine(str);
                        }
             */

        }
        // Use LINQ to select and order a list of students by their grades.
        #region Используйте LINQ, чтобы выбрать и упорядочить список учащихся по их оценкам.

        internal static void StudentOrder()
        {
            List<Student> students = new()
            {
                new Student()
                {
                    Name = "Misha",
                    Grades = {5.3, 7.5, 9.3, 10, 5}
                },
                new Student()
                {
                    Name = "Alex",
                    Grades = {7.8, 8.2, 10, 4.99, 8.9}
                },
                new Student()
                {
                    Name = "Nona",
                    Grades = {9.88, 7.4, 10, 10, 6.00}
                },
                new Student()
                {
                    Name = "Amidam",
                    Grades = {8.5, 7.1, 7.00, 9.00, 10}
                },
            };

            // Sort Students by avearage grades
            students = students
                .OrderBy(student => student.GradeAvearage())
                .ToList();
            // Print students
            foreach(Student student in students)
            {
                Console.WriteLine(student.Name + " have grade: " + student.GradeAvearage());
            }

        }

        #endregion
        // Use LINQ to find the top N items in a list of products based on their sales.
        #region Используйте LINQ, чтобы найти первые N элементов в списке продуктов на основе их продаж.

        internal static void TopProducts(int n)
        {
            int m = n;
            List<Product> products = new()
            {
                new Product(){ Name = "Milk", SaledCount = 521},
                new Product(){ Name = "Floor", SaledCount = 123},
                new Product(){ Name = "Eggs", SaledCount = 334},
                new Product(){ Name = "CocaCola", SaledCount = 654},
                new Product(){ Name = "Shweps", SaledCount = 290},
                new Product(){ Name = "Beer", SaledCount = 788},
                new Product(){ Name = "Bread", SaledCount = 1255},
                new Product(){ Name = "Mouse", SaledCount = 12},
                new Product(){ Name = "Tea", SaledCount = 144},
                new Product(){ Name = "Paper", SaledCount = 501},
            };
            var topProducts = products
                .Where(product => n-- > 0) // Get top n elements
                .OrderByDescending(product => product.SaledCount) // Sort list
                .OrderBy(product => product.SaledCount) // Sort list
                .ToList(); // Returning values by list

            var bestProducts = (from product in products
                                orderby product.SaledCount descending
                                where m-- > 0
                                select product).ToList();
            foreach (Product product in bestProducts)
            {
                Console.WriteLine($"{product.Name} saled {product.SaledCount} times");
            }
        }

        #endregion
        // Use LINQ to group a list of transactions by the month and sum the total amount for each month.
        #region Используйте LINQ, чтобы сгруппировать список транзакций по месяцам и суммировать общую сумму за каждый месяц.

        internal static void GroupAndSumTransactions()
        {
            Random random = new();
            List<Transaction> transactions = new()
            {
                new Transaction()
                {
                    Description = "To buy a computer",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "For some Distractions",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "For something Else",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To pay courses",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To update your library",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "Buy a cake",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "Get salary",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To buy a computer",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "For some Distractions",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "For something Else",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To pay courses",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To update your library",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "Buy a cake",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "Get salary",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To buy a computer",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "For some Distractions",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "For something Else",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To pay courses",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "To update your library",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "Buy a cake",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
                new Transaction()
                {
                    Description = "Get salary",
                    Amount = random.Next(100,10000),
                    Date = RandomDate()
                },
            };

            var groupedTransactions = transactions
            .OrderBy(transaction => transaction.Date.Month)
            .GroupBy(transaction => transaction.Date.Month)
            .Select(groupTransaction => 
                new
                {
                    Description = "Grouped transaction ", 
                    Amount = groupTransaction.Sum(transaction => transaction.Amount), 
                    Date = groupTransaction.Select(transaction => transaction.Date),
                })
            .ToList();

            foreach(var transaction in groupedTransactions)
            {
                Console.WriteLine($"{transaction.Date.First()} - {transaction.Amount}");
            }
        }
        internal static DateOnly RandomDate()
        {
            DateTime start = new(2022, 1, 1);
            Random gen = new();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return DateOnly.FromDateTime(start.AddDays(gen.Next(range)));
        }

        #endregion
        // Use LINQ to find the average salary of employees in each department.
        #region Используйте LINQ, чтобы найти среднюю зарплату сотрудников в каждом отделе.

        enum Departments
        {
            Technology,
            CallCenter,
            PeopleAndComunications,
            BusinessInteligents,
            Admin,
            Security,
        }
        internal static void AvearageSalary()
        {
            Random random = new();
            Type enumType = typeof(Departments); // Luam tipul Enum
            Array enumValues = enumType.GetEnumValues(); // Creem un array in care includem toate campurile tipului Enum si ii atribuim in index
            int i = 1;
            List<Employee> employees = new()
            {
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
                new Employee()
                {
                    Name = $"Employee nr: {i++}",
                    Department = enumValues.GetValue(random.Next(enumValues.Length)).ToString(),
                    Salary = random.Next(8000,25000)
                },
            };

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} work in department: '{employee.Department}'   Salary: '{employee.Salary}$'");
            }

            Console.WriteLine();
            var avgDepSalary = employees
                .GroupBy(employee => employee.Department)
                .Select(groupedEmployee => new
                {
                    Department = groupedEmployee.First().Department,
                    Salary = groupedEmployee.Average(employee => employee.Salary)
                    //groupedEmployee.Sum(employee => employee.Salary / employee?.Department.Count()),
                    //(groupedEmployee.Sum(employee => employee.Salary) / groupedEmployee.Count()),
                })
                .ToList();

            Console.WriteLine("AvgSalary for each department");
            foreach (var depSalary in avgDepSalary)
            {
                Console.WriteLine(depSalary.Department + " - " + depSalary.Salary);
            }
        }

        #endregion
        // Use LINQ to select the unique items from a list of numbers.
        #region Используйте LINQ для выбора уникальных элементов из списка чисел.

        internal static void UnicalElements(int n)
        {
            Random random = new();
            List<int> numbers = new();

            for (int i = 0; i < n; i++) numbers.Add(random.Next(10, 20));
            foreach(int i in numbers)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();

            var uniqueElements = numbers
                .GroupBy(number => number)
                .Where(number => number.Count() == 1)
                .Select(number => number.Key)
                .ToList();
            foreach(var num in uniqueElements)
            {
                Console.Write(num + ", ");
            }

        }

        #endregion
        // Use LINQ to find the second highest mark in a list of exam results.
        #region Используйте LINQ, чтобы найти вторую по величине оценку в списке результатов экзамена.

        internal static void SecondHighestMark(int n)
        {
            Random random = new();
            List<int> marks = new();

            for (int i = 0; i < n; i++) marks.Add(random.Next(5, 11));
            foreach (var mark in marks) Console.Write(mark + ",");
            Console.WriteLine();
            int secondMark = marks
                .Distinct()
                .OrderByDescending(mark => mark)
                .ElementAt(1);
            Console.WriteLine(secondMark);

        }

        #endregion
        // Use LINQ to join two lists of objects and select only the necessary information.
        #region Используйте LINQ, чтобы соединить два списка объектов и выбрать только необходимую информацию.

        internal static void JoinTwoLists(string necesaryInfo)
        {
            List<string> strings1 = new()
            {
                "\nDe-acuma nu te-oi mai vedea,",
                "\nRămâi, rămâi, cu bine!",
                "\nMă voi feri în calea mea",
                "\nDe tine.",
                "\n\nDe astăzi dar tu fă ce vrei,",
                "\nDe astăzi nu-mi mai pasă",
                "\nCă cea mai dulce-ntre femei",
                "\nMă lasă."
            };
            List<string> strings2 = new()
            {
                "\nCăci nu mai am de obicei",
                "\nCa-n zilele acele,",
                "\nSă mă îmbăt şi de scântei",
                "\nDin stele,",
                "\n\nCând degerând atâtea dăţi,",
                "\nEu mă uitam prin ramuri",
                "\nŞi aşteptam să te arăţi",
                "\nLa geamuri."
            };


            strings2.ForEach(str => strings1.Add(str));
            var necesaryString = strings1
                .First(str => str.Contains(necesaryInfo))
                .ToString();
            //foreach(var str in strings1) Console.WriteLine(str);
            Console.WriteLine(necesaryString);
        }

        #endregion
        // Use LINQ to count the number of occurrences of each word in a string.
        #region Используйте LINQ для подсчета количества вхождений каждого слова в строку.

        internal static void OccurrenceNumber()
        {
            string? text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque placerat diam sit amet ante euismod dignissim. Duis ullamcorper, mauris non facilisis vehicula, est enim finibus eros, sed mollis purus nibh ut nibh. Donec in pellentesque velit. Aenean vestibulum id eros quis consequat. Morbi commodo eu justo vel blandit. Nunc pretium lorem vulputate arcu viverra lacinia. Suspendisse sit amet tellus dolor. Mauris at purus at nulla sodales dictum eu at purus. Donec congue a ante ac pellentesque. Mauris blandit erat quis elit mattis pulvinar. Integer malesuada sed mi a pellentesque. Pellentesque in elit finibus, eleifend augue at, venenatis arcu. Nunc sed libero consequat, faucibus leo et, consectetur erat. Suspendisse pretium mi sit amet sagittis molestie.\r\n\r\nNullam tristique, leo et porttitor euismod, felis ex scelerisque velit, eget euismod mi leo ut diam. Mauris ut mauris congue, mattis turpis nec, tincidunt nunc. Curabitur ac eros tempus, luctus nunc a, fermentum urna. Suspendisse vitae arcu libero. Praesent sed sapien cursus, placerat eros at, ullamcorper turpis. Aenean eget turpis bibendum, sollicitudin nibh sit amet, viverra nisl. Praesent id suscipit libero.\r\n\r\nPraesent pretium ante ut semper viverra. Vestibulum sed ipsum vel tortor lobortis dapibus sed ut sem. Etiam interdum mauris ut fringilla pretium. Fusce rhoncus nisl ac lectus tincidunt volutpat. Sed elit risus, pellentesque in malesuada vel, tincidunt a risus. Quisque sodales augue sed ex vehicula efficitur. Proin dapibus, est molestie posuere feugiat, tortor ex fermentum lorem, id viverra diam lacus quis metus. Proin dapibus, urna sit amet suscipit euismod, massa lorem aliquet urna, a cursus nunc ligula nec neque. Vestibulum ut elit vel lorem consequat bibendum vel id arcu. Vivamus accumsan elit ac odio laoreet varius. Duis eu lacinia ligula, ac consequat sem. Nunc aliquet ipsum mi, nec iaculis enim semper et. Maecenas ac elementum neque, ut pharetra lorem. Nunc vitae urna felis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In auctor fringilla purus, eget commodo est mattis sed.\r\n\r\nCras ut felis et lectus cursus tempor. Vivamus vel sem sed elit dictum accumsan at non sem. Aenean nec interdum mi. Integer ullamcorper congue ipsum sit amet semper. Sed volutpat non nibh eu consequat. Sed porttitor varius nibh ut facilisis. Nulla at ligula tincidunt, sollicitudin tortor id, dignissim velit. Donec eget felis vulputate, porta nisl et, bibendum arcu. Donec cursus malesuada metus in bibendum. Fusce placerat consectetur mattis. Sed condimentum augue ut neque semper pharetra.\r\n\r\nIn hac habitasse platea dictumst. Curabitur sed tortor eget justo scelerisque dignissim. Nunc sollicitudin rhoncus ipsum, in tempor metus pellentesque quis. Maecenas at tempus purus. Nullam imperdiet leo id enim tempor, at tristique lacus eleifend. Praesent non facilisis dolor. Nullam pulvinar ante justo. Integer viverra libero tincidunt purus ultricies lacinia. In ligula ante, elementum at sem vitae, laoreet lacinia urna. In quis lacinia magna. Vestibulum bibendum vestibulum tellus, id sodales tellus molestie id. In vitae turpis nec nulla molestie faucibus eu non enim. Quisque eleifend urna vitae luctus ultricies. Cras aliquam, purus sed varius luctus, neque ante dignissim ex, ac ullamcorper sapien risus vel felis. Nullam eget lectus velit. Aliquam.";
            List<string> words = Regex.Split(text, @"\W+").ToList();


            var wordCount = words
                .GroupBy(word => word.ToLower(), StringComparer.CurrentCultureIgnoreCase);

            foreach (var word in wordCount)
            {
                Console.WriteLine(word.Key + " --> " + word.Count());
            }


        }

        #endregion
        // Use LINQ to find the maximum and minimum temperature recorded in a list of weather data.
        #region Используйте LINQ, чтобы найти максимальную и минимальную температуру, записанную в списке данных о погоде.

        internal static void FindTemperature(int days)
        {
            List<double> dayTemperatures = new();

            for(int i=0;i<days; i++)
            {
                dayTemperatures.Add(DayTemperature.Temperature);
            }

            var min = dayTemperatures
                .OrderBy(temp => temp)
                .Select(temp => temp)
                .First();
            var max = dayTemperatures
                .OrderByDescending(temp => temp)
                .First();
            Console.WriteLine("Max temperature is:" + max + "\nMin temperature is: " + min);
        }

        #endregion
        // Use LINQ to group a list of books by their publication year and count the number of books in each group.
        #region Используйте LINQ, чтобы сгруппировать список книг по году их публикации и подсчитать количество книг в каждой группе.

        internal static void GroupBooks(int n)
        {
            Random random = new();
            List<Book> books = new();

            for(int i = 0; i < n; i++)
            {
                books.Add(
                    new Book() 
                    { 
                        BookTitle = "Book "+i,
                        PublicationYear = random.Next(1999,2005),
                    });
            }
            foreach (Book book in books) Console.WriteLine(book.BookTitle + " --> " + book.PublicationYear);
            var groupedBooks = books
                .GroupBy(book => book.PublicationYear)
                .ToList();
            foreach(var book in groupedBooks)
            {
                Console.WriteLine($"In year: {book.Key} we have a {book.Count()} books");
            }

        }

        #endregion

        #region MyRegion

        public static List<string> GetSortedWords(string text)
        {
            // ваше решение
            return text
                .Split(@"\W+")
                .Select(word => word.ToLower())
                .OrderBy(word => word)
                .ToList(); 
        }

        #endregion
    }
    class Student
    {
        public string? Name { get; set; }
        public List<double> Grades = new();

        public double GradeAvearage()
        {
            var sumGrades = 0.0;
            foreach(var grad in Grades)
            {
                sumGrades += grad / Grades.Count;
            }
            return sumGrades;

            //return Grades
            //    .Select(grade => grade / Grades.Count)
        }
    }

    class Product
    {
        public string? Name { get; set;}
        public int SaledCount { get; set;}
    }

    class Transaction
    {
        public string? Description { get; set; }
        public double Amount { get; set;}
        public DateOnly Date { get; set; }
    }

    class Employee
    {
        public string? Name { get; set;}
        public string? Department { get; set; }
        public double Salary { get; set; }
    }

    static class DayTemperature
    {
        public static double Temperature { 
            get 
            {
                Random random = new();
                List<double> temps = new();
                for (int i = 0; i < 24; i++) temps.Add(random.Next(-12, 34));
                return AvearageTemp(temps);
            } 
        }
        static double AvearageTemp(List<double> temps) => temps.Average();
    }

    class Book 
    { 
        public string BookTitle { get; set; }
        public int PublicationYear { get; set; }
    }
}