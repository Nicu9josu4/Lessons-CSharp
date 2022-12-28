namespace LINQ
{
    internal class Linq
    {
        internal static void Main()
        {
            string[] Names = { "Tom", "Thomas", "Thamojnie", "Jerry", "Kratos" };
            List<string> ListOfNames = new List<string>(Names);
            Console.WriteLine("List of Names have:" + ListOfNames.Count + " elements"); // Count of elements in the List
            foreach (string name in ListOfNames)
            {
                Console.WriteLine(name);
            }
            string nameWith3Length = ListOfNames.Where(Name => Name.Length == 3).First();
            Console.WriteLine("Name who have 3 length is:" + nameWith3Length);

            ListOfNames.Add("Rat"); Console.WriteLine("Added to last item " + ListOfNames.Last());
            ListOfNames.Add("Crot"); Console.WriteLine("Added to last item " + ListOfNames.Last());
            Console.WriteLine("List of Names now have:" + ListOfNames.Count + " elements"); // Count of elements in the List
            //string input = "HELLLO";
            //Console.WriteLine(input.ToLower());
        }
    }
}