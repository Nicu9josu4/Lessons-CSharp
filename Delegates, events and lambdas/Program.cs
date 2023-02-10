 // Delegates, events and lambdas

using Delegates__events_and_lambdas;

internal class Program
{
    // Un delegat este un obiect care se referă la o metodă sau puteți spune că este o variabilă de tip referință care poate conține o referință la metode.
    /*
     *  Delegații încapsulează atât o instanță de obiect, cât și o metodă. (Incapsulare)
     *                                                                     > Definiția sa principală se referă la acțiunea de a ascunde orice lucru care nu este esențial de lumea exterioară.
     *  Delegații permit ca metodele să fie transmise ca parametri.
     *  Delegații pot fi legați împreună; de exemplu, mai multe metode pot fi apelate la un singur eveniment.
     *
     *  Expresiile Lambda sunt o modalitate mai concisă de a scrie blocuri de cod inline.
     *  Expresiile Lambda (în anumite contexte) sunt compilate pentru tipurile delegate.
     */

    

    public static void Main()
    {
        UsingFuncActionPredicate();
        
        //Func<int, string> toString = x => x.ToString("X"); // hex
        //Func<double, int> round = x => (int)Math.Round(x);
        //var f1 = Combine(round, toString);
        //Console.WriteLine(f1(3.14)); // 3
        //Console.WriteLine(f1(10.9)); // B 


        //Func<int, int> doubleValue = x => 2 * x;
        //Func<int, int> minusOne = x => x - 1;
        //var f2 = Combine(minusOne, doubleValue);
        //Console.WriteLine(f2(2)); // 2
        //Console.WriteLine(f2(5)); // 8
    }
    static Func<T1, T3> Combine<T1, T2, T3>(Func<T1, T2> roundFunction, Func<T2, T3> toStringFunction)
    {
        return x => toStringFunction(roundFunction(x));
    }

    #region using func action and predicate


    // in cazul delegatei Message vom avea tipul de returnare void iar parametrii nu vor exista
    private delegate void Message();
    // in cazul delegatei Opperation vom avea tipul de returnare int iar parametrii de intrare vor fi doua variabile de tip int
    private delegate int Opperation(int a, int b);
    public static void UsingFuncActionPredicate()
    {
        #region basic delegate

        //SomeAction someActions = new();
        //someActions.Action += DisplayAction;

        //Message message = someActions.SayHello; // adding first method from Hello Class
        //message += someActions.SayHi;
        //message += someActions.SayHello;
        //message += someActions.SayHi;

        //Message message1 = message is null ? message : message -= someActions.SayHi; // Ternary operand
        //                                                                             // message1 = daca message este null atunci message1 = message daca nu atunci message1 = message - So,eActions.SayHi;
        //message1?.Invoke(); // o metoda pentru a chema delegata
        //                    // Diferenta dintre message1(); si message1?.Invoke() este in urmatoarea
        //                    // Daca apare o eroare in urma chemarii acestei delegate atunci:
        //                    // message1();          programul se va stopa
        //                    // message1?.Invoke();  va continua executarea fara a afisa corpul delegatei si nici eroarea

        //Opperation opperation = someActions.SumNumbers;
        //opperation += someActions.MultiplyNumbers;

        //Console.WriteLine(opperation(5, 7)); // ne va afisa 35 deoarece se ia in calcul ultima operatie adaugata
        //opperation -= someActions.MultiplyNumbers;
        //Console.WriteLine(opperation?.Invoke(5, 7)); // Ne va afisa 12 deoarece ramane doar verificarea sumei dintre aceste douna numere

        //opperation -= someActions.SumNumbers;
        //Console.WriteLine(opperation(5, 7)); // Vom avea exceptie deoarece delegatul poate fi null, adica el acum este null
        //                                     // pentru a nu primi eroarea ca delegata este null este necesar sa facem verificarea la null prin if <delegate is not null> sau prin metoda Invoke al delegatei
        //                                     // Daca in ultima afisare pe consola vom schimba [opperation(5, 7) => opperation?.Invoke(5, 7)] operatia nu se va executa dar nici eroare nu ne va afisa!


        #endregion

        //void DisplayAction(string action) => Console.WriteLine(action);
        int[] ints1 = { 1, 4, 5, 19, 52, 6 };
        float[] floats2 = { 1.02f, 4.56f, 5.66f };

        WriteSumFunc(ints1, SumInt, InsertInLogs, Verify);
        WriteSumFunc(floats2, SumFloat, SendMessage, Verify);
    }
    // Folosirea delegatei Func si Action
    public static void WriteSumFunc<T>(T[] arrayofObjects, Func<T, T, T> sum, Action<T> act, Predicate<T[]> predicate)
    {
        T Sum = default;
        bool check = predicate(arrayofObjects);
        if (check)
            foreach (var number in arrayofObjects)
                Sum = sum(Sum, number);
        act(Sum);
    }

    #endregion

    public static int SumInt(int a, int b) => a + b;
    public static float SumFloat(float a, float b) => a + b;
    public static void InsertInLogs<T>(T numerar) => Console.WriteLine(numerar + " is inserted in logs");
    public static void SendMessage<T>(T numerar) => Console.WriteLine(numerar + " send to user");
    public static bool Verify<T>(T[] numbers)
    {
        if(numbers.Length > 5) return true; 
        return false;
    }




}