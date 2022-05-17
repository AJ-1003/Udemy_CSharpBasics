using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    public class DisplayUniqueNumbers
    {
        public List<double> DisplayNumbers(List<double> numbers)
        {
            var uniqueNumbers = new List<double>();

            foreach (int number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                }
            }

            return uniqueNumbers;
        }
    }
}
