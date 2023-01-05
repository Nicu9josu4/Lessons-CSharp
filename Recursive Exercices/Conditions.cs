
using Recursive_Exercices;

class Program
{
    internal static void Main()
    {
        
        Console.WriteLine("1.Write a program in C# Sharp to print the first n natural number using recursion.");
        First_N_NaturalNumber.FirstNumbers(10);
        Console.WriteLine();
        
        Console.WriteLine("2. Write a program in C# Sharp to print numbers from n to 1 using recursion.");
        NumbersFrom_N_To_1.NumbersTo1(10);
        Console.WriteLine();

        Console.WriteLine("3. Write a program in C# Sharp to find the sum of first n natural numbers using recursion.");
        Console.Write($"Sum of first {10} numbers is: " + SumOfFirst_N_Numbers.SumNumbers(10));
        Console.WriteLine();

        Console.WriteLine("4. Write a program in C# Sharp to display the individual digits of a given number using recursion.");
        IndividualDigitsOfGivenNumber.DigitsOfNumbers(12548988);
        Console.WriteLine();

        Console.WriteLine("5. Write a program in C# Sharp to count the number of digits in a number using recursion.");
        Console.Write(CountOfDigitsInNumber.CountOfDigits(12548988));
        Console.WriteLine();

        Console.WriteLine("6. Write a program in C# to print even or odd numbers in a given range using recursion.");
        Console.Write("All even numbers from 1 to 30 are:");
        EvenAndOddNumbers.GiveEvenNumbers(30);
        Console.WriteLine();
        Console.Write("All  odd numbers from 1 to 30 are:");
        EvenAndOddNumbers.GiveOddNumbers(30);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("7. Write a program in C# Sharp to check whether a number is prime or not using recursion.");
        CheckWhetherNumberIsPrime.CheckNumber(111,111);
        Console.WriteLine();

        Console.WriteLine("8. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.");
        CheckStringAsPalindrome.CheckString("radaradar".ToLower());
        Console.WriteLine();

        Console.WriteLine("9. Write a program in C# Sharp to find the factorial of a given number using recursion.");
        Console.WriteLine("Factorial of 5: " + FactorialOfNumber.GetFactorial(5));
        Console.WriteLine();

        Console.WriteLine("10. Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series using recursion.");
        FibonaciNumbers.FibonaciGetNumbers(10);
        Console.WriteLine();

        /*
         *  --> Not resolved
         *  Console.WriteLine("11. Write a program in C# Sharp to generate all possible permutations of an array using recursion.");
         *  PermutationOfArray.Permutation(new int[] { 1, 4, 6 });
         *  Console.WriteLine();
         *  --> Not resolved
         */
        
        Console.WriteLine("12. Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion.");
        Console.WriteLine("The GCD of 10 and 65:" + LCM_And_GCD.GCD(10, 65));
        Console.WriteLine("The LCM of 10 and 65:" + LCM_And_GCD.LCM(10, 65));
        Console.WriteLine();
        
        Console.WriteLine("13. Write a program in C# Sharp to convert a decimal number to binary using recursion.");
        ConvertToBinary.Convertor(778546666);
        Console.WriteLine();
        
        Console.WriteLine("14. Write a program in C# Sharp to get the reverse of a string using recursion.");
        ReverseString.Reverse("Football");
        Console.WriteLine();

        Console.WriteLine("15. Write a program in C# Sharp to calculate the power of any number using recursion.");
        Console.WriteLine(PowerOfExponent.GetPower(5, 3));
        Console.WriteLine();



    }
}