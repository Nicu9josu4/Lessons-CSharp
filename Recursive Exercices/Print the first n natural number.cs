namespace Recursive_Exercices
{
    //  1.Write a program in C# Sharp to print the first n natural number using recursion.
    //  Test Data :
    //  How many numbers to print : 10
    //  Expected Output :
    //  1 2 3 4 5 6 7 8 9 10
    class First_N_NaturalNumber
    {
        public static void FirstNumbers(int n)
        {
            if (n <= 1) Console.Write(1 + " "); // pool method, when n is decrement to 1 return 1 and exit from all recursive call
            else 
            {
                FirstNumbers(n - 1);
                Console.Write(n + " ");
            }
        }
    }
}
