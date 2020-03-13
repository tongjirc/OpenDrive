using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OpenDrive
{
    /// <summary>
    /// In some cases (e.g. roundabout) it might be good to group junctions so that the traffic simulation software can execute calculations more efficiently.
    /// </summary>
    class JunctionGroup
    {
        public string name;
        public string id;
        public string type;
        public List<JunctionReference> jctref = new List<JunctionReference>();
        public JunctionGroup(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.type = node.Attributes.GetNamedItem("type").Value;

            foreach (XmlNode nrctref in node.SelectNodes("junctionReference"))
            {
                JunctionReference rctref = new JunctionReference(nrctref);
                jctref.Add(rctref);
            }
        }
    }


    /// <summary>
    /// Junction group members are nothing but references to existing junction records.
    /// </summary>
    class JunctionReference
    {
        public string junction;
        public JunctionReference(XmlNode node)
        {
            this.junction = node.Attributes.GetNamedItem("junction").Value;
        }
    }

}
