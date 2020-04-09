using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Globalization;
using System.IO;


namespace OpenStreetMapsParser
{
    class Map
    {
        Dictionary<string, RoadType> roadTypes;
        Dictionary<long, Node> Nodes = null;
        String filePath="";
        HashSet<Road> roadNames;

        bool firstNode = true;
        float minLat = (float)0;
        float minLon = (float)0;
        float maxLat = (float)0;
        float maxLon = (float)0;

        long numOfNodes = 0;
        long numOfEdges = 0;

        public Map(String filePath)
        {
            this.filePath = filePath;
        }

        public void initOpenStreetRoadTypes()
        { 
            this.roadTypes = new Dictionary<string, RoadType>();
            roadTypes.Add("motorway", new RoadType("motorway"));
            roadTypes.Add("motorway_link", new RoadType("motorway_link"));
            roadTypes.Add("trunk", new RoadType("trunk"));
            roadTypes.Add("trunk_link", new RoadType("trunk_link"));
            roadTypes.Add("primary", new RoadType("primary"));
            roadTypes.Add("primary_link", new RoadType("primary_link"));
            roadTypes.Add("secondary", new RoadType("secondary"));
            roadTypes.Add("secondary_link", new RoadType("secondary_link"));
            roadTypes.Add("tertiary", new RoadType("tertiary"));
            roadTypes.Add("residential", new RoadType("residential"));
            roadTypes.Add("unclassified", new RoadType("unclassified"));
            roadTypes.Add("road", new RoadType("road"));
            roadTypes.Add("living_street", new RoadType("living_street"));
            roadTypes.Add("service", new RoadType("service"));
            roadTypes.Add("track", new RoadType("track"));
            roadTypes.Add("path", new RoadType("path"));
            roadTypes.Add("motorway_junction", new RoadType("motorway_junction"));
        }

        

        /// <summary>
        /// analyse single road in the opendrive
        /// </summary>
        /// <param name="minLat"></param>
        /// <param name="minLon"></param>
        /// <param name="maxLat"></param>
        /// <param name="maxLon"></param>
        public void analyseOpenStreetMap(OpenDrive.Road road)
        {
            firstNode = true;
            numOfNodes = 0;
            numOfEdges = 0;
            XmlTextReader textReader = new XmlTextReader(filePath);
            initOpenStreetRoadTypes();
            String stateLvl1 = "";

            long actualRoad = -1;
            string actualRoadName = "";
            RoadType actualRoadType = null;
            long lastNode = -1;
            long tempEdges = 0;
            bool isRoad = false;

            LinkedList<long> tempRoadNodes = new LinkedList<long>();

           Dictionary<long, Node> tempNodes = new Dictionary<long, Node>();

            while (textReader.Read())
            {
                switch (textReader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (textReader.Name)
                        {
                            case "node":
                                long id = long.Parse(textReader.GetAttribute("id"));
                                float lat = float.Parse(textReader.GetAttribute("lat"), CultureInfo.InvariantCulture);
                                float lon = float.Parse(textReader.GetAttribute("lon"), CultureInfo.InvariantCulture);
                                if (lat >= minLat && lat <= maxLat && lon >= minLon && lon <= maxLon)
                                {                                    
                                    tempNodes.Add(id, new Node(id, lat, lon));

                                    if (!firstNode)
                                    {
                                        if (lat < this.minLat)
                                        {
                                            this.minLat = lat;
                                        }
                                        if (lat > this.maxLat)
                                        {
                                            this.maxLat = lat;
                                        }
                                        if (lon < this.minLon)
                                        {
                                            this.minLon = lon;
                                        }
                                        if (lon > this.maxLon)
                                        {
                                            this.maxLon = lon;
                                        }
                                    }
                                    else
                                    {
                                        this.minLat = this.maxLat = lat;
                                        this.minLon = this.maxLon = lon;
                                        firstNode = false;
                                    }
                                }
                                break;

                            case "way":
                                stateLvl1 = "way";
                                actualRoad = long.Parse(textReader.GetAttribute("id"));
                                break;

                            case "nd":
                                if (stateLvl1 == "way")
                                {
                                    long refe = long.Parse(textReader.GetAttribute("ref"));
                                    if (lastNode == -1)
                                    {
                                        if (tempNodes.ContainsKey(refe)) // True
                                        {
                                            tempRoadNodes.AddLast(refe);
                                            tempEdges = 0;
                                            lastNode = refe;
                                        }
                                    }
                                    else
                                    {
                                        if (tempNodes.ContainsKey(refe)) // True
                                        {
                                            tempRoadNodes.AddLast(refe);
                                            tempEdges=tempEdges + 1;
                                            lastNode = refe;
                                        }                                        
                                    }
                                }
                                break;
                            case "tag":
                                if (stateLvl1 == "way")
                                {
                                    if (textReader.GetAttribute("k") == "highway")
                                    {
                                        isRoad = true;
                                        string roadType = textReader.GetAttribute("v");
                                        if (roadTypes.ContainsKey(roadType))
                                        {
                                            if (actualRoad != -1)
                                                actualRoadType = roadTypes[roadType];
                                        }
                                    }
                                    else if (textReader.GetAttribute("k") == "name")
                                    {
                                        if (actualRoad != -1)
                                            actualRoadName = textReader.GetAttribute("v");
                                    }
                                }
                                break;

                        }
                        break;
                    case XmlNodeType.EndElement: //Apresente o fim do elemento.
                        if (textReader.Name == "way")
                        {
                            if (isRoad == true && actualRoad != -1 && actualRoadType != null)
                            {
                                this.numOfEdges += tempEdges;
                                foreach (long nodeCode in tempRoadNodes)
                                {
                                    tempNodes[nodeCode].setIsRoadNodeTrue();
                                }
                            }
                            tempEdges = 0;
                            isRoad = false;
                            stateLvl1 = "";
                            actualRoad = -1;
                            lastNode = -1;
                            actualRoadName = "";
                            actualRoadType = null;
                            tempRoadNodes = new LinkedList<long>();
                        }
                        break;
                }

            }
            Nodes = new Dictionary<long, Node>();
            foreach (KeyValuePair<long, Node> e in tempNodes)
            {
                Node x = e.Value;
                if (x.getIsRoadNode())
                {
                    this.numOfNodes++;
                    Nodes.Add(e.Key,x);
                }
            }

        }

        public void saveOpenStreetMapCropped(float minLat, float minLon, float maxLat, float maxLon, string fileNameNodes, string fileNameRoads, string fileNameSubRoads)
        {
            StreamWriter file = new StreamWriter(fileNameNodes);
            foreach (KeyValuePair<long, Node> e in Nodes)
            {
                Node x = e.Value;
                float lat = x.getLat();
                float lon = x.getLon();
                PointF xy = PlateCareePaintMapModel.GPSCoordinatesToProjection(new PointF(lon, lat));
                if (x.getIsRoadNode())
                {
                    file.WriteLine(x.getId().ToString()+";"+lat.ToString(CultureInfo.InvariantCulture)+";"+lon.ToString(CultureInfo.InvariantCulture)+";"+xy.X.ToString(CultureInfo.InvariantCulture)+";"+xy.Y.ToString(CultureInfo.InvariantCulture));
                }
            }
            file.Close();
            file = new StreamWriter(fileNameSubRoads);

            HashSet<KeyValuePair<long, long>> tempSubRoads = new HashSet<KeyValuePair<long, long>>();
            HashSet<Road> roadNames = new HashSet<Road>();
            
            firstNode = true;
            XmlTextReader textReader = new XmlTextReader(filePath);
            initOpenStreetRoadTypes();
            String stateLvl1 = "";

            long actualRoad = -1;
            string actualRoadName = "";
            bool actualRoadTwoWay = false;
            RoadType actualRoadType = null;
            long lastNode = -1;
            bool isRoad = false;

            while (textReader.Read())
            {
                switch (textReader.NodeType)
                {
                    case XmlNodeType.Element: // O nó é um elemento.
                        switch (textReader.Name)
                        {
                            case "way":
                                stateLvl1 = "way";
                                actualRoad = long.Parse(textReader.GetAttribute("id"));
                                break;

                            case "nd":
                                if (stateLvl1 == "way")
                                {
                                    long refe = long.Parse(textReader.GetAttribute("ref"));
                                    if (lastNode == -1)
                                    {
                                        if (Nodes.ContainsKey(refe)) // True
                                        {
                                            lastNode = refe;
                                        }
                                    }
                                    else
                                    {
                                        if (Nodes.ContainsKey(refe)) // True
                                        {
                                            tempSubRoads.Add(new KeyValuePair<long, long>(lastNode, refe));
                                            lastNode = refe;
                                        }
                                    }
                                }
                                break;
                            case "tag":
                                if (stateLvl1 == "way")
                                {
                                    if (textReader.GetAttribute("k") == "highway")
                                    {
                                        isRoad = true;
                                        string roadType = textReader.GetAttribute("v");
                                        if (roadTypes.ContainsKey(roadType))
                                        {
                                            if (actualRoad != -1)
                                                actualRoadType = roadTypes[roadType];
                                        }
                                    }
                                    else if (textReader.GetAttribute("k") == "name")
                                    {
                                        if (actualRoad != -1)
                                            actualRoadName = textReader.GetAttribute("v");
                                    }
                                    else if (textReader.GetAttribute("k") == "oneway")
                                    {
                                        if (actualRoad != -1)
                                            actualRoadTwoWay = textReader.GetAttribute("v") != "yes";
                                    }



                                }
                                break;

                        }
                        break;
                    case XmlNodeType.EndElement: //Apresente o fim do elemento.
                        if (textReader.Name == "way")
                        {
                            if (isRoad == true && actualRoad != -1 && actualRoadType != null && tempSubRoads.Count>0)
                            {
                                foreach (KeyValuePair<long, long> e in tempSubRoads)
                                {
                                    file.WriteLine(actualRoad+";"+e.Key.ToString()+";"+e.Value.ToString()+";");
                                }
                                roadNames.Add(new Road(actualRoad, actualRoadName, actualRoadTwoWay));
                                
                            }
                            isRoad = false;
                            stateLvl1 = "";
                            actualRoad = -1;
                            lastNode = -1;
                            actualRoadName = "";
                            actualRoadType = null;
                            tempSubRoads.Clear();

                        }
                        break;
                }

            }
            file.Close();
            file = new StreamWriter(fileNameRoads);
            //file.WriteLine("##ROADS##");
            foreach (Road e in roadNames)
            {
                file.WriteLine(e.getId().ToString() + ";" + e.getName() + ";" + e.isTwoWay());
            }
            file.Close();
        }

        /// <summary>
        /// analysis OSM from Opendrive
        /// </summary>
        /// <param name="minLat"></param>
        /// <param name="minLon"></param>
        /// <param name="maxLat"></param>
        /// <param name="maxLon"></param>
        /// <param name="fileNameNodes"></param>
        /// <param name="fileNameRoads"></param>
        /// <param name="fileNameSubRoads"></param>
        public void OSM2MAP(OpenDrive.Opendrive opendrive)
        {
            foreach (OpenDrive.Road rd in opendrive.roads)
            {
                try
                {
                    analyseOpenStreetMap(rd);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        /// <summary>
        /// atach the OSM map into Map
        /// </summary>
        /// <param name="minLat"></param>
        /// <param name="minLon"></param>
        /// <param name="maxLat"></param>
        /// <param name="maxLon"></param>
        /// <param name="fileNameNodes"></param>
        /// <param name="fileNameRoads"></param>
        /// <param name="fileNameSubRoads"></param>
        public void OSM2Map(float minLat, float minLon, float maxLat, float maxLon, string fileNameNodes, string fileNameRoads, string fileNameSubRoads)
        {
            
        }

        /// <summary>
        /// atach the OSM map into vissim
        /// </summary>
        /// <param name="minLat"></param>
        /// <param name="minLon"></param>
        /// <param name="maxLat"></param>
        /// <param name="maxLon"></param>
        /// <param name="fileNameNodes"></param>
        /// <param name="fileNameRoads"></param>
        /// <param name="fileNameSubRoads"></param>
        public void OSM2sim(float minLat, float minLon, float maxLat, float maxLon, string fileNameNodes, string fileNameRoads, string fileNameSubRoads)
        {
            foreach(RoadType rt in roadTypes)
            {
                try
                {
                    object[] array = { 3.5 };
                    ILink link = lc.addLink(42, "LINESTRING(1 1,2 2)", array);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public long getNumOfNodes()
        {
            return numOfNodes;
        }

        public long getNumOfEdges()
        {
            return numOfEdges;
        }

        public float getMinLat()
        {
            return minLat;
        }
        public float getMaxLat()
        {
            return maxLat;
        }
        public float getMinLon()
        {
            return minLon;
        }
        public float getMaxLon()
        {
            return maxLon;
        }

        public long getCroppedNumOfNodes()
        {
            return numOfNodes;
        }

        public long getCroppedNumOfEdges()
        {
            return numOfEdges;
        }

        public float getCroppedMinLat()
        {
            return minLat;
        }
        public float getCroppedMaxLat()
        {
            return maxLat;
        }
        public float getCroppedMinLon()
        {
            return minLon;
        }
        public float getCroppedMaxLon()
        {
            return maxLon;
        }
    }
}
