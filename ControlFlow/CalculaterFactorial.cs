using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class CalculaterFactorial
    {
        public int CalcFactorial(int number)
        {
            int factorial = number;
            for (var i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
