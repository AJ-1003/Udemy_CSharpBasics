using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class DisplayLongestWord
    {
        public string GetLongestWord(string path)
        {
            var longestWordLength = 0;
            var longestWord = "";

            var content = File.ReadAllText(path);
            var words = content.Split(new char[] {',', '.', ' '});
            foreach (var word in words)
            {
                var longWord = word.Length;
                if (longWord > longestWordLength)
                {
                    longestWordLength = longWord;
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
