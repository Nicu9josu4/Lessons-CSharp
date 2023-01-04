using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULearn
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 14 }, 2, -1, 11, 1)]
        [TestCase(new long[] { 1, 2, 3 }, 2, -1, 3, 1)]
        public static int BinSearchLeftBorder(long[] array, long value, int left, int right, int returnedIndex = 0)
        {
            if (left == right - 1) { Assert.AreEqual(returnedIndex, left + 1); return left + 1; }
            var m = (left + right) / 2;
            if (array[m] < value)
                return BinSearchLeftBorder(array, value, m, right, returnedIndex);
            return BinSearchLeftBorder(array, value, left, m, returnedIndex);
        }
    }
}
