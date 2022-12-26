namespace Delegates__events_and_lambdas
{
    internal class SomeAction
    {
        public delegate void ActionHandler(string message);

        private ActionHandler? action;

        public event ActionHandler Action
        {
            add
            {
                action += value;
                Console.WriteLine("Action has been added");
            }
            remove
            {
                action -= value;
                Console.WriteLine("Action has been removed");
            }
        }

        public void SayHello() =>// pentru a prescurta metoda de afisare a mesajului este folosit operatorul Lambda care prin simbolul => returnarea unei operatii
            Console.WriteLine("Hello World!");

        /*
         *   public void SayHello()
         *   {
         *      Console.WriteLine("Hello World!");
         *   }
         */

        public void SayHi()
        {
            Console.WriteLine("Hey you");
            action?.Invoke("He said Hi");
        }

        public int SumNumbers(int a, int b) => a + b;

        /*
         *   public int SumNumbers(int a, int b)
         *   {
         *        return a + b;
         *   }
        */

        public int MultiplyNumbers(int a, int b)
        {
            action?.Invoke("He did Multiply");
            return a * b;
        }
    }
}