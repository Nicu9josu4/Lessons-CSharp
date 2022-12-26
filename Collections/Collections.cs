//difference between List and Array is https://blog.dotnetsafer.com/the-difference-between-array-and-list-in-c-memory-usage-performance/

namespace Collections
{
    internal class Collections // Using for List<>
    {
        // Lista reprezinta o colectie de obiecte aranjate precum un Array avand fiecare cate un indice
        // Spre deosebire de Array el pastreaza linkul catre spatiul de memorie care-l detine obiectul.

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