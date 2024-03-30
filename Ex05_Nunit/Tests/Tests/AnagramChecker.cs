using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class AnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string? word1, string? word2)
        {
            if (word1 == null || word2 == null)
            {
                return false;
            }

            string? normalizedWord1 = NormalizeWord(word1);
            string? normalizedWord2 = NormalizeWord(word2);

            return string.Equals(normalizedWord1, normalizedWord2);
        }

        static string? NormalizeWord(string word)
        {
            return string.Concat(word.Where(c => char.IsLetterOrDigit(c)).Select(n => char.ToLower(n)).OrderBy(n=>n));
        }
    }
}
