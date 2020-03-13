using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OpenDrive
{
    /// <summary>
    /// When a road can be linked to more than one successor (or predecessor, depending on the orientation), a junction record is required. 
    /// It contains the information about all possible connections between roads meeting at a physical junction.
    /// </summary>
    class Junction
    {
        public string id;
        public string name;
        public string type;
        public List<Connection> conts = new List<Connection>();
        public List<Priority> priorities = new List<Priority>();
        public List<Controller> controllers = new List<Controller>();
        public List<Surface> surfaces = new List<Surface>();
        public Junction(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            if (node.Attributes.GetNamedItem("type") != null) this.type = node.Attributes.GetNamedItem("type").Value;

            foreach (XmlNode ncnt in node.SelectNodes("connection"))
            {
                Connection cnt = new Connection(ncnt);
                conts.Add(cnt);
            }
            foreach (XmlNode npri in node.SelectNodes("laneLink"))
            {
                Priority pri = new Priority(npri);
                priorities.Add(pri);
            }
            foreach (XmlNode nctrl in node.SelectNodes("controller"))
            {
                Controller ctrl = new Controller(nctrl);
                controllers.Add(ctrl);
            }
            foreach (XmlNode nsf in node.SelectNodes("surface"))
            {
                Surface sf = new Surface(nsf);
                surfaces.Add(sf);
            }
        }
    }


    /// <summary>
    /// The connection record provides information about a single connection within a junction. 
    /// It is a child of the junction header record.
    /// </summary>
    class Connection
    {
        public string id;
        public string incomingRoad;
        public string connectingRoad;
        public string contactPoint;
        public string connectionMaster;
        public string type;
        public List<JunctionPredecessor> predecessors = new List<JunctionPredecessor>();
        public List<JunctionSuccessor> successors = new List<JunctionSuccessor>();
        public List<JunctionLaneLink> lanelinks = new List<JunctionLaneLink>();

        public Connection(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.incomingRoad = node.Attributes.GetNamedItem("incomingRoad").Value;
            this.connectingRoad = node.Attributes.GetNamedItem("connectingRoad").Value;
            this.contactPoint = node.Attributes.GetNamedItem("contactPoint").Value;
            if (node.Attributes.GetNamedItem("connectionMaster") != null)  this.connectionMaster = node.Attributes.GetNamedItem("connectionMaster").Value;
            if (node.Attributes.GetNamedItem("type") != null) this.type = node.Attributes.GetNamedItem("type").Value;

            foreach (XmlNode npre in node.SelectNodes("predecessor"))
            {
                JunctionPredecessor pre = new JunctionPredecessor(npre);
                predecessors.Add(pre);
            }

            foreach (XmlNode nsec in node.SelectNodes("successor"))
            {
                JunctionSuccessor sec = new JunctionSuccessor(nsec);
                successors.Add(sec);
            }

            foreach (XmlNode nllk in node.SelectNodes("laneLink"))
            {
                JunctionLaneLink llk = new JunctionLaneLink(nllk);
                lanelinks.Add(llk);
            }
        }
    }

    /// <summary>
    /// This record provides detailed information about the predecessor road of a virtual connection. The predecessor may be of type "road" only.
    /// </summary>
    class JunctionPredecessor
    {
        public string elementType;
        public string elementId;
        public double elementS;
        public string elementDir;

        public JunctionPredecessor(XmlNode node)
        {
            this.elementType = node.Attributes.GetNamedItem("elementType").Value;
            this.elementId = node.Attributes.GetNamedItem("elementId").Value;
            this.elementS = Convert.ToDouble(node.Attributes.GetNamedItem("elementS").Value);
            this.elementDir = node.Attributes.GetNamedItem("elementDir").Value;

        }
    }

    /// <summary>
    /// This record provides detailed information about the successor road of a virtual connection. The successor may be of type road only.
    /// </summary>
    class JunctionSuccessor
    {
        public string elementType;
        public string elementId;
        public double elementS;
        public string elementDir;

        public JunctionSuccessor(XmlNode node)
        {
            this.elementType = node.Attributes.GetNamedItem("elementType").Value;
            this.elementId = node.Attributes.GetNamedItem("elementId").Value;
            this.elementS = Convert.ToDouble(node.Attributes.GetNamedItem("elementS").Value);
            this.elementDir = node.Attributes.GetNamedItem("elementDir").Value;

        }
    }

    /// <summary>
    /// The junction lane link record provides information about the lanes which are linked between incoming road and connecting road. 
    /// This record may be omitted if all incoming lanes are linked to lanes with identical IDs on the connecting road. However, it is strongly recommended to provide this record.
    /// </summary>
    class JunctionLaneLink
    {
        public int from;
        public int to;

        public JunctionLaneLink(XmlNode node)
        {
            this.from = Convert.ToInt32(node.Attributes.GetNamedItem("from").Value);
            this.to = Convert.ToInt32(node.Attributes.GetNamedItem("to").Value);

        }
    }

    /// <summary>
    /// The junction priority record provides information about the priority of a connecting road over another connecting road. 
    /// It is only required if priorities cannot be derived from signs or signals in a junction or on tracks leading to a junction.
    /// </summary>
    class Priority
    {
        public string high;
        public string low;

        public Priority(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("high") != null) this.high = node.Attributes.GetNamedItem("high").Value;
            if (node.Attributes.GetNamedItem("low") != null) this.low = node.Attributes.GetNamedItem("low").Value;
        }
    }

    class Surface
    {
        public List<CRG> CRGs = new List<CRG>();
        public Surface(XmlNode node)
        {
            foreach (XmlNode ncrg in node.SelectNodes("CRG"))
            {
                CRG crg = new CRG(ncrg);
                CRGs.Add(crg);
            }

        }
    }


    /// <summary>
    /// The interface to a Curved Regular Grid (CRG) surface description file is defined as arguments to the <CRG> tag and as an include operation between the opening and closing <CRG> tags.
    /// </summary>
    class CRG
    {
        public string file;
        public string orientation;
        public string mode;
        public string purpose;
        public double sStart;
        public double sEnd;
        public double sOffset;
        public double tOffset;
        public double zOffset;
        public double zScale;
        public double hOffset;
        public CRG(XmlNode node)
        {
            this.file = node.Attributes.GetNamedItem("file").Value;
            this.orientation = node.Attributes.GetNamedItem("orientation").Value;
            this.mode = node.Attributes.GetNamedItem("mode").Value;
            if (node.Attributes.GetNamedItem("purpose") != null) this.purpose = node.Attributes.GetNamedItem("purpose").Value;
            this.sStart = Convert.ToDouble(node.Attributes.GetNamedItem("sStart").Value);
            this.sEnd = Convert.ToDouble(node.Attributes.GetNamedItem("sEnd").Value);
            if (node.Attributes.GetNamedItem("sOffset") != null) this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            if (node.Attributes.GetNamedItem("tOffset") != null) this.tOffset = Convert.ToDouble(node.Attributes.GetNamedItem("tOffset").Value);
            if (node.Attributes.GetNamedItem("zOffset") != null) this.zOffset = Convert.ToDouble(node.Attributes.GetNamedItem("zOffset").Value);
            if (node.Attributes.GetNamedItem("zScale") != null) this.zScale = Convert.ToDouble(node.Attributes.GetNamedItem("zScale").Value);
            if (node.Attributes.GetNamedItem("hOffset") != null) this.hOffset = Convert.ToDouble(node.Attributes.GetNamedItem("hOffset").Value);
        }
    }
}
