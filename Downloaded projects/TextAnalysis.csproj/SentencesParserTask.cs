using System.Collections.Generic;
using System.Linq;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            List<string> sentences = text.Split('.', '!', '?', ';', ':', '(', ')','[', ']').ToList();
            List<string[]> Words = new List<string[]>();
            foreach(var word in sentences)
            {
                Words.Add(word.ToLower().Split(' '));
            }
            sentencesList.Add(sentences);
            
            
            return sentencesList;
        }
    }
}