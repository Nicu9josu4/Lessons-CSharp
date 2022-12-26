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

    private delegate void Message();

    // in cazul delegatei Message vom avea tipul de returnare void iar parametrii nu vor exista
    private delegate int Opperation(int a, int b);

    // in cazul delegatei Opperation vom avea tipul de returnare int iar parametrii de intrare vor fi doua variabile de tip integer

    public static void Main()
    {
        SomeAction someActions = new();
        someActions.Action += DisplayAction;

        Message message = someActions.SayHello; // adding first method from Hello Class
        message += someActions.SayHi;
        message += someActions.SayHello;
        message += someActions.SayHi;

        Message message1 = message is null ? message : message -= someActions.SayHi; // Ternary operand
                                                                                     // message1 = daca message este null atunci message1 = message daca nu atunci message1 = message - So,eActions.SayHi;
        message1?.Invoke(); // o metoda pentru a chema delegata
                            // Diferenta dintre message1(); si message1?.Invoke() este in urmatoarea
                            // Daca apare o eroare in urma chemarii acestei delegate atunci:
                            // message1();          programul se va stopa
                            // message1?.Invoke();  va continua executarea fara a afisa corpul delegatei si nici eroarea

        Opperation opperation = someActions.SumNumbers;
        opperation += someActions.MultiplyNumbers;

        Console.WriteLine(opperation(5, 7)); // ne va afisa 35 deoarece se ia in calcul ultima operatie adaugata
        opperation -= someActions.MultiplyNumbers;
        Console.WriteLine(opperation?.Invoke(5, 7)); // Ne va afisa 12 deoarece ramane doar verificarea sumei dintre aceste douna numere

        opperation -= someActions.SumNumbers;
        Console.WriteLine(opperation(5, 7)); // Vom avea exceptie deoarece delegatul poate fi null, adica el acum este null
                                             // pentru a nu primi eroarea ca delegata este null este necesar sa facem verificarea la null prin if <delegate is not null> sau prin metoda Invoke al delegatei
                                             // Daca in ultima afisare pe consola vom schimba [opperation(5, 7) => opperation?.Invoke(5, 7)] operatia nu se va executa dar nici eroare nu ne va afisa!

        void DisplayAction(string action) => Console.WriteLine(action);
    }
}