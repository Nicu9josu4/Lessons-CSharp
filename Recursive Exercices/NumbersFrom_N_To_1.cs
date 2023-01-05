
namespace Recursive_Exercices
{
    //2. Write a program in C# Sharp to print numbers from n to 1 using recursion. Go to the editor
    //Test Data :
    //How many numbers to print : 10
    //Expected Output :
    //10 9 8 7 6 5 4 3 2 1
    internal class NumbersFrom_N_To_1
    {
        public static void NumbersTo1(int n, int i = 1)
        {
            if (i == n) Console.Write(n + " ");
            else
            {
                NumbersTo1(n, i + 1);
                Console.Write(i + " ");
            }
        }
    }
}
