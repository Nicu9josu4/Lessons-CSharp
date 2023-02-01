namespace BankCalculate
{
    public class Program
    {
        internal static void Main()
        {
            string userInput1 = "100.00 12 1";
            string userInput2 = "1000.00 12 1";
            Console.WriteLine("Final you has receive: " + Calculate(userInput2));
            Console.WriteLine("Final you has receive: " + Calculate(userInput1));
        }
        public static double Calculate(string userInput)
        {
            string[] strings = userInput.Split(' ');
            double money = double.Parse(strings[0]); 
            double percent = double.Parse(strings[1]); 
            int months = int.Parse(strings[2]);
            for (int i = 0; i < months; i++) money += ((percent / 100) / 12) * money;
            return money;
        }
    }
}