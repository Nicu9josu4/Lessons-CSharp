internal class Operators
{
    internal static void Main()
    {
        Counter counter1 = new Counter() { Value = 2 };
        Counter counter2 = new Counter() { Value = 5 };
        Console.WriteLine($"Sum of two numbers: {(counter1 + counter2 + counter1).Value}");
        Console.WriteLine($"Multy of two numbers: {(counter1 * counter2).Value}");
        Console.WriteLine($"First number is bigger that second: {counter1 > counter2}");

        CounterStrings cntString1 = new CounterStrings() { StringVal = "Hello" };
        CounterStrings cntString2 = new CounterStrings() { StringVal = " World!" };
        var stringTemp = cntString1 + cntString2;
        Console.WriteLine((cntString1 + cntString2).StringVal); // Daca fara ().StringVal ne va afisa CounterStrings
        Console.WriteLine(stringTemp.StringVal); // la reintoarcere vom primi un alt obiect si din el deja vom extrage valoarea de tip string
    }
}

internal class Counter
{
    public int Value { get; set; }

    public static Counter operator +(Counter CounterA, Counter CounterB) => new() { Value = CounterA.Value + CounterB.Value };

    public static Counter operator *(Counter CounterA, Counter CounterB) => new() { Value = CounterA.Value * CounterB.Value };

    public static bool operator >(Counter CounterA, Counter CounterB) => CounterA.Value > CounterB.Value;

    public static bool operator <(Counter CounterA, Counter CounterB) => CounterA.Value < CounterB.Value;
}

internal class CounterStrings
{
    public string? StringVal { get; set; }

    // concat of two strings
    public static CounterStrings operator +(CounterStrings CounterA, CounterStrings CounterB) => new() { StringVal = CounterA.StringVal + CounterB.StringVal };
}