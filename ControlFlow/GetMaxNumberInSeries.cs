using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class GetMaxNumberInSeries
    {
        public int MaxNumber(List<int> numbers)
        {
            var maxValue = 0;

            foreach (var number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }

            return maxValue;
        }
    }
}
