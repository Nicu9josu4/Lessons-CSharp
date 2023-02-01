using System;
using System.Collections.Generic;
using System.Linq;

namespace Passwords
{
    public class CaseAlternatorTask
    {
        //Тесты будут вызывать этот метод
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            // TODO

            if (startIndex == word.Length)
            {
                var tempArray = new string[word.Length];
                for (int i = 0; i < word.Length; i++)
                {
                    tempArray[i] = word[i];
                }
                result.Add(tempArray[0]);
                return;
            }
            else
            {
                
                foreach(char character in word) { 
                    bool found = false;
                    for (int j = 0; j < startIndex; j++)
                        if (word[j] == character)
                        {
                            found = true;
                            break;
                        }
                    if (found)
                        continue;
                    word[startIndex] = character;
                    AlternateCharCases(word, startIndex + 1, result);
                }
            }

            result.Add(new string (word));
        }

        static void MakePermutations(int[] permutation, int position, List<int[]> result)
        {
            if (position == permutation.Length)
            {
                var tempArray = new int[permutation.Length];
                for (int i = 0; i < permutation.Length; i++)
                {
                    tempArray[i] = permutation[i];
                }
                result.Add(tempArray);
                return;
            }
            else
            {
                for (int i = 0; i < permutation.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < position; j++)
                        if (permutation[j] == i)
                        {
                            found = true;
                            break;
                        }
                    if (found)
                        continue;
                    permutation[position] = i;
                    MakePermutations(permutation, position + 1, result);
                }
            }
        }
    }
}