using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMapsParser
{
    class Point
    {
        public long X;
        public long Y;


        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point(long X, long Y)
        {
            this.X = X;
            this.Y = Y;
        }


    }
}
