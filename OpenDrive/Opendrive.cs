using System;
using System.Collections.Generic;
using System.Text;

using System.Xml;

namespace OpenDrive
{
    class Opendrive
    {
        public Header header;
        public List<Road> roads = new List<Road>();
        public List<Controller> controllers = new List<Controller>();
        public List<Junction> junctions = new List<Junction>();
        public List<JunctionGroup> junctiongourps = new List<JunctionGroup>();
        public List<Station> stations = new List<Station>();


        public Opendrive(XmlElement root)
        {
            this.header = new Header(root.SelectSingleNode("/OpenDRIVE/header"));
            foreach(XmlNode nroad in root.SelectNodes("/OpenDRIVE/road"))
            {
                Road road = new Road(nroad);
                roads.Add(road);
            }
            foreach (XmlNode nctrl in root.SelectNodes("/OpenDRIVE/controller"))
            {
                Controller ctrl = new Controller(nctrl);
                controllers.Add(ctrl);
            }

            foreach (XmlNode njct in root.SelectNodes("/OpenDRIVE/junction"))
            {
                Junction jct = new Junction(njct);
                junctions.Add(jct);
            }

            foreach (XmlNode njctg in root.SelectNodes("/OpenDRIVE/junctionGroup"))
            {
                JunctionGroup jctg = new JunctionGroup(njctg);
                junctiongourps.Add(jctg);
            }
            foreach (XmlNode nst in root.SelectNodes("/OpenDRIVE/station"))
            {
                Station st = new Station(nst);
                stations.Add(st);
            }
        }

    }
}
