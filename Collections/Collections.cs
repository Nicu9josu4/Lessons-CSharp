//difference between List and Array is https://blog.dotnetsafer.com/the-difference-between-array-and-list-in-c-memory-usage-performance/

using System.Text.RegularExpressions;

namespace Collections
{
    internal class Collections // Using for List<>
    {
        // Lista reprezinta o colectie de obiecte aranjate precum un Array avand fiecare cate un indice
        // Spre deosebire de Array el pastreaza linkul catre spatiul de memorie care-l detine obiectul.


        #region Use LINQ for parse numbers

        //public static void Main()
        //{
        //    foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
        //        Console.WriteLine(num);
        //    foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
        //        Console.WriteLine(num);
        //}

        //public static int[] ParseNumbers(IEnumerable<string> lines)
        //{
        //    //List<int> array = new();
        //    //foreach(var line in lines)
        //    //{
        //    //    //Console.WriteLine(line);
        //    //    if(line != null && line != "")
        //    //    array.Add(int.Parse(line.ToString()));
        //    //}
        //    //return array.ToArray();


        //        return lines
        //        .Where(line => line != null && line != "")
        //        .Select(line => int.Parse(line))
        //        .ToArray();

        //}

        #endregion

        #region Parse with Select

        //public static void Main()
        //{
        //    // Функция тестирования ParsePoints

        //    foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
        //        Console.WriteLine(point.X + " " + point.Y);
        //    foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
        //        Console.WriteLine(point.X + " " + point.Y);
        //}

        //public class Point
        //{
        //    public Point(int x, int y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //    public int X, Y;
        //}

        //public static List<Point> ParsePoints(IEnumerable<string> lines)
        //{
        //    //var listOfPoint = new List<Point>();
        //    //foreach(var line in lines)
        //    //{
        //    //    var coord = line.Split(" ");
        //    //    listOfPoint.Add(new Point(int.Parse(coord[0]), int.Parse(coord[1])));
        //    //}
        //    //return listOfPoint;


        //    return lines
        //        .Select(line => new Point(x: int.Parse(line.Split(" ")[0]), y: int.Parse(line.Split(" ")[1])))
        //        .ToList();


        //}

        #endregion


        #region Select students from Classes

        //public static void Main()
        //{
        //    Classroom[] classes =
        //    {
        //        new Classroom {Students = {"Pavel", "Ivan", "Petr"},},
        //        new Classroom {Students = {"Anna", "Ilya", "Vladimir"},},
        //        new Classroom {Students = {"Bulat", "Alex", "Galina"},}
        //    };
        //    var allStudents = GetAllStudents(classes);
        //    Array.Sort(allStudents);
        //    Console.WriteLine(string.Join(" ", allStudents));
        //}
        //public class Classroom
        //{
        //    public List<string> Students = new();
        //}

        //public static string[] GetAllStudents(Classroom[] classes)
        //{
        //    //var studentsArray = from classroom in classes
        //    //                    where classroom.Students != null
        //    //                    select classroom.Students;
        //    //return studentsArray.ToArray();

        //    return classes
        //        .SelectMany(classroom => classroom.Students)
        //        .ToArray();
        //}

        #endregion


        #region SortWords 
        public static void Main()
        {
            var vocabulary = GetSortedWords(
                "Hello, hello, hello, how low",
                "",
                "With the lights out, it's less dangerous",
                "Here we are now; entertain us",
                "I feel stupid and contagious",
                "Here we are now; entertain us",
                "A mulatto, an albino, a mosquito, my libido...",
                "Yeah, hey"
            );
            foreach (var word in vocabulary)
                foreach(var word2 in word )
                Console.WriteLine(word2);
        }

        public static string[][] GetSortedWords(params string[] textLines)
        {
            //string[] strings = textLines
            //    .Where(line => line != null && line != "")
            //    .Select(line => Regex.Split(line, @"\W+"));

            //var strings1 = (from line in textLines
            //                where line != null && line != ""
            //                select Regex.Split(textLines, @"\W+"))
            //                .SelectMany(word => word).ToArray();

            var result = textLines
                .Where(word => word is not null and not "")
                .Select(queries => Regex.Split(queries.ToLower(), @"\W+"))
                .ToArray();
            //var strings2 = from words in strings1
            //               select words;
            //return strings2.ToArray();

            // ваше решение
            //var str1 = textLines
            //    .Where(x => x != null && x != "")
            //    .SelectMany(x => x.Split(@"\W+"))
            //    .ToArray();
            return result;
        }
        #endregion

        //var allStudents = new List<string>();
        //foreach (var classroom in classes)
        //{
        // foreach (var student in classroom.Students)
        // {
        //  allStudents.Add(student);
        // }
        //}
        //return allStudents.ToArray();



        //internal static void Main()
        //{
        //    //Simple list
        //    List<int> ints= new();  //List<int> ints = new()
        //    ints.Add(1);            //{ 1,
        //    ints.Add(2);            //  2,
        //    ints.Add(3);            //  3,
        //    ints.Add(4);            //  4 };

        //    foreach(var number in ints)
        //    {
        //        Console.WriteLine(number);
        //    }

        //    // List of type User objects
        //    List<User> users = new()
        //    {
        //        new User { Name = "Tolik", CardNumber = 123123123 },
        //        new User { Name = "Bolik", CardNumber = 123123124 },
        //        new User { Name = "Alcogolik", CardNumber = 123123125 },
        //        new User { Name = "Alcogolikov", CardNumber = 123123121 }
        //    };
        //    foreach (var user in users)
        //    {
        //        user.PrintUser();
        //    }

        //    var sameUser = users.Where(user => user.CardNumber == 123123123).First();
        //    Console.WriteLine(sameUser.Name);
        //    sameUser.Name = "Anatolii";
        //    sameUser.PrintUser();

        //    Dictionary<int, string> verbs = new()
        //    {
        //        { 1, "alahagbar" },
        //        { 2, "Anatolii" },
        //        { 3, "Buhanka" },
        //        { 4, "Salamandra" }
        //    };
        //    foreach(var verb in verbs)
        //    {
        //        Console.WriteLine(verb.Value);
        //    }

        //}
    }

    internal class User
    {
        public string? Name { get; set; }
        public int CardNumber { get; set; }

        public void PrintUser()
        {
            Console.WriteLine($"Name: {Name} card number: {CardNumber}");
        }
    }
}