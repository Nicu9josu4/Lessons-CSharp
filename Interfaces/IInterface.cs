namespace Interfaces
{
    // Sa presupunem ca aceasta interfata reprezinta miscarea personajelor di MK X
    //internal interface IKeys
    //{
    //    string Key { get; }
    //}

    internal interface IMoves //: IKeys
    {
        void Moves(string? moves);
    }

    internal interface IConcretMoves : IMoves // Mostenirea unei interfete de la alta
    {
        void Jump() => Console.WriteLine("Skorpion jumped");

        void MoveRight() => Console.WriteLine("Skorpion moved right");

        void Down() => Console.WriteLine("Skorpion bent down");

        void MoveLeft() => Console.WriteLine("Skorpion moved left");
    }

    // in clasele ce se implementeaza de la aceasta interfata obligatoriu trebuie sa contina aceleasi metode si campuri care le contine o interfata
    internal class Skorpion : IConcretMoves // Implementarea unei interfete
    {
        void IMoves.Moves(string? moves)
        {
            string comboMoves;
            string forcedMoves;
            for (int i = 0; i < moves?.Length; i++)
            {
                if (i + 1 < moves?.Length) forcedMoves = moves[i].ToString() + moves[i + 1].ToString();
                else forcedMoves = "";
                if (i + 2 < moves?.Length) comboMoves = moves[i].ToString() + moves[i + 1].ToString() + moves[i + 2].ToString();
                else comboMoves = "";
                switch (comboMoves?.ToLower())
                {
                    case "sak": Console.WriteLine($"{GetType().Name} is teleporting"); i += 2; continue;
                    case "adi": Console.WriteLine($"{GetType().Name} has drop a arrow"); i += 2; continue;
                }
                switch (forcedMoves?.ToLower())
                {
                    case "si": Console.WriteLine($"{GetType().Name} get a PunchUp"); i += 1; continue;
                }
                switch (moves?[i])
                {
                    case 'W' or 'w': Jump(); break;
                    case 'S' or 's': Down(); break;
                    case 'A' or 'a': MoveLeft(); break;
                    case 'D' or 'd': MoveRight(); break;
                    default:
                        //Console.WriteLine($"You have pressed:{moves?[i]} here - Don't exist this button");
                        break;
                }
            }
        }

        public void Jump() => Console.WriteLine($"{GetType().Name} jumped");

        public void MoveRight() => Console.WriteLine($"{GetType().Name} moved right");

        public void Down() => Console.WriteLine($"{GetType().Name} bent down");

        public void MoveLeft() => Console.WriteLine($"{GetType().Name} moved left");
    }

    internal class Milena : IConcretMoves // Implementarea unei interfete
    {
        void IMoves.Moves(string? moves)
        {
            string comboMoves;
            string forcedMoves;
            for (int i = 0; i < moves?.Length; i++)
            {
                if (i + 1 < moves?.Length) forcedMoves = moves[i].ToString() + moves[i + 1].ToString();
                else forcedMoves = "";
                if (i + 2 < moves?.Length) comboMoves = moves[i].ToString() + moves[i + 1].ToString() + moves[i + 2].ToString();
                else comboMoves = "";
                switch (comboMoves?.ToLower())
                {
                    case "ssk": Console.WriteLine($"{GetType().Name} is teleporting"); i += 2; continue;
                    case "asj": Console.WriteLine($"{GetType().Name} has drop a kunai"); i += 2; continue;
                }
                switch (forcedMoves?.ToLower())
                {
                    case "si": Console.WriteLine($"{GetType().Name} get a PunchUp"); i += 1; continue;
                }
                switch (moves?[i])
                {
                    case 'W' or 'w': Jump(); break;
                    case 'S' or 's': Down(); break;
                    case 'A' or 'a': MoveLeft(); break;
                    case 'D' or 'd': MoveRight(); break;
                    default:
                        //Console.WriteLine($"You have pressed:{moves?[i]} here - Don't exist this button");
                        break;
                }
            }
        }

        public void Jump() => Console.WriteLine($"{GetType().Name} jumped");

        public void MoveRight() => Console.WriteLine($"{GetType().Name} moved right");

        public void Down() => Console.WriteLine($"{GetType().Name} bent down");

        public void MoveLeft() => Console.WriteLine($"{GetType().Name} moved left");
    }
}