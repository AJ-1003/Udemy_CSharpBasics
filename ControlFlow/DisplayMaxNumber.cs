using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class DisplayMaxNumber
    {
        public int MaxNumber(int num1, int num2)
        {
            int maxNumber;
            if (num1 > num2)
            {
                maxNumber = num1;
            }
            else
            {
                maxNumber = num2;
            }
            return maxNumber;
        }

        public float MaxNumber(float num1, float num2)
        {
            float maxNumber;
            if (num1 > num2)
            {
                maxNumber = num1;
            }
            else
            {
                maxNumber = num2;
            }
            return maxNumber;
        }

        public double MaxNumber(double num1, double num2)
        {
            double maxNumber;
            if (num1 > num2)
            {
                maxNumber = num1;
            }
            else
            {
                maxNumber = num2;
            }
            return maxNumber;
        }
    }
}
