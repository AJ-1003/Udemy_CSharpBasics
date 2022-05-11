using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class DetermineImageOrientation
    {
        public string Orientation(int width, int height)
        {
            string orientation;
            if (width > height)
            {
                orientation = "Landscape";
            }
            else
            {
                orientation = "Portrait";
            }
            return orientation;
        }

        public string Orientation(float width, float height)
        {
            string orientation;
            if (width > height)
            {
                orientation = "Landscape";
            }
            else
            {
                orientation = "Portrait";
            }
            return orientation;
        }

        public string Orientation(double width, double height)
        {
            string orientation;
            if (width > height)
            {
                orientation = "Landscape";
            }
            else
            {
                orientation = "Portrait";
            }
            return orientation;
        }
    }
}
