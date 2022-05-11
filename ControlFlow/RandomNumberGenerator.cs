using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class RandomNumberGenerator
    {
        public int GenerateNumber()
        {
            var random = new Random();
            return random.Next(1, 11);
        }
    }
}
