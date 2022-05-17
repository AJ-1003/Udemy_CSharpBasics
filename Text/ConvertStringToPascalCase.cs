using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class ConvertStringToPascalCase
    {
        public string ConvertString(string userInput)
        {
            var words = userInput.Split(' ');
            var wordsToConvert = new List<string>();

            foreach (var word in words)
            {
                var convertedWord = word.Substring(0, 1).ToUpper() + word.Substring(1);
                wordsToConvert.Add(convertedWord);
            }

            string? output = string.Join("", wordsToConvert);

            return output;
        }
    }
}
