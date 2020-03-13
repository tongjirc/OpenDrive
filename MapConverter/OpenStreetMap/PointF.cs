using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMapsParser
{
    class PointF
    {
        public float X;
        public float Y;

        public PointF()
        {
            this.X = (float)0;
            this.Y = (float)0;
        }

        public PointF(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
