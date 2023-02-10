﻿using System;
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
        //    //string number = "44353";
        //    //string number1 = "1123";

        //    ////Console.WriteLine($"{number} + {number1} = {number.ToInt() + number1.ToInt()}");
        //    //Console.WriteLine(number.CompareInts(number1));
        //    int number2 = 6;
        //    Console.WriteLine(number2.Factorial());
        //}
    }

    public static class StringExtension
    {
        //public static int ToInt(this string str)
        //{
        //    return Convert.ToInt32(str);
        //}
        public static bool CompareInts(this string str, string str1) => Convert.ToInt32(str) > Convert.ToInt32(str1);
        public static int ToInt(string str)
        {
            return Convert.ToInt32(str);
        }
    }
    public static class IntExtension
    {
        public static int Factorial(this int number)
        {
            if (number == 0) return 1;
            return Factorial(number-1) * number;
        }
    }
}

