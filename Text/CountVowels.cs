using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class CountVowels
    {
        public int CountNumberOfVowels(string word)
        {
            var numberOfVowels = 0;
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (var letter in word)
            {
                if (vowels.Contains(letter))
                {
                    numberOfVowels++;
                }
                else
                {
                    continue;
                }
            }

            return numberOfVowels;
        }
    }
}
