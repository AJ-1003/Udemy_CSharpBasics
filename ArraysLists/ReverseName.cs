using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    public class ReverseName
    {
        public string ReverseNameInput(string name)
        {
            var reversedName = "";
            var nameLength = name.Length;
            var nameLetters = new string[nameLength];
            var letterIndex = 0;

            foreach (var letter in name)
            {
                nameLetters[letterIndex] = letter.ToString();
                letterIndex++;
            }

            Array.Reverse(nameLetters, 0, nameLength);

            foreach (var letter in nameLetters)
            {
                reversedName += letter.ToString();
            }

            return reversedName;
        }
    }
}
