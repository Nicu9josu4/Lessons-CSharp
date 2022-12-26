namespace ConsoleApp1
{
    internal class Parinte // Internal, disponibil doar in namespace-ul dat
    {
        // Câmpuri – variabile membru de un anumit tip, definite la nivel de clasă
        // Proprietăți – un tip special de construct de programare, care ne ajută să manipulăm câmpurile și să setăm proprietățile obiectului

        // Campurile poate avea proprietati precum {get; set;}. Ele sunt folosite pentru a atribui valori campurilor (set) sau a le returna din ele (get)
        private string? culoareOchi; // Campul culoareOchi

        // Proprietatea CuloareOchi
        private string? CuloareOchi
        { get { return culoareOchi; } set { culoareOchi = value; } } // disponibil doar din clasa data 'Parinte' Toate metodele poate avea acces la valoarea ce o detine

        // Proprietatea Name
        protected string? Name { get; init; } // Disponibil in clasa Parinte si in clasa derivata (Copil)

        // Proprietatea Surname
        internal string? Surname { get; private set; } // Disponibil in tot asemblerul in tot namespace

        // Properietatea Nas
        public int Nas { get; set; } = 2;// Disponibil din tot proiectul indiferent de namespace

        // Proprietatiele sau campurile care au in urma tipajului semnul '?' atunci ele semnifica ca poate contine valoare NULL in loc de valoare definita tipului

        // constructor:
        // Sarcina constructorului este aceea de a inițializa memoria alocată pentru obiect, unde vor fi stocate câmpurile sale
        public Parinte()
        { } // Constructor fara parametri, el creaza obiectul Parinte cu valorile sale NULL ca mai apoi sa fie prelucrat

        public Parinte(string Ochi) // simplified /* public Parinte(string Ochi) => this.Ochi = Ochi; */
        {
            this.CuloareOchi = Ochi;
        }

        public Parinte(string ochi, int nas)
        {
            CuloareOchi = ochi;
            Nas = nas;
        }

        public Parinte(string? ochi, string? name, string? surname) : this(ochi ?? "Undefined")
        {
            Name = name;
            Surname = surname;
        }

        public Parinte(string? ochi, string? name, string? surname, int nas) : this(ochi ?? "Undefined") // ?? este un operator de verificare a valorii la NULL, in cazul in care ea va fi null atunci valoare null se va inlocui cu textul undefined
        {
            Name = name;
            Surname = surname;
            Nas = nas;
        }

        // Metode – implementează funcționalitatea obiectului.

        public virtual void Print()
        {
            Console.WriteLine($"{Name} {Surname} are:");
            Console.WriteLine($"Ochii de culoare: {culoareOchi} iar nasul are lungimea de {Nas} cm");
        }

        // supraincarcarea metodei DisplayName
        // adica ea cand este chemata poate primi parametrii Name, Surname sau nici-un parametru. In dependenta de parametri ea va efectua metoda necesara.
        public void DisplayName()
        {
            Console.WriteLine($"Salut {Name} {Surname}");
        }

        public void DisplayName(string Name)
        {
            Console.WriteLine($"Salut {Name} {Surname}");
        }

        public void DisplayName(string Name, string Surname)
        {
            Console.WriteLine($"Salut {Name} {Surname}");
        }

        public void DisplayName(string Name, int Nas)
        {
            Console.WriteLine($"Salut {Name} are nasul de {Nas} cm");
        }
    }

    internal class Copil : Parinte
    {
        public string? CuloareOchi { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Ochi de culoare: {CuloareOchi} iar nasul are lungimea de {base.Nas} cm");
        }
    }
}