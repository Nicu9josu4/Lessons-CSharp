using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_.NET_Classes_and_Structures
{
    internal class Overloading
    {
        //private static void Main(string[] args)
        //{
        //    #region Supraincarcarea sau conversiunea dintre tipurile de baza
        //    // Supraincarcare sau conversie dintre 2 tipuri standarte cum ar fi:
        //    long a = 12231;
        //    int b = (int)a; // conversie explicită      Explicit - Cel care este explicat
        //    long c = b;     // conversie implicită      Implicit - Care se subintelege
        //    Console.WriteLine(c);
        //    #endregion

        //    #region Convertarea dintre tipurile de baza si obiectele de tip clasa
        //    Number num1 = new Number { intNumber = 66 };
        //    int num2 = (int)num1;   // Explicit  -> Se cauta metoda care contine explicit operator int(Number num)
        //    Number num3 = num2;     // Implicit  -> Se cauta metoda care contine implicit operator Number(int num)
        //    Console.WriteLine(num3.intNumber);
        //    #endregion

        //    #region Convertarea Obiect catre Obiect
        //    EndWorkDay fwDay = new(); // Crearea unui obiect de tip EWD
        //    Console.WriteLine($"Full time of end of workd day - Hours:{fwDay.Hours} Minutes:{fwDay.Minutes} Seconds:{fwDay.Seconds}");
        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //    WorkDayInSeconds workDayInSeconds = (WorkDayInSeconds)fwDay; // Convertarea explicita
        //    Console.WriteLine($"Seconds left until the end (Seconds from class) - {workDayInSeconds.Seconds}");
        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //    int seconds = (int)workDayInSeconds; // Convertarea explicita
        //    Console.WriteLine($"Seconds left until the end (Seconds from variable) - {seconds}");
        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //    WorkDayInSeconds workDayInSeconds1 = seconds; // Convertarea implicita
        //    Console.WriteLine($"Seconds left until the end (Seconds from class after converting from variable) - {workDayInSeconds1.Seconds}");
        //    #endregion
        //    Console.ReadKey();
        //}
    }

    internal class Number
    {
        public int intNumber { get; set; }

        // In cazul cand va fi apelata aceasta supraincarcare implicita, se va crea un nou obiect de tip Number si deasemenea se va returna cu valoarea noua fiind num
        public static implicit operator Number(int num) { return new Number { intNumber = num}; }
        // In cazul cand va fi apelata aceasta supraincarcare implicita, se va returna valoarea numarului care-l contine obiectul de tip Number
        public static explicit operator int(Number num) { return num.intNumber; }
    }
    internal class EndWorkDay
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public EndWorkDay()
        {
            // Se calculeaza restul timpului pana la finalul zilei de lucru, adica pana la ora 18:00
            TimeOnly Time = new TimeOnly(18,00,00);
            Hours = Time.Hour > DateTime.Now.Hour ? Time.Hour - DateTime.Now.Hour : 0; // Se atribuie fiecarei proprietati valoarea anumita
            Minutes = Time.Minute > DateTime.Now.Minute ? Time.Minute - DateTime.Now.Minute : Hours -= 1; Minutes += (60 - DateTime.Now.Minute - Hours);
            Seconds = Time.Second > DateTime.Now.Second ? Time.Second - DateTime.Now.Second : Minutes -= 1; Seconds += (60 - DateTime.Now.Second - Minutes);

        }
    }
    internal class WorkDayInSeconds // Clasa care contine timpul pana finalul zile de lucru in secunde
    {
        public int Seconds { get; set;}

        public static implicit operator WorkDayInSeconds(int seconds) // Convertarea implicita din int in obiect de tip clasa
        {
            return new WorkDayInSeconds { Seconds = seconds };
        }
        public static explicit operator int(WorkDayInSeconds WorkDay) // Convertarea explicita din Obiectul de tip clasa la int
        {
            return WorkDay.Seconds;
        }
        public static explicit operator WorkDayInSeconds(EndWorkDay endWorkDay) // Convertarea explicita din Obiectul de tip EndWorkDay in tipul WorkDayInSeconds
        {
            return new WorkDayInSeconds { Seconds = endWorkDay.Hours * 3600 + endWorkDay.Minutes * 60 + endWorkDay.Seconds };
        }
        public static implicit operator EndWorkDay(WorkDayInSeconds workDayInSeconds)// Convertarea implicita din Obiectul de tip WorkDayInSeconds in tipul EndWorkDay
        {
            return new EndWorkDay();
        }
    }
}


#region Exemple de implicit si explicit
// Eu pot fi ca El daca ma imbrac altfel si daca ma voi comporta ca el asta inseamna explicit, se explica ce se cere
// Eu pot fi ca tatal meu deoarece eu sunt fiul lui, asta este deja implicit adica se subintelege
#endregion