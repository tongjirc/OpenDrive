using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OpenDrive
{
    /// <summary>
    /// For tram and railroad applications, the definition of stations must be feasible. Stations may refer to multiple tracks and are, therefore, defined on the same level as junctions. 
    /// The physical extent of a station is defined by the combined physical extent of all platforms within the station. 
    /// For pure automotive environments, also bus stations may be defined using the same elements.
    /// </summary>
    class Station
    {
        public string name;
        public string id;
        public string type;
        public List<Platform> paltforms = new List<Platform>();
        public Station(XmlNode node)
        {
            this.name = node.Attributes.GetNamedItem("name").Value;
            this.id = node.Attributes.GetNamedItem("id").Value;
            if (node.Attributes.GetNamedItem("type") != null) this.type = node.Attributes.GetNamedItem("type").Value;

            foreach (XmlNode nptf in node.SelectNodes("platform"))
            {
                Platform ptf = new Platform(nptf);
                paltforms.Add(ptf);
            }
        }
    }


    /// <summary>
    /// Each station entry must contain at least one platform entry. Each platform entry must contain at least one reference to a valid track segment.
    /// </summary>
    class Platform
    {
        public string name;
        public string id;
        public List<Segment> segments = new List<Segment>();
        public Platform(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            this.id = node.Attributes.GetNamedItem("id").Value;

            foreach (XmlNode nsg in node.SelectNodes("segment"))
            {
                Segment sg = new Segment(nsg);
                segments.Add(sg);
            }
        }
    }

    /// <summary>
    /// Each platform entry is valid on one or more track segments. These have to be specified using the following record.
    /// </summary>
    class Segment
    {
        public string roadId;
        public string side;
        public double sStart;
        public double sEnd;
        public Segment(XmlNode node)
        {
            this.roadId = node.Attributes.GetNamedItem("roadId").Value;
            this.side = node.Attributes.GetNamedItem("side").Value;
            this.sStart = Convert.ToDouble(node.Attributes.GetNamedItem("sStart").Value);
            this.sEnd = Convert.ToDouble(node.Attributes.GetNamedItem("sEnd").Value);
        }
    }
}
