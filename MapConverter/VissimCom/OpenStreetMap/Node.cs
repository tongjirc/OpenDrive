using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenStreetMapsParser
{
    class Node
    {
        long id;
        bool isRoadNode = false;
        float lat;
        float lon;


        public Node(long id)
        {
            this.id = id;
        }

        public Node(long id, float lat, float lon)
        {
            this.id = id;
            this.lat = lat;
            this.lon = lon;
        }

        public void setIsRoadNodeTrue()
        {
            this.isRoadNode = true;
        }

        public bool getIsRoadNode()
        {
            return isRoadNode;
        }
 
        public long getId()
        {
            return id;
        }

        public float getLat()
        {
            return lat;
        }

        public float getLon()
        {
            return lon;
        }

    }
}
