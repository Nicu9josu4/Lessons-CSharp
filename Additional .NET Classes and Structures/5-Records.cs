﻿namespace Additional_.NET_Classes_and_Structures
{
    internal class Program
    {
        internal static void Main()
        {
            Makaka makaka = new("Obeziana", 20, 5);
            Makaka makaka2 = new("Obeziana", 20, 5);
            Makaka1 mk1 = new("Obeziana", 20, 5);
            //makaka2.ToString();
            Console.WriteLine(makaka);
            Console.WriteLine(makaka2.ToString());
            Console.WriteLine(mk1);

            //makaka.Name = "Makakun"; // init only error

            makaka2 = makaka with // Modificarea datelor din Recordul Makaka
            {
                Name = "Makakun",
                Age = 7
            };
            Console.WriteLine(makaka2);
            Console.WriteLine(makaka == makaka2);

            makaka2.GetName();

            Makaka1 makaka1 = new("Obeza", 25, 10);
            makaka1.PrintMakaka();
            //bool boolValue = makaka1 == makaka; // Error because Makaka1 don't have a operator ==

            (string Name, int Weith, int Age) = new Makaka("Makaka", 20, 20);
            Console.WriteLine(Name, Weith, Age);
        }
    }

    internal record class Makaka(string Name, int Weith, int Age) { 
        public string GetName()
        {
            return Name;
        }
    };

    public class Makaka1
    {
        internal string? Name { get; set; }
        internal int Weith { get; set; }
        internal int Age { get; set; }

        public Makaka1()
        { }

        public Makaka1(string name, int weith, int age)
        {
            Name = name;
            Weith = weith;
            Age = age;
        }

        public static Makaka1 Destructor(string name, int weith, int age) => new(name, weith, age);

        public void PrintMakaka()
        {
            Console.WriteLine($"Name: {Name} Weith: {Weith} Age: {Age}");
        }
    }
}