namespace Recursive_Exercices
{
    internal class IndividualDigitsOfGivenNumber
    {
        //4. Write a program in C# Sharp to display the individual digits of a given number using recursion. Go to the editor
        //Test Data :
        //Input any number : 1234
        //Expected Output :
        //The digits in the number 1234 are : 1 2 3 4
        internal static void DigitsOfNumbers(int n)  // Digit - cifra
        { 
            if (n == 0) return;
            DigitsOfNumbers(n / 10);
            Console.Write(n % 10 + " ");
        }
    }
}
