namespace Interfaces
{
    internal class Program
    {
        // O interfață reprezintă un tip de referință care poate defini o anumită funcționalitate - un set de metode și proprietăți fără implementare.
        // Apoi această funcționalitate este implementată de clase și structuri care folosesc aceste interfețe.
        public static void Main(string[] args)
        {
            IConcretMoves skorpion = new Skorpion();
            Console.WriteLine("How Skorpion move");
            skorpion.Moves(Console.ReadLine());
            Console.WriteLine();
            IConcretMoves milena = new Milena();
            Console.WriteLine("How Milena move");
            milena.Moves(Console.ReadLine());

            Console.ReadKey();
        }
    }
}