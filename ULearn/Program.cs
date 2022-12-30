/*Эти задачи можно использовать для самостоятельного решения или для решения на семинарах. Пожалуйста, не публикуйте решения задач в комментариях.

Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?

Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.

Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.

Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.

Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.

Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.

Expr7. Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.

Expr8. Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A. Можете считать, что прямая задана либо двумя точками, либо коэффициентами уравнения прямой — как вам удобнее.
*/

class Program
{
    #region get minX
    //internal static void Main()
    //{
    //    Console.WriteLine(GetMinX(1, 2, 3) + " Final");
    //    Console.WriteLine(GetMinX(0, 3, 2) + " Final");
    //    Console.WriteLine(GetMinX(1, -2, -3) + " Final");
    //    Console.WriteLine(GetMinX(5, 2, 1) + " Final");
    //    Console.WriteLine(GetMinX(4, 3, 2) + " Final");
    //    Console.WriteLine(GetMinX(0, 4, 5) + " Final");

    //    // А в этих случаях решение существует:
    //    Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
    //    Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
    //}

    //private static string GetMinX(int a, int b, int c)
    //{
    //    double delta = (b * b) - (4 * a * c);
    //    Console.WriteLine("Delta = " + delta);

    //    double x1; //= (-b + Math.Sqrt(delta)) / (2 * a);
    //    //Console.WriteLine(x1);

    //    double x2; //= (-b - Math.Sqrt(delta)) / (2 * a);
    //    //Console.WriteLine(x2);
    //    //Console.WriteLine();

    //    if (delta > 0)
    //    {
    //        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    //        Console.WriteLine("Delta > 0 x1 = " + x1);

    //        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    //        Console.WriteLine("Delta > 0 x2 = " + x2);
    //        if (x1 <= x2) return x1.ToString();
    //        else return x2.ToString();
    //    }
    //    else if (delta == 0)
    //    {
    //        if (2 * a != 0) x1 = -b / (2 * a);
    //        else return "Impossible";
    //        Console.WriteLine("Delta == 0 x = " + x1);
    //        return x1.ToString();
    //    }
    //    else return "Impossible";


    //}
    #endregion

    #region Bisect year

    //public static void Main()
    //{
    //    Console.WriteLine(IsLeapYear(2014));
    //    Console.WriteLine(IsLeapYear(1999));
    //    Console.WriteLine(IsLeapYear(8992));
    //    Console.WriteLine(IsLeapYear(1));
    //    Console.WriteLine(IsLeapYear(14));
    //    Console.WriteLine(IsLeapYear(400));
    //    Console.WriteLine(IsLeapYear(600));
    //    Console.WriteLine(IsLeapYear(3200));
    //    Console.WriteLine(IsLeapYear(1700)); // Тестирование решения на секретных тестах
    //}

    //public static bool IsLeapYear(int year)
    //{
    //    return true ? (year % 100 != 0 || year % 400 == 0) && year % 4 == 0 : false;
    //}

    #endregion

    #region ChessGame

    //    public static void Main()
    //    {
    //        TestMove("a1", "d4");
    //        TestMove("f4", "e7");
    //        TestMove("a1", "a4");
    //        TestMove("a1", "a1");// Тестирование решения на секретных тестах
    //    }

    //    public static void TestMove(string from, string to)
    //    {
    //        Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
    //    }

    //    public static bool IsCorrectMove(string from, string to)
    //    {

    //        var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
    //        var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
    //        if (from == to) return false;
    //        if (dx == 0 || dy == 0) return true; 
    //        return dx == dy;
    //}
    #endregion

    #region Midle of three

    //public static void Main()
    //{
    //    Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
    //    Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
    //    Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
    //    Console.WriteLine(MiddleOf(2, 3, 2));
    //    Console.WriteLine(MiddleOf(8, 8, 8));
    //    Console.WriteLine(MiddleOf(5, 0, 1));
    //    Console.WriteLine(MiddleOf(1, 0, 1));  // Тестирование решения на секретных тестах
    //}
    //public static int MiddleOf(int a, int b, int c)
    //{
    //    List<int> numbers = new List<int> { a, b, c };
    //    int min = a, max = a;
    //    foreach (int num in numbers)
    //    {
    //        if (num > max) max = num;
    //        if (num < min) min = num;
    //    }
    //    numbers.Remove(min);
    //    numbers.Remove(max);
    //    if (numbers.Count == 0) return max;
    //    else return numbers.First();

    //}

    #endregion

    #region ShouldFire
    //public static void Main()
    //{
    //    Console.WriteLine("MyFunction------- boss-60 " + ShouldFire2(true, "boss", 60));
    //    Console.WriteLine("Standart Function boss-60 " + ShouldFire(true, "boss", 60) + " - true"); // true
    //    Console.WriteLine();
    //    Console.WriteLine("MyFunction------- boss-1 " + ShouldFire2(true, "boss", 1)); /// true 
    //    Console.WriteLine("Standart Function boss-1 " + ShouldFire(true, "boss", 1) + " - false"); // false 
    //    Console.WriteLine();
    //    Console.WriteLine("MyFunction------- Zombie-1 " + ShouldFire2(true, "Zombie", 1)); 
    //    Console.WriteLine("Standart Function Zombie-1 " + ShouldFire(true, "Zombie", 1) + " - true"); // true
    //    Console.WriteLine();
    //    Console.WriteLine("MyFunction------- Zombie-111 " + ShouldFire2(true, "Zombie", 111));
    //    Console.WriteLine("Standart Function Zombie-111 " + ShouldFire(true, "Zombie", 111) + " - true"); // true
    //}
    //static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
    //{
    //    //return robotHealth >= 50 || (robotHealth < 50 && false) ? enemyInFront && enemyName == "boss" : false;
    //    //return enemyInFront && enemyName == "boss" && (robotHealth > 100 || (robotHealth < 50 && false)) ? true : false;
    //    //return enemyInFront || (enemyName == "boss" && (robotHealth > 100 || robotHealth < 50));
    //    //return true ? true : true  && (false && true);
    //    //return true | (true & (false & true));

    //    //return enemyInFront ? (enemyName == "boss") ? robotHealth < 50 ? false : robotHealth > 100 ? true : true : true : false;

    //    return enemyInFront
    //    ? enemyName == "boss"
    //        ? robotHealth < 50
    //            ? false : robotHealth > 100
    //            ? true : true
    //        : true
    //    : false;
    //}
    //static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
    //{
    //    bool shouldFire = true;
    //    if (enemyInFront == true)
    //    {
    //        if (enemyName == "boss")
    //        {
    //            shouldFire = robotHealth < 50 ? false : robotHealth > 100 ? true : true;
    //            //if (robotHealth < 50) shouldFire = false;
    //            //if (robotHealth > 100) shouldFire = true;
    //        }
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //    return shouldFire;
    //}
    #endregion

    #region Codded message

    //internal static void Main()
    //{

    //    /* 
    //     *  Писать ХОРОШИЙ Код Трудно Но Ты НЕ Сдавайся Старайся Все Упрощать 
    //     */
    //    List<string> lines = new()
    //    {
    //        "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
    //        "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
    //        "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
    //        "если особенно упорно подойдешь к делу",
    //        "будет Трудно конечнО",
    //        "Код ведЬ не из простых",
    //        "очень ХОРОШИЙ код",
    //        "то у тебя все получится",
    //        "и я буДу Писать тЕбЕ еще",
    //        "чао",
    //    };
    //    string slova = "";
    //    List<string> strings = new();
    //    string[] strings1;
    //    foreach(string line in lines)
    //    {
    //        //slova += DecodeMessage(line);
    //        strings.Add(DecodeMessage(line));
    //    }
    //    //strings.Reverse();
    //    foreach (string slov in strings)
    //    {
    //        //Console.WriteLine(slov);
    //        slova += slov;
    //    }
    //    strings1 = slova.Split(' ');
    //    for (int i = strings1.Length - 1; i > 0; i--)
    //    {
    //        Console.Write(strings1[i]  + ' ');
    //    }
    //    //foreach (var slov in slova.Split(' '))
    //    //{

    //    //}
    //    //Console.WriteLine(slova);

    //}
    //private static string DecodeMessage(string lines)
    //{
    //    string[] strings = lines.Split(' ');
    //    string gudSlova = "";
    //    foreach(string str in strings) 
    //    {
    //        foreach (char c in str)
    //        {
    //            if (c > 1040 && c < 1070) { gudSlova += str + " "; /*Console.WriteLine("Char from str: {0} - {1}", (int)c, c)*/; }
    //            break;
    //        }

    //    }
    //char[] regex = { ':', ';', ',', '.', '-'};

    //    return gudSlova;
    //}

    #endregion

    #region powerOfTwo
    //static void Main()
    //{
    //    Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
    //    Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
    //    Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
    //    Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
    //    Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
    //}
    //private static int GetMinPowerOfTwoLargerThan(int number)
    //{
    //    int result = 1;
    //    while (result <= number)
    //    {
    //        result *= 2;
    //    }
    //    return result;
    //}

    #endregion

    #region RemoveStartSpace

    //public static void Main()
    //{
    //    Console.WriteLine(RemoveStartSpaces("a"));
    //    Console.WriteLine(RemoveStartSpaces(" b"));
    //    Console.WriteLine(RemoveStartSpaces(" cd"));
    //    Console.WriteLine(RemoveStartSpaces(" efg"));
    //    Console.WriteLine(RemoveStartSpaces(" text"));
    //    Console.WriteLine(RemoveStartSpaces(" two words"));
    //    Console.WriteLine(RemoveStartSpaces("  two spaces"));
    //    Console.WriteLine(RemoveStartSpaces("	tabs"));
    //    Console.WriteLine(RemoveStartSpaces("		two	tabs"));
    //    Console.WriteLine(RemoveStartSpaces("                             many spaces"));
    //    Console.WriteLine(RemoveStartSpaces("               "));
    //    Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));
    //}
    //public static string RemoveStartSpaces(string text)
    //{
    //    //int i = 0;
    //    //while (char.IsWhiteSpace(text[i])) i++;
    //    //return text[i..];
    //    return text.Trim();
    //}
    #endregion

    #region FrameForText
    //public static void Main()
    //{
    //    WriteTextWithBorder("Menu:");
    //    WriteTextWithBorder("");
    //    WriteTextWithBorder(" ");
    //    WriteTextWithBorder("Game Over!");
    //    WriteTextWithBorder("Select level:");
    //}

    //private static void WriteTextWithBorder(string text)
    //{
    //    int i = 0;
    //    string carcass = "+";
    //    while ( i < text.Length + 2)
    //    {
    //        carcass += "-";
    //        i++;
    //    }
    //    carcass += "+";
    //    Console.WriteLine(carcass);
    //    Console.WriteLine($"| {text} |");
    //    Console.WriteLine(carcass);
    //}
    #endregion

    #region ChessBoard
    //public static void Main()
    //{
    //    //WriteBoard(8);
    //    WriteBoard(1);
    //    WriteBoard(2);
    //    WriteBoard(3);
    //    WriteBoard(10);
    //}

    //private static void WriteBoard(int size)
    //{
    //    int i = 1;
    //    while(i <= size * size)
    //    {
    //        if (i % size != 0 && i <= size * size) { Console.Write("."); i++; }
    //        if (i % size == 0 && i <= size * size) { Console.WriteLine("#"); i++; }
    //        if (i % size != 0 && i <= size * size) { Console.Write("#"); i++; }
    //        if (i % size == 0 && i <= size * size) { Console.WriteLine("."); i++; }
    //    }
    //    Console.WriteLine();
    //}
    #endregion

    #region arrayOfEvenNumbers
    //internal static void Main()
    //{
    //    foreach(int number in GetFirstEvenNumbers(4))
    //    {
    //        Console.WriteLine(number);
    //    }
    //}
    //public static int[] GetFirstEvenNumbers(int count)
    //{
    //    int[] numbers = new int[count];
    //    for (int i = 1; i <= count; i++) numbers[i - 1] = i * 2;
    //    return numbers;
    //}
    #endregion

    #region GetMaxIndex from array
    //internal static void Main()
    //{
    //    double[] array = { };
    //    int max = MaxIndex(array);
    //    Console.WriteLine(max);
    //}
    //public static int MaxIndex(double[] array)
    //{
    //    if(array.Length > 0)
    //    {
    //        double Max = array.First();
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (Max < array[i]) Max = array[i];
    //        }
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (Max == array[i]) return i;
    //        }
    //    }
    //    return -1;

    //}
    #endregion

    #region itemToCount

    internal static void Main()
    {
        int[] items = { 1, 2, 2, 1, 1, 1, 1, };
        Console.WriteLine(GetElementCount(items, 1));
    }
    public static int GetElementCount(int[] items, int itemToCount)
    {
        int k = 0;
        foreach(int item in items)
        {
            if ( item == itemToCount) k++;
        }
        return k;
    }
    #endregion
}