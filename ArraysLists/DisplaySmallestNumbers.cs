using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLists
{
    public class DisplaySmallestNumbers
    {
        public double[] SmallestNumbers(List<double> numbers)
        {
            var smallestNumbers = new double[3];

            for (int i = 0; i < smallestNumbers.Length; i++)
            {
                foreach (var number in numbers)
                {
                    if ((smallestNumbers[i] > number || smallestNumbers[i] == 0) && !smallestNumbers.Contains(number))
                    {
                        smallestNumbers[i] = number;
                    }
                }
            }           

            return smallestNumbers;
        }
    }
}
