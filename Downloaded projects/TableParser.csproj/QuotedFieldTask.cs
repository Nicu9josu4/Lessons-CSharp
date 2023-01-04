using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TableParser
{
    [TestFixture]
    public class QuotedFieldTaskTests
    {
        [TestCase("\"bcd ef\" a 'x y'", 0, "bcd ef a x y", 3)]
        [TestCase("'a'", 0, "a", 1)]
        public void Test(string line, int startIndex, string expectedValue, int expectedLength)
        {
            var actualToken = QuotedFieldTask.ReadQuotedField(line, startIndex);
            Assert.AreEqual(new Token(expectedValue, startIndex, expectedLength), actualToken);
        }

        // Добавьте свои тесты
    }

    class QuotedFieldTask
    {
        public static Token ReadQuotedField(string line, int startIndex)
        {
            var strings = line.Split('\"', '\'');
            string stringgs = "";
            foreach(var s in strings)
            {
                if(s!="")
                    stringgs += s;
            }
            return new Token(stringgs, startIndex, line.Length - startIndex);
        }
    }
}
