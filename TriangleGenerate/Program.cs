namespace TriangleProgram
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int? n;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            //Console.Write("i=");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Numerele se incep cu n*n adunandu-se apoi cu 2 fiecare");
            //for (int k, i = 1; i <= n; i++)
            //{
            //    Console.Write(i.ToString("D2") + "= ");
            //    k = i * i;
            //    for (int j = i; j > 0; j--) {
            //        Console.Write(k.ToString("D3") + " ");
            //        k += 2;
            //    }
            //    Console.WriteLine();
            //}
            for (int k = 1, n1 = 2, FirstNumber = 1; i <= n; i++)
            {
                n1 += i; // Numarul cu care se sumeaza initialul
                Console.Write(i.ToString("D2") + "= ");
                for (int j = i; j > 0; j--)
                {
                    Console.Write(k.ToString("D3") + " ");
                    k += 2; // Numerele sumate
                }
                FirstNumber += n1;
                k = FirstNumber;

                //k += last;
                Console.WriteLine();
            }

            ShowNumbers(i, n);

            /*  1  + 0  + 0   = 1
             *  2  + 1  + 1   = 4
             *  3  + 2  + 4   = 9
             *  5  + 3  + 9   = 17
             *  8  + 4  + 17  = 29
             *  12 + 5  + 29  = 46
             *  17 + 6  + 46  = 69
             *  23 + 7  + 69  = 99
             *  30 + 8  + 99  = 137
             *  38 + 9  + 137 = 184
             *  47 + 10 + 184 = 241
             *  57 + 11 + 241 = 309
             */
        }

        internal static void ShowNumbers(int i, int? n)
        {
            for (int k = 1, n1 = 2, FirstNumber = 1; i <= n; i++)
            {
                n1 += i; // Numarul cu care se sumeaza initialul
                Console.Write(i.ToString("D2") + "= ");
                for (int j = i; j > 0; j--)
                {
                    Console.Write(k.ToString("D3") + " ");
                    k += 2; // Numerele sumate
                }
                FirstNumber += n1;
                k = FirstNumber;

                //k += last;
                Console.WriteLine();
            }
        }
    }
}