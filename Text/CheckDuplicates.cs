using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class CheckDuplicates
    {
        public bool CheckForDuplicateNumbers(string numbers)
        {
            bool containsDuplicates;
            var stringNumbers = numbers.Split('-');
            var checkedNumbers = new List<double>();
            var duplicates = new List<double>();

            foreach (var number in stringNumbers)
            {
                var convertedNumber = Convert.ToDouble(number);
                if (checkedNumbers.Contains(convertedNumber))
                {
                    duplicates.Add(convertedNumber);
                }
                else
                {
                    checkedNumbers.Add(convertedNumber);
                }
            }

            if (duplicates.Count > 0)
            {
                containsDuplicates = true;
            }
            else
            {
                containsDuplicates = false;
            }

            return containsDuplicates;
        }
    }
}
