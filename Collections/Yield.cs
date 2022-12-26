namespace Collections
{
    internal class Yield
    {
        internal static void Main()
        {
            Numbers numbers = new Numbers(); // Lista creata o vom primi indata la crearea obiectului de tip Numbers.
            foreach (int num in numbers) // Trecerea prin toata lista
            {
                Console.WriteLine(num);
            }
            int index = 5;
            int fact = 1;
            foreach (int factor in Factorial.FactorialOfNumber(index))
            {
                fact *= factor;
            }
            Console.WriteLine(fact);
        }
    }

    internal class Numbers
    {
        public IEnumerator<int> GetEnumerator() // Pentru a primi aceasta Lista folosind Operatotul yield trebuie sa punem ca valoare returnabila IEnumerator<int>
        {
            for (int i = 0; i < 13; i++)
            {
                // Yield returneaza valoarea dar tine minte locatia fiecarei valori, In cazul daca era doar return atunci se va returna doar valoarea 0
                yield return i * i; // creaza o lista care mai apoi este transmisa in programul principal
            }
        }
    }

    internal class Factorial
    {
        public static IEnumerable<int> FactorialOfNumber(int Number)  // Cu ajutorul interfetei IEnumeable noi primim o lista din obiectele transmise adineaori
        {
            while (Number >= 1)
            {
                yield return Number; Number--;
            }
        }
    }

    // Diferentele dintre IEnumerator si IEnumerable sunt:
    /*
     *              IEnumerator                                     IEnumerable
     *      Transmite o valoare de adevar                    Transmite o lista de valori
     *    Contine 3 metode diferite: MoveNext()        Contine o metoda care face trimitere
     *    Current() si Reset()                         la alta interfata
     *
     *
     *
     */
}