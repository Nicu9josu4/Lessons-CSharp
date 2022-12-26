using System.Diagnostics;

namespace SnakeGame
{
    internal class Program
    {
        private static int speed = 1;
        private static int gridH = 25;
        private static int gridW = 90;
        private static Cell[,] grid = new Cell[gridH, gridW]; // Aray of class Cell
        private static Cell currentCell;
        private static int direction;
        private static bool Populated = false;
        private static bool Lost = false;

        internal static void Main(string[] args)
        {
            if (!Populated)
            {
                PopulateGrid();
                currentCell = grid[(int)Math.Ceiling((double)gridH / 2), (int)Math.Ceiling((double)gridW / 2)];
                UpdatePos();
                Populated = true;
            }
            while (!Lost)
            {
                Restart();
            }
        }

        private static void Restart()
        {
            Console.SetCursorPosition(0, 0);
            PrintGrid();
            Console.WriteLine("Length: {0}");
            getInput();
        }

        private static void Move()
        {
            if (direction == 0)
            {
                //up
                if (grid[currentCell.y - 1, currentCell.x].val == "*")
                {
                    Lose();
                    return;
                }
                VisitCell(grid[currentCell.y - 1, currentCell.x]);
            }
            else if (direction == 1)
            {
                //right
                if (grid[currentCell.y, currentCell.x - 1].val == "*")
                {
                    Lose();
                    return;
                }
                VisitCell(grid[currentCell.y, currentCell.x - 1]);
            }
            else if (direction == 2)
            {
                //down
                if (grid[currentCell.y + 1, currentCell.x].val == "*")
                {
                    Lose();
                    return;
                }
                VisitCell(grid[currentCell.y + 1, currentCell.x]);
            }
            else if (direction == 3)
            {
                //left
                if (grid[currentCell.y, currentCell.x + 1].val == "*")
                {
                    Lose();
                    return;
                }
                VisitCell(grid[currentCell.y, currentCell.x + 1]);
            }
            Thread.Sleep(speed * 100);
        }

        private static void Lose()
        {
            Console.WriteLine("\n You lose!");
            Thread.Sleep(1000);
            Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Environment.Exit(-1);
        }

        private static void VisitCell(Cell cell)
        {
            currentCell.val = "#";
            currentCell.visited = true;
            currentCell.decay = 0;
            currentCell = cell;
            UpdatePos();
        }

        private static void UpdatePos()
        {
            currentCell.Set("@");
            if (direction == 0)
            {
                currentCell.val = "^";
            }
            else if (direction == 1)
            {
                currentCell.val = "<";
            }
            else if (direction == 2)
            {
                currentCell.val = "v";
            }
            else if (direction == 3)
            {
                currentCell.val = ">";
            }

            currentCell.visited = false;
            return;
        }

        private static void updateScreen()
        {
            Console.SetCursorPosition(0, 0);
            PrintGrid();
            Console.WriteLine("Length: {0}");
        }

        private static void getInput()
        {
            //Console.Write("Where to move? [WASD] ");
            ConsoleKeyInfo input;
            while (!Console.KeyAvailable)
            {
                Move();
                updateScreen();
            }
            input = Console.ReadKey();
            DoInput(input.KeyChar);
        }

        private static void DoInput(char inp)
        {
            switch (inp)
            {
                case 'w':
                    goUp();
                    break;

                case 's':
                    goDown();
                    break;

                case 'a':
                    goRight();
                    break;

                case 'd':
                    goLeft();
                    break;
            }
        }

        private static void goUp()
        {
            if (direction == 2)
                return;
            direction = 0;
        }

        private static void goRight()
        {
            if (direction == 3)
                return;
            direction = 1;
        }

        private static void goDown()
        {
            if (direction == 0)
                return;
            direction = 2;
        }

        private static void goLeft()
        {
            if (direction == 1)
                return;
            direction = 3;
        }

        private static void PopulateGrid()
        {
            for (int col = 0; col < gridH; col++)
            {
                for (int row = 0; row < gridW; row++)
                {
                    Cell cell = new Cell();
                    cell.x = row;
                    cell.y = col;
                    cell.visited = false;
                    if (cell.x == 0 || cell.x > gridW - 2 || cell.y == 0 || cell.y > gridH - 2)
                        cell.Set("*");
                    else
                        cell.Clear();
                    grid[col, row] = cell;
                }
            }
            PrintGrid();
        }

        private static void PrintGrid()
        {
            string toPrint = "";
            for (int col = 0; col < gridH; col++)
            {
                for (int row = 0; row < gridW; row++)
                {
                    grid[col, row].DecaySnake();
                    toPrint += grid[col, row].val;
                }
                toPrint += "\n";
            }
            Console.WriteLine(toPrint);
        }

        private class Cell
        {
            public string val { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public bool visited { get; set; }
            public int decay { get; set; }

            public void DecaySnake()
            {
                decay -= 1;
                if (decay == 0)
                {
                    visited = false;
                    val = " ";
                }
                //else val = " ";
            }

            public void Clear()
            {
                val = " ";
            }

            public void Set(string newVal)
            {
                val = newVal;
            }
        }
    }
}