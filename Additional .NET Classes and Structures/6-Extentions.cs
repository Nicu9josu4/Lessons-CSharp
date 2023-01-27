using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_.NET_Classes_and_Structures
{
    class Extentions
    {
        //static void Main()
        //{
        //    string number = "44353";
        //    string number1 = "1123";

        //    Console.WriteLine($"{number} + {number1} = {number.ToInt() + number1.ToInt()}");
        //}
    }

    public static class StringExtension
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}

