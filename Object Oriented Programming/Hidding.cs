using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    // Ascunderea metodelor si a proprietatilo din clasa de baza 
    internal class Hidding
    {
        internal static void Main()
        {
            Employee employee= new Employee();
            employee.Name = "Aliosha";
            employee.ID = 1;
            employee.Company = "Moldcell";

            employee.Print();
        }
    }

    class Person
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public void Print()
        {
            Console.Write($"ID={ID} Name={Name} ");
        }

    }
    class Employee : Person
    {
        public new string? Name
        {
            get { return $"Mr./Ms. {base.Name}"; }
            set { base.Name = value; }
        }
        public string? Company { get; set; }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Company={Company}");
        }
    }
}
