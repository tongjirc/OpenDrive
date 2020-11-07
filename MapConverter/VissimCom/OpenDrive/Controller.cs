using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OpenDrive
{
    /// <summary>
    /// A controller provides consistent states for a group of signals. This may be a set of signals within a junction or a set of dynamic speed restrictions on a motorway. 
    /// The entire record consists of a header followed by a number of dependency records.
    /// </summary>
    class Controller
    {
        public string id;
        public string name;
        public UInt32 sequence;
        public List<Control> controls = new List<Control>();
        public Controller(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            if (node.Attributes.GetNamedItem("sequence") != null) this.sequence = Convert.ToUInt32(node.Attributes.GetNamedItem("sequence").Value);

            foreach (XmlNode nctrl in node.SelectNodes("control"))
            {
                Control ctrl = new Control(nctrl);
                controls.Add(ctrl);
            }
        }
    }


    /// <summary>
    /// The control entry record provides information about a single signal controlled by the corresponding controller. 
    /// This record is a child record of the controller record.
    /// </summary>
    class Control
    {
        public string signalId;
        public string type;
        public Control(XmlNode node)
        {
            this.signalId = node.Attributes.GetNamedItem("signalId").Value;
            if (node.Attributes.GetNamedItem("type") != null)  this.type = node.Attributes.GetNamedItem("type").Value;
        }
    }

}
