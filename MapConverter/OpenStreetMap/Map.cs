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
        Dictionary<long, Node> croppedNodes = null;
        String filePath="";
        

        bool firstNode = true;
        float minLat = (float)0;
        float minLon = (float)0;
        float maxLat = (float)0;
        float maxLon = (float)0;

        long numOfNodes = 0;
        long numOfEdges = 0;

        //Cropped

        float croppedMinLat = (float)0;
        float croppedMinLon = (float)0;
        float croppedMaxLat = (float)0;
        float croppedMaxLon = (float)0;

        long croppedNumOfNodes = 0;
        long croppedNumOfEdges = 0;
        public Map(String filePath)
        {
            this.filePath = filePath;
        }

        public void initOpenStreetRoadTypes()
        { 
            //falta converter as rotundas
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

            //roadTypes.Add("mini_roundabout", new RoadType("mini_roundabout", true));

            //roadTypes.Add("roundabout", new RoadType("roundabout"));  
            roadTypes.Add("motorway_junction", new RoadType("motorway_junction"));
            //roadTypes.Add("Other Values", new RoadType("Other Values", true));
        }

        public void analyseOpenStreetMap(bool useRealNodes)
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

            //para guardar os nós com o objectivo de mostrar o numero correcto de nós visto que alguns nao são nós de estradas mas sim de pontos de interesse
            Dictionary<long, Node> tempNodes = null;
            if (useRealNodes)
                tempNodes = new Dictionary<long, Node>();

            while (textReader.Read())
            {
                switch (textReader.NodeType)
                {
                    case XmlNodeType.Element: // O nó é um elemento.
                        switch (textReader.Name)
                        {
                            case "node":
                                long id = long.Parse(textReader.GetAttribute("id"));
                                if (useRealNodes)
                                    tempNodes.Add(id, new Node(id));
                                else
                                    this.numOfNodes++;
                                
                                if (!firstNode)
                                {
                                    float lat = float.Parse(textReader.GetAttribute("lat"), CultureInfo.InvariantCulture);
                                    float lon = float.Parse(textReader.GetAttribute("lon"), CultureInfo.InvariantCulture);
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
                                    this.minLat = this.maxLat = float.Parse(textReader.GetAttribute("lat"), CultureInfo.InvariantCulture);
                                    this.minLon = this.maxLon = float.Parse(textReader.GetAttribute("lon"), CultureInfo.InvariantCulture);
                                    firstNode = false;
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
                                        if (useRealNodes && tempNodes.ContainsKey(refe)) // True
                                        {
                                            tempNodes[refe].setIsRoadNodeTrue();
                                        }
                                        tempEdges = 0;
                                        lastNode = refe;
                                    }
                                    else
                                    {
                                        if (useRealNodes && tempNodes.ContainsKey(refe)) // True
                                        {
                                            tempNodes[refe].setIsRoadNodeTrue();
                                        }
                                        tempEdges++;
                                        lastNode = refe;
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
                                        else
                                        {
                                            Console.WriteLine("Uknown RoadType");
                                        }
                                    }
                                    else if (textReader.GetAttribute("k") == "name")
                                    {
                                        if (actualRoad != -1)
                                            actualRoadName=textReader.GetAttribute("v");
                                    }
                                }
                                break;

                        }
                        break;
                    case XmlNodeType.Text: //Apresente o texto em cada elemento.
                        //form.writeStringLine(textReader.Value);
                        break;
                    case XmlNodeType.EndElement: //Apresente o fim do elemento.
                        if (textReader.Name == "way")
                        {
                            if (isRoad == true && actualRoad != -1 && actualRoadType != null)
                            {
                                this.numOfEdges += tempEdges;

                            }
                            isRoad = false;
                            stateLvl1 = "";
                            actualRoad = -1;
                            lastNode = -1;
                            actualRoadName = "";
                            actualRoadType = null;
                        }
                        break;
                }
                
            }
            if (useRealNodes)
                foreach (KeyValuePair<long, Node> e in tempNodes)
                {
                    Node x = e.Value;
                    if (x.getIsRoadNode())
                        this.numOfNodes++;
                }

        }


        public void analyseOpenStreetMapCropped(float minLat, float minLon, float maxLat, float maxLon)
        {
            firstNode = true;
            croppedNumOfNodes = 0;
            croppedNumOfEdges = 0;
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

            //para guardar os nós com o objectivo de mostrar o numero correcto de nós visto que alguns nao são nós de estradas mas sim de pontos de interesse
            Dictionary<long, Node> tempNodes = new Dictionary<long, Node>();

            while (textReader.Read())
            {
                switch (textReader.NodeType)
                {
                    case XmlNodeType.Element: // O nó é um elemento.
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
                                        if (lat < this.croppedMinLat)
                                        {
                                            this.croppedMinLat = lat;
                                        }
                                        if (lat > this.croppedMaxLat)
                                        {
                                            this.croppedMaxLat = lat;
                                        }
                                        if (lon < this.croppedMinLon)
                                        {
                                            this.croppedMinLon = lon;
                                        }
                                        if (lon > this.croppedMaxLon)
                                        {
                                            this.croppedMaxLon = lon;
                                        }
                                    }
                                    else
                                    {
                                        this.croppedMinLat = this.croppedMaxLat = lat;
                                        this.croppedMinLon = this.croppedMaxLon = lon;
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
                                this.croppedNumOfEdges += tempEdges;
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
            croppedNodes = new Dictionary<long, Node>();
            foreach (KeyValuePair<long, Node> e in tempNodes)
            {
                Node x = e.Value;
                if (x.getIsRoadNode())
                {
                    this.croppedNumOfNodes++;
                    croppedNodes.Add(e.Key,x);
                }
            }

        }

        public void saveOpenStreetMapCropped(float minLat, float minLon, float maxLat, float maxLon, string fileNameNodes, string fileNameRoads, string fileNameSubRoads)
        {
            StreamWriter file = new StreamWriter(fileNameNodes);
            //file.WriteLine("##NODES##");
            foreach (KeyValuePair<long, Node> e in croppedNodes)
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
            //file.WriteLine("##SUBROADS##");

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
                                        if (croppedNodes.ContainsKey(refe)) // True
                                        {
                                            lastNode = refe;
                                        }
                                    }
                                    else
                                    {
                                        if (croppedNodes.ContainsKey(refe)) // True
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
            return croppedNumOfNodes;
        }

        public long getCroppedNumOfEdges()
        {
            return croppedNumOfEdges;
        }

        public float getCroppedMinLat()
        {
            return croppedMinLat;
        }
        public float getCroppedMaxLat()
        {
            return croppedMaxLat;
        }
        public float getCroppedMinLon()
        {
            return croppedMinLon;
        }
        public float getCroppedMaxLon()
        {
            return croppedMaxLon;
        }
    }
}
