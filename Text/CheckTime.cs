using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class CheckTime
    {
        public bool CheckTimeEntry(string time)
        {
            bool validTime;

            try
            {
                var inputTime = TimeSpan.Parse(time);
                validTime = true;
            }
            catch
            {
                validTime = false;
            }

            return validTime;
        }
    }
}
