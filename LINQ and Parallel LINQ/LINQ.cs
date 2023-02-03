using Microsoft.VisualBasic;
using static System.Reflection.Metadata.BlobBuilder;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System;

namespace LINQ
{
    internal class Linq
    {
        internal static void Main()
        {
            //StudentOrder();
            //TopProducts(3);
            //GroupAndSumTransactions();
            //AvearageSalary();
            UnicalElements(22);
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
                .OrderByDescending(product => product.SaledCount) // Sort list
                .Where(product => n-- > 0) // Get top n elements
                .ToList(); // Returning values by list

            foreach (Product product in topProducts)
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

            for (int i = 0; i < n; i++) numbers.Add(random.Next(1, 100));
            foreach(int i in numbers)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();

            var uniqueElements = numbers
                .Select(number => numbers.Where(number => numbers.Exists()))
                //.Where(number => number is not numbers.SelectMany())
                //.Equals(number => number  != numbers.Select(number => number))
                .ToList();


        }

        #endregion
        // Use LINQ to find the second highest mark in a list of exam results.
        #region Используйте LINQ, чтобы найти вторую по величине оценку в списке результатов экзамена.



        #endregion
        // Use LINQ to join two lists of objects and select only the necessary information.
        #region Используйте LINQ, чтобы соединить два списка объектов и выбрать только необходимую информацию.



        #endregion
        // Use LINQ to count the number of occurrences of each word in a string.
        #region Используйте LINQ для подсчета количества вхождений каждого слова в строку.



        #endregion
        // Use LINQ to find the maximum and minimum temperature recorded in a list of weather data.
        #region Используйте LINQ, чтобы найти максимальную и минимальную температуру, записанную в списке данных о погоде.



        #endregion
        // Use LINQ to group a list of books by their publication year and count the number of books in each group.
        #region Используйте LINQ, чтобы сгруппировать список книг по году их публикации и подсчитать количество книг в каждой группе.



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
}