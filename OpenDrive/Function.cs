using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OpenDrive
{
    static class Function
    {
        static public XmlNodeList GetNodeChilds(XmlNode node, string name)
        {
            string text = "<" + node.Name + "> " + node.InnerXml + "</" + node.Name + ">";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            XmlNodeList nl = doc.DocumentElement.SelectNodes("//" + name + "");
            return nl;
        }
    }
}
