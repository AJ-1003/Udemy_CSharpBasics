using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    
    public class SumUserNumbers
    {
        public double CalculateUserNumberInput(List<double> inputNumbers)
        {
            double sum = 0;
            foreach (int number in inputNumbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
