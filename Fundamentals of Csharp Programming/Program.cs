internal class Fundamentals
{
    private static void Main(string[] args)
    {
        // program structure:
        Console.WriteLine("Hello World!");

        // Variables:
        int a;
        char b = 'a';
        string? s = Console.ReadLine();

        a = 10;
        Console.WriteLine($"a= {a}, b= {b}, s= {s}");
        // enum call:
        Console.WriteLine(Week.friday.ToString());
        Console.WriteLine(Week.sunday);
    }
}

// enum:
internal enum Week
{
    monday,
    thuesday,
    wednesday,
    friday,
    sunday,
    saturday
}

#region Rules
/*
 *   In C# sunt:
 *      Constructori - ne permite sa configuram crearea obiectului dupa constructorii creati, 
 *          - Acesti constructori pot fi supraincarcati si cu diferiti parametri
 *      Destructori - << colectare gunoi >> atunci cand se creeaza un obiect cu ajutorul operatorului new() este alocata memorie, 
 *          - si in cazul cand el deja nu se mai foloseste utilizatorul nu atrage atentia, 
 *          - in caz ca avem mai multe obiecte si care sunt inca de dimensiuni mari 
 *          - atucni destructorul ne va permite sa eliberam memoria alocata pentru ca programul sa ruleze mai rapid 
 *      Deconstructori - ne permite dezasamblarea clasei sau a tipului in campurile sale folosind Tupluri (int, int, string) = new class
 *      
 *      
 *   Memoria statică: tipul de memorie care este definită în timpul compilării . 
 *      - Acest spațiu de memorie este rezervat pentru o variabilă și nu poate fi modificat în timpul execuției.
 *   Memorie dinamică : tipul de memorie utilizat în timpul rulării . 
 *      - Acest spațiu de memorie este rezervat și pentru o variabilă, dar în acest caz poate fi modificat în timpul execuției.
 *      
 *      
 *   O metodă statică în C# este o metodă care păstrează o singură copie a metodei la nivel de tip, nu la nivel de obiect. 
 *      Aceasta înseamnă că toate instanțele clasei partajează aceeași copie a metodei și a datelor acesteia. 
 *      Ultima valoare actualizată a metodei este partajată între toate obiectele acelui tip. 
 *   Metodele statice sunt apelate folosind numele clasei, nu instanța clasei. 
 */
#endregion