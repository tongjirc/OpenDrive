using System;
using System.Collections.Generic;
using System.Text;

using System.Xml;

namespace OpenDrive
{
    class Header
    {
        public string revMajor ;
        public string revMinor ;
        public string name ;
        public string version ;
        public string date ;
        public string north ;
        public string south ;
        public string east ;
        public string west ;
        public string vendor ;
        public string geoReference;
        public Offset offset;
        public Header(XmlNode nheader)
        {
            revMajor= nheader.Attributes.GetNamedItem("revMajor").Value;
            revMinor = nheader.Attributes.GetNamedItem("revMinor").Value;
            if (nheader.Attributes.GetNamedItem("name") != null) name = nheader.Attributes.GetNamedItem("name").Value;
            if (nheader.Attributes.GetNamedItem("version") != null) version = nheader.Attributes.GetNamedItem("version").Value;
            if (nheader.Attributes.GetNamedItem("date") != null) date = nheader.Attributes.GetNamedItem("date").Value;
            if (nheader.Attributes.GetNamedItem("north") != null) north = nheader.Attributes.GetNamedItem("north").Value;
            if (nheader.Attributes.GetNamedItem("south") != null) south = nheader.Attributes.GetNamedItem("south").Value;
            if (nheader.Attributes.GetNamedItem("east") != null) east = nheader.Attributes.GetNamedItem("east").Value;
            if (nheader.Attributes.GetNamedItem("west") != null) west = nheader.Attributes.GetNamedItem("west").Value;
            if (nheader.Attributes.GetNamedItem("vendor") != null) vendor = nheader.Attributes.GetNamedItem("vendor").Value;
            if (nheader.SelectSingleNode("geoReference") != null) geoReference = nheader.SelectSingleNode("geoReference").InnerText;
            if (nheader.SelectSingleNode("offset") != null) offset = new Offset(nheader.SelectSingleNode("offset"));
        }

    }
    class Offset
    {
        public double x;
        public double y;
        public double z;
        public double hdg;
        public Offset(XmlNode node)
        {
            this.x = Convert.ToDouble(node.Attributes.GetNamedItem("x").Value);
            this.y = Convert.ToDouble(node.Attributes.GetNamedItem("y").Value);
            this.z = Convert.ToDouble(node.Attributes.GetNamedItem("z").Value);
            this.hdg = Convert.ToDouble(node.Attributes.GetNamedItem("hdg").Value);

        }
    }
}
