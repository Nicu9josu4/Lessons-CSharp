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

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using ULearn;

internal class Program
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

    #endregion get minX

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

    #endregion Bisect year

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

    #endregion ChessGame

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

    #endregion Midle of three

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

    #endregion ShouldFire

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

    #endregion Codded message

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

    #endregion powerOfTwo

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

    #endregion RemoveStartSpace

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

    #endregion FrameForText

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

    #endregion ChessBoard

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

    #endregion arrayOfEvenNumbers

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

    #endregion GetMaxIndex from array

    #region itemToCount

    //internal static void Main()
    //{
    //    int[] items = { 1, 2, 2, 1, 1, 1, 1, };
    //    Console.WriteLine(GetElementCount(items, 1));
    //}
    //public static int GetElementCount(int[] items, int itemToCount)
    //{
    //    int k = 0;
    //    foreach(int item in items)
    //    {
    //        if ( item == itemToCount) k++;
    //    }
    //    return k;
    //}

    #endregion itemToCount

    #region ArrayInArray

    //internal static void Main()
    //{
    //    int[] array = { 1, 2, 5, 6, 4, 3, 5, 5, 5, 5 };
    //    int[] subArray = {2, 5, 6, 4, 3, };
    //    Console.WriteLine(FindSubarrayStartIndex(array, subArray));
    //}
    //public static int FindSubarrayStartIndex(int[] array, int[] subArray)
    //{
    //    for (var i = 0; i < array.Length - subArray.Length + 1; i++)
    //        if (ContainsAtIndex(array, subArray, i))
    //            return i;
    //    return -1;
    //}
    //public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
    //{
    //    int k = 0,j = 0;
    //    while ( k < subArray.Length)
    //    {
    //        if (array[i + k] == subArray[k]) j++;
    //        k++;
    //    }
    //    return j == subArray.Length;
    //}

    #endregion ArrayInArray

    #region TranslateSite

    //enum Suits
    //{
    //    Wands,
    //    Coins,
    //    Cups,
    //    Swords
    //}
    //internal static void Main()
    //{
    //    Console.WriteLine(GetSuit(Suits.Wands));
    //    Console.WriteLine(GetSuit(Suits.Coins));
    //    Console.WriteLine(GetSuit(Suits.Cups));
    //    Console.WriteLine(GetSuit(Suits.Swords));
    //}
    //private static string GetSuit(Suits suit)
    //{
    //    //string[] strings = { "жезлов", "монет", "кубков", "мечей" };

    //    return (int)suit == 0 ? "жезлов" : (int)suit == 1 ? "монет" : (int)suit == 2 ? "кубков" : "мечей";
    //    //return strings[(int)suit];

    //}

    #endregion TranslateSite

    #region CheckIfIsNull

    //internal static void Main()
    //{
    //    Console.WriteLine(CheckFirstElement(null));
    //    Console.WriteLine(CheckFirstElement(new int[0]));
    //    Console.WriteLine(CheckFirstElement(new[] { 1 }));
    //    Console.WriteLine(CheckFirstElement(new[] { 0 }));
    //}
    //public static bool CheckFirstElement(int[] array)
    //{
    //    //return array != null & array.Length != 0 & array[0] == 0;
    //    return array != null && array.Length != 0 ? array[0] == 0 : false;

    //}

    #endregion CheckIfIsNull

    #region PoverOfArrays

    //public static void PrintArray(int[] array)
    //{
    //    foreach(var a in array)
    //    {
    //        Console.Write(a.ToString() + " ");
    //    }
    //    Console.WriteLine();
    //}
    //public static void Main()
    //{
    //    var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    //    // Метод PrintArray уже написан за вас
    //    PrintArray(GetPoweredArray(arrayToPower, 1));

    //    // если вы будете менять исходный массив, то следующие два теста сработают неверно:
    //    PrintArray(GetPoweredArray(arrayToPower, 2));
    //    PrintArray(GetPoweredArray(arrayToPower, 3));

    //    // не забывайте про частные случаи:
    //    PrintArray(GetPoweredArray(new int[0], 1));
    //    PrintArray(GetPoweredArray(new[] { 42 }, 0));

    //    var a = new int[2, 3];
    //    Console.WriteLine(a.GetType());
    //    var b = new int[2][];
    //    Console.WriteLine(b.GetType());
    //}
    //public static int[] GetPoweredArray(int[] arr, int power)
    //{
    //    int[] array = new int[arr.Length];
    //    for(int i = 0;i < arr.Length;i++)
    //    {
    //        array[i] = (int)Math.Pow(arr[i], power);
    //    }
    //    return array;
    //}

    #endregion PoverOfArrays

    #region CrossAndCircles

    //public enum Mark
    //{
    //    Empty,
    //    Cross,
    //    Circle
    //}

    //public enum GameResult
    //{
    //    CrossWin,
    //    CircleWin,
    //    Draw
    //}

    //public static void Main()
    //{
    //    Run("XXX OO. ...");     //XXX
    //    Run("OXO XO. .XO");     //OO
    //    Run("OXO XOX OX.");     //
    //    Run("XOX OXO OXO");
    //    Run("... ... ...");
    //    Run("XXX OOO ...");
    //    Run("XOO XOO XX.");
    //    Run(".O. XO. XOX");
    //}

    //private static void Run(string description)
    //{
    //    Console.WriteLine(description.Replace(" ", Environment.NewLine));
    //    Console.WriteLine(GetGameResult(CreateFromString(description)));
    //    Console.WriteLine();
    //}

    //private static Mark[,] CreateFromString(string str)
    //{
    //    var field = str.Split(' ');
    //    var ans = new Mark[3, 3];
    //    for (int x = 0; x < field.Length; x++)
    //        for (var y = 0; y < field.Length; y++)
    //            ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
    //    return ans;
    //}

    //public static GameResult GetGameResult(Mark[,] field)
    //{
    //    bool crossWin = false, circleWin = false;
    //    GameResult win = GameResult.Draw;
    //    if (field[0, 0] == field[0, 1] && field[0, 0] == field[0, 2]) win = field[0, 0] == Mark.Cross ? GameResult.CrossWin : field[0, 0] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;
    //    if (field[1, 0] == field[1, 1] && field[1, 0] == field[1, 2]) win = field[1, 0] == Mark.Cross ? GameResult.CrossWin : field[1, 0] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;
    //    if (field[2, 0] == field[2, 1] && field[2, 0] == field[2, 2]) win = field[2, 0] == Mark.Cross ? GameResult.CrossWin : field[2, 0] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;

    //    if (field[0, 0] == field[1, 0] && field[0, 0] == field[2, 0]) win = field[0, 0] == Mark.Cross ? GameResult.CrossWin : field[0, 0] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;
    //    if (field[0, 1] == field[1, 1] && field[0, 1] == field[2, 1]) win = field[0, 1] == Mark.Cross ? GameResult.CrossWin : field[0, 1] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;
    //    if (field[0, 2] == field[1, 2] && field[0, 2] == field[2, 2]) win = field[0, 2] == Mark.Cross ? GameResult.CrossWin : field[0, 2] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;

    //    if (field[0, 0] == field[1, 1] && field[0, 0] == field[2, 2]) win = field[0, 0] == Mark.Cross ? GameResult.CrossWin : field[0, 0] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;
    //    if (field[2, 0] == field[1, 1] && field[2, 0] == field[0, 2]) win = field[2, 0] == Mark.Cross ? GameResult.CrossWin : field[2, 0] == Mark.Circle ? GameResult.CircleWin : GameResult.Draw;  _ = win == GameResult.CrossWin ? crossWin = true : win == GameResult.CircleWin ? circleWin = true : true;

    //    return crossWin && circleWin ? GameResult.Draw : crossWin && !circleWin ? GameResult.CrossWin : !crossWin && circleWin ?  GameResult.CircleWin : GameResult.Draw;
    //}

    #endregion CrossAndCircles

    #region ApplyCommands

    //internal static void Main()
    //{
    //    string[] strings = { "push Привет! Это снова я! Пока!", "pop 5", "push Как твои успехи? Плохо?", "push qwertyuiop", "push 1234567890", "pop 26", "..." };
    //    Console.WriteLine(ApplyCommands(strings));
    //}
    //private static string ApplyCommands(string[] commands)
    //{
    //    StringBuilder stringBuilder = new();

    //    foreach (string command in commands)
    //    {
    //        //string comm = command[4..].Trim();
    //        //if (command.Contains("push")) Message += command.Substring(5);
    //        //if (command.Contains("pop")) Message = Message.Substring(0, Message.Length - Convert.ToInt32(command.Substring(4)));

    //        if (command.Contains("push")) stringBuilder.Append(command.AsSpan(5));
    //        if (command.Contains("pop")) stringBuilder.Replace(stringBuilder.ToString(), stringBuilder.ToString().Substring(0, stringBuilder.Length - Convert.ToInt32(command[4..])));

    //    }
    //    return stringBuilder.ToString();

    //}

    #endregion ApplyCommands

    #region Useful acquaintances

    //public static Dictionary<string, List<string>> Diary = new()
    //{
    //    {  "Alexandru" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //    {  "Alexei" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //    {  "AlexSamodelnii" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //    {  "Bombonica" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //    {  "Besleaga" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //    {  "Zadrot" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //    {  "Iakubovich" , new List<string> { "sasha1995@sasha.ru", "alex99@mail.ru", "shurik2020@google.com" } },
    //};
    //internal static void Main()
    //{
    //   var dic1 = OptimizeContacts(GetContacts("Al"));
    //   var dic2 = OptimizeContacts(GetContacts("Bes"));

    //    foreach(var str in dic1)
    //    {
    //        Console.Write(str.Key + " - ");
    //        foreach(var email in str.Value)
    //        {
    //            Console.Write($"{email} ");
    //        }
    //        Console.WriteLine();
    //    }
    //    Console.WriteLine();
    //    foreach(var str in dic2)
    //    {
    //        Console.WriteLine(str.Key);
    //    }
    //}
    //internal static List<string> GetContacts(string abbreviature)
    //{
    //    List<string> Contacts = new();
    //    //{
    //    //    //"Alexandru",
    //    //    //"Alexei",
    //    //    //"AlexSamodelnii",
    //    //    //"Bombonica",
    //    //    //"Besleaga",
    //    //    //"Zadrot",
    //    //    //"Iakubovich",
    //    //};
    //    foreach(var value in Diary)
    //    {
    //        Contacts.Add(value.Key);
    //    }
    //    List<string> FoundContacts = new();
    //    foreach(string contact in Contacts)
    //    {
    //        if(contact.Contains(abbreviature)) FoundContacts.Add(contact);
    //    }
    //    return FoundContacts;
    //}
    //private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    //{
    //    var dictionary = new Dictionary<string, List<string>>();
    //    foreach(var contact in contacts)
    //    {
    //        dictionary[contact] = Diary[contact];
    //    }
    //    return dictionary;
    //}

    #endregion Useful acquaintances

    #region Split and Join

    //public class Data
    //{
    //    public string Country { get; set; }
    //    public int Population { get; set; }
    //    public DateTime Date { get; set; }
    //    public string Precentage { get; set; }
    //}

    //public static List<Data> citiesPopulation = new()
    //{
    //};
    //public static void Main(string[] args)
    //{
    //    var var = ReplaceIncorrectSeparators(citiesPopulation.ToString());
    //    foreach(var var1 in var)
    //    Console.WriteLine(var1.ToString());
    //}
    //public static string ReplaceIncorrectSeparators(string text)
    //{
    //    char[] regex = { ':', ';', ',', '.' };
    //    return text.Split(':');
    //}

    #endregion Split and Join

    #region Tests

    //internal static void Main()
    //{
    //    Tests.RunTests("text", new[] { "text" });
    //}
    //[TestFixture]
    //public class Tests
    //{
    //    [TestCase("text", new[] { "text" })]
    //    [TestCase("hello world", new[] { "hello", "world" })]
    //    [TestCase("", new string[0])]
    //    // Вставляйте сюда свои тесты
    //    public static void RunTests(string input, string[] expectedOutput)
    //    {
    //        // Тело метода изменять не нужно
    //        string[] output = input.Split(" ");
    //        if (input == "") output = Array.Empty<string>();
    //        Assert.AreEqual(expectedOutput, output);
    //    }
    //}

    #endregion Tests

    #region RecursiveOperation

    //internal static void Main()
    //{
    //    WriteReversed(new[] { '1', '4', 'a' });
    //}
    //public static void WriteReversed(char[] items, int startIndex = 0)
    //{
    //    if (startIndex < items.Length)
    //        // Выводим в обратном порядке все элементы с индексом больше startIndex
    //        WriteReversed(items, startIndex + 1);
    //    else if (startIndex >= items.Length) return;
    //    // а потом выводим сам элемент startIndex
    //    Console.Write(items[startIndex]);
    //}

    #endregion RecursiveOperation

    #region MakePermutations

    //public static void Main()
    //{
    //    //TestOnSize(1);
    //    //TestOnSize(2);
    //    //TestOnSize(0);
    //    //TestOnSize(3);
    //    TestOnSize(4);
    //}

    //static void TestOnSize(int size)
    //{
    //    var result = new List<int[]>();
    //    MakePermutations(new int[size], 0, result);
    //    foreach (var permutation in result)
    //        WritePermutation(permutation);
    //}
    //static void WritePermutation(int[] permutation)
    //{
    //    var strings = new List<string>();
    //    foreach (var i in permutation)
    //        strings.Add(i.ToString());
    //    Console.WriteLine(string.Join(" ", strings.ToArray()));
    //}
    //static void MakePermutations(int[] permutation, int position, List<int[]> result)
    //{
    //    if (position == permutation.Length)
    //    {
    //        //Console.WriteLine(permutation);
    //        var tempArray = new int[permutation.Length];
    //        for (int i = 0; i < permutation.Length; i++)
    //        {
    //            tempArray[i] = permutation[i];
    //            //if(i==permutation.Length - 1) Console.Write(permutation[i]);
    //            //else Console.Write(permutation[i] + " ");
    //        }
    //        result.Add(tempArray);

    //        //foreach (var i in permutation)
    //        //{
    //        //    Console.Write(i + " ");
    //        //}
    //        Console.WriteLine();
    //        return;
    //    }
    //    else
    //    {
    //        for (int i = 0; i < permutation.Length; i++)
    //        {
    //            //var index = Array.IndexOf(permutation, 0, i, position);
    //            bool found = false;
    //            for (int j = 0; j < position; j++)
    //                if (permutation[j] == i)
    //                {
    //                    found = true;
    //                    break;
    //                }
    //            if (found)
    //                continue;
    //            permutation[position] = i;
    //            MakePermutations(permutation, position + 1, result);



    //        }
    //    }
    //    //permutation[position] = 0;
    //    //MakePermutations(permutation, position + 1, result);
    //    //permutation[position] = 1;
    //    //MakePermutations(permutation, position + 1, result);
    //    //permutation[position] = 2;
    //    //MakePermutations(permutation, position + 1, result);
    //    //permutation[position] = 3;
    //    //MakePermutations(permutation, position + 1, result);

    //}

    #endregion MakePermutations

    #region BinarySearch

    //internal static void Main(string[] args)
    //{
    //    var array = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 14 };
    //    Console.WriteLine(Tests.BinSearchLeftBorder(array, 8, -1, array.Length, 7));
    //}

    #endregion BinarySearch

    #region CalcMethod Recursion
    //static int Calc(int n)
    //{
    //    int res = 1;
    //    if (n > 1)
    //        res = Calc(n - 1) + Calc(n - 2);
    //    return res;
    //}

    //public static void Main()
    //{
    //    Console.WriteLine(6/10);
    //    //Console.WriteLine(Calc(3));
    //}
    #endregion

    #region BubleSortRange
    //internal static void Main()
    //{
    //    int[] array = { 4, 2, 3, 1}; // 1234
    //    foreach (var element in array)
    //    {
    //        Console.Write(element + " ");
    //    }
    //    Console.WriteLine();
    //    BubbleSortRange(array, 0, 3);
    //    foreach(var element in array)
    //    {
    //        Console.Write(element + " ");
    //    }
    //}
    //public static void BubbleSortRange(int[] array, int left, int right)
    //{
    //    for (int i = 0; i <= right; i++)
    //        for (int j = left; j < right; j++)
    //            if (array[j] > array[j + 1])
    //            {
    //                (array[j], array[j + 1]) = (array[j + 1], array[j]);
    //            }
    //}
    #endregion

    #region Create a class with menu
    //public class MenuItem
    //{
    //    public string Caption { get; set; }
    //    public string HotKey { get; set; }
    //    public MenuItem[] Items { get; set; }
    //    public static MenuItem[] GenerateMenu()
    //    {
    //        return new[] {

    //       new MenuItem {
    //           Caption = "File",
    //           HotKey = "F",
    //           Items = new MenuItem[]{
    //               new MenuItem {
    //                   Caption = "New",
    //                   HotKey = "N"},
    //               new MenuItem {
    //                   Caption = "Save",
    //                   HotKey = "S"
    //               }
    //           }
    //       },
    //       new MenuItem {
    //           Caption = "Edit",
    //           HotKey = "E",
    //           Items = new MenuItem[]{
    //               new MenuItem {
    //                   Caption = "Copy",
    //                   HotKey = "C"},
    //               new MenuItem {
    //                   Caption = "Paste",
    //                   HotKey = "V"
    //               }
    //           }
    //       },
    //    };
    //    }

    //}
    ///*
    //На верхнем уровне должно находиться два пункта: File (F) и Edit (E).

    //Меню File должно содержать команды New (N), Save (S).

    //Меню Edit (E) должно содержать команды Copy (C) и Paste (V).

    // */


    #endregion

    #region Create a extension method for string
    //public static class StringExtension
    //{
    //    public static int ToInt(this string str)
    //    {
    //        return Convert.ToInt32(str);
    //    }
    //}

    //public static class Point
    //{

    //}
    #endregion


    internal static void Main()
    {
        int b = 99,c = 10;
        var a = (int b, int c) => { return b / c; };
        var z = () => { return b / c; };
        Console.WriteLine(a(b,c));

        var a1 = delegate() { return 12; };
        Console.WriteLine(a1());
    }
}





