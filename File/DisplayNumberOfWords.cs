using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    public class DisplayNumberOfWords
    {
        public int NumberOfWords(string path)
        {
            int numberOfWords;

            var content = File.ReadAllText(path);
            var words = content.Split(new char[] {',', ' ', '.'});
            numberOfWords = words.Length;

            return numberOfWords;
        }
    }
}