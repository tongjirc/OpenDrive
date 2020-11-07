using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace OpenDrive
{
    class Road
    {
        public int id;
        public string name;
        public int junction;
        public double length;
        public string rule;
        public List<TypeElement> types = new List<TypeElement>(); //Road type record
        public RoadLink link;
        public PlanView planView;
        public ElevationProfile elevationProfile;
        public LateralProfile lateralProfile ;
        public List<Neighbor> neighbors = new List<Neighbor>();
        public Lanes lanes;
        public ObjectElements objects ;
        public Signals signals;

        public Surface surface;
        public Railroad railroad;

        public Road(XmlNode nroad)
        {
            this.id = Convert.ToInt32(nroad.Attributes.GetNamedItem("id").Value);
            if (nroad.Attributes.GetNamedItem("name") != null) this.name = nroad.Attributes.GetNamedItem("name").Value;
            if (nroad.Attributes.GetNamedItem("rule") != null) this.rule = nroad.Attributes.GetNamedItem("rule").Value;
            this.junction= Convert.ToInt32(nroad.Attributes.GetNamedItem("junction").Value);
            this.length = Convert.ToDouble(nroad.Attributes.GetNamedItem("length").Value);

            //this.types
            foreach(XmlNode node in nroad.SelectNodes("type"))
            {
                TypeElement typefoo = new TypeElement(node);
                types.Add(typefoo);
            }
            //this.link
            if (nroad.SelectSingleNode("link") != null) this.link=new RoadLink(nroad.SelectSingleNode("link"));
            //this.planView
            this.planView = new PlanView(nroad.SelectSingleNode("planView"));
            //this.elevationProfile
            if (nroad.SelectSingleNode("elevationProfile") != null) this.elevationProfile = new ElevationProfile(nroad.SelectSingleNode("elevationProfile"));
            //this.lateralProfile
            if (nroad.SelectSingleNode("lateralProfile") != null) this.lateralProfile = new LateralProfile(nroad.SelectSingleNode("lateralProfile"));
            //this.lanes
            this.lanes = new Lanes(nroad.SelectSingleNode("lanes"));
            //this.neighbors

            //this.objects
            this.objects = new ObjectElements(nroad.SelectSingleNode("objects"));
            //this.signals
            if (nroad.SelectSingleNode("signals") != null) this.signals = new Signals(nroad.SelectSingleNode("signals"));
            //this.surface
            if (nroad.SelectSingleNode("surface") != null) this.surface = new Surface(nroad.SelectSingleNode("surface"));
            //this.railroad
            if (nroad.SelectSingleNode("railroad") != null) this.railroad = new Railroad(nroad.SelectSingleNode("railroad"));

        }
    }

    class ObjectElements
    {
        public List<ObjectElement> objs = new List<ObjectElement>();
        public List<ObjectReference> objreferences = new List<ObjectReference>();
        public List<Tunnel> tunnels = new List<Tunnel>();
        public List<Bridge> brideges = new List<Bridge>();
        public ObjectElements(XmlNode node)
        {
            foreach (XmlNode nobj in node.SelectNodes("object"))
            {
                ObjectElement obj = new ObjectElement(nobj);
                objs.Add(obj);
            }
            foreach (XmlNode nobjr in node.SelectNodes("objectReference"))
            {
                ObjectReference objr = new ObjectReference(nobjr);
                objreferences.Add(objr);
            }
            foreach (XmlNode nt in node.SelectNodes("tunnel"))
            {
                Tunnel t = new Tunnel(nt);
                tunnels.Add(t);
            }
            foreach (XmlNode nb in node.SelectNodes("tunnel"))
            {
                Bridge b = new Bridge(nb);
                brideges.Add(b);
            }
        }
    }

    /// <summary>
    /// The object record has been introduced for describing common 3d objects which have a reference to a given road. 
    /// The most frequently used types of objects may become part of the OpenDRIVE specification in future releases. 
    /// A definition of currently known and frequently used object types is given in the respective chapter.
    /// </summary>
    class ObjectElement
    {
        public string type;
        public string subtype;
        public string dynamic;
        public string name;
        public string id;
        public string orientation;
        public double s;
        public double t;
        public double zOffset;
        public double validLength;
        public double hdg;
        public double pitch;
        public double roll;

        public List<Outline> outlines = new List<Outline>();
        public Repeat repeat;
        public List<ObjectMaterial> objMaterials = new List<ObjectMaterial>();
        public List<Validity> validities = new List<Validity>();
        public List<ObjectBorder> oborders = new List<ObjectBorder>();
        public List<Marking> markings = new List<Marking>();

        //additional attributes
        public double length;
        public double width;
        public double height;
        public double radius;
        public ObjectElement(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("type") != null) this.type = node.Attributes.GetNamedItem("type").Value;
            if (node.Attributes.GetNamedItem("subtype") != null) this.subtype = node.Attributes.GetNamedItem("subtype").Value;
            if (node.Attributes.GetNamedItem("dynamic") != null) this.dynamic = node.Attributes.GetNamedItem("dynamic").Value;
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            this.id = node.Attributes.GetNamedItem("s").Value;
            this.orientation = node.Attributes.GetNamedItem("orientation").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.t = Convert.ToDouble(node.Attributes.GetNamedItem("t").Value);
            if (node.Attributes.GetNamedItem("zOffset") != null) this.zOffset = Convert.ToDouble(node.Attributes.GetNamedItem("zOffset").Value);
            this.validLength = Convert.ToDouble(node.Attributes.GetNamedItem("validLength").Value);
            this.hdg = Convert.ToDouble(node.Attributes.GetNamedItem("hdg").Value);
            this.pitch = Convert.ToDouble(node.Attributes.GetNamedItem("pitch").Value);
            this.roll = Convert.ToDouble(node.Attributes.GetNamedItem("roll").Value);

            if (node.Attributes.GetNamedItem("length") != null) this.length = Convert.ToDouble(node.Attributes.GetNamedItem("length").Value);
            if (node.Attributes.GetNamedItem("width") != null) this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
            if (node.Attributes.GetNamedItem("height") != null) this.height = Convert.ToDouble(node.Attributes.GetNamedItem("height").Value);
            if (node.Attributes.GetNamedItem("radius") != null) this.radius = Convert.ToDouble(node.Attributes.GetNamedItem("radius").Value);

            foreach (XmlNode nrp in node.SelectNodes("repeat"))
            {
                Repeat repeat = new Repeat(nrp);
            }
            if (node.SelectSingleNode("outlines") != null)
            {
                foreach (XmlNode not in node.SelectSingleNode("outloines").SelectNodes("outline"))
                {
                    Outline ot = new Outline(not);
                    outlines.Add(ot);
                }
            }
            foreach (XmlNode nobjm in node.SelectNodes("material"))
            {
                ObjectMaterial objm = new ObjectMaterial(nobjm);
                objMaterials.Add(objm);
            }
            if (node.SelectSingleNode("markings") != null)
            {
                foreach (XmlNode nmk in node.SelectSingleNode("markings").SelectNodes("marking"))
                {
                    Marking mk = new Marking(nmk);
                    markings.Add(mk);
                }
            }
            foreach (XmlNode nvl in node.SelectNodes("validity"))
            {
                Validity vl = new Validity(nvl);
                validities.Add(vl);
            }
            if (node.SelectSingleNode("borders") != null)
            {
                foreach (XmlNode nobd in node.SelectSingleNode("borders").SelectNodes("border"))
                {
                    ObjectBorder obd = new ObjectBorder(nobd);
                    oborders.Add(obd);
                }
            }

        }
    }

    /// <summary>
    /// In order to avoid multiple definitions for multiple instances of the same object, repeat parameters may be defined for the original object. 
    /// Some of the parameters in the object node may be overwritten in order to specify linear transitions of e.g. the lateral offset of an object. 
    /// For attributes which are not specified in the object repeat record, the attributes of the respective object record shall prevail.
    /// </summary>
    class Repeat
    {
        public double s;
        public double length;
        public double distance;
        public double tStart;
        public double tEnd;
        public double widthStart;
        public double widthEnd;
        public double heightStart;
        public double heightEnd;
        public double zOffsetStart;
        public double zOffsetEnd;

        public double lengthStart;
        public double lengthEnd;

        public double radiusStart;
        public double radiusEnd;
        public Repeat(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("s") != null) this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            if (node.Attributes.GetNamedItem("length") != null) this.length = Convert.ToDouble(node.Attributes.GetNamedItem("length").Value);
            if (node.Attributes.GetNamedItem("distance") != null) this.distance = Convert.ToDouble(node.Attributes.GetNamedItem("distance").Value);
            if (node.Attributes.GetNamedItem("tStart") != null) this.tStart = Convert.ToDouble(node.Attributes.GetNamedItem("tStart").Value);
            if (node.Attributes.GetNamedItem("tEnd") != null) this.tEnd = Convert.ToDouble(node.Attributes.GetNamedItem("tEnd").Value);
            if (node.Attributes.GetNamedItem("widthStart") != null) this.widthStart = Convert.ToDouble(node.Attributes.GetNamedItem("widthStart").Value);
            if (node.Attributes.GetNamedItem("widthEnd") != null) this.widthEnd = Convert.ToDouble(node.Attributes.GetNamedItem("widthEnd").Value);
            if (node.Attributes.GetNamedItem("heightStart") != null) this.heightStart = Convert.ToDouble(node.Attributes.GetNamedItem("heightStart").Value);
            if (node.Attributes.GetNamedItem("heightEnd") != null) this.heightEnd = Convert.ToDouble(node.Attributes.GetNamedItem("heightEnd").Value);
            if (node.Attributes.GetNamedItem("zOffsetStart") != null) this.zOffsetStart = Convert.ToDouble(node.Attributes.GetNamedItem("zOffsetStart").Value);
            if (node.Attributes.GetNamedItem("zOffsetEnd") != null) this.zOffsetEnd = Convert.ToDouble(node.Attributes.GetNamedItem("zOffsetEnd").Value);
            if (node.Attributes.GetNamedItem("lengthStart") != null) this.lengthStart = Convert.ToDouble(node.Attributes.GetNamedItem("lengthStart").Value);
            if (node.Attributes.GetNamedItem("lengthEnd") != null) this.lengthEnd = Convert.ToDouble(node.Attributes.GetNamedItem("lengthEnd").Value);
            if (node.Attributes.GetNamedItem("radiusStart") != null) this.radiusStart = Convert.ToDouble(node.Attributes.GetNamedItem("radiusStart").Value);
            if (node.Attributes.GetNamedItem("radiusEnd") != null) this.radiusEnd = Convert.ToDouble(node.Attributes.GetNamedItem("radiusEnd").Value);
        }
    }

    /// <summary>
    /// The outline record defines a sequence of corners including height information on the object’s extent either in object co-ordinates or relative to the road’s reference line (do not use mixed definitions!). 
    /// For areas, the points should – preferably – be listed in CCW order.
    /// </summary>
    class Outline
    {
        public int id;
        public string fillType;//grass\concrete\cobble\asphalt\pavement\gravel\soil
        public bool outer;
        public bool closed;
        public string laneType;

        public List<CornerRoad> cornerroads = new List<CornerRoad>();
        public List<CornerLocal> cornerlocals = new List<CornerLocal>();

        public Outline(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("id") != null) this.id = Convert.ToInt32(node.Attributes.GetNamedItem("id").Value);
            if (node.Attributes.GetNamedItem("fillType") != null) this.fillType = node.Attributes.GetNamedItem("fillType").Value;
            if (node.Attributes.GetNamedItem("outer") != null) this.outer = Convert.ToBoolean(node.Attributes.GetNamedItem("outer").Value);
            if (node.Attributes.GetNamedItem("closed") != null) this.closed = Convert.ToBoolean(node.Attributes.GetNamedItem("closed").Value);
            if (node.Attributes.GetNamedItem("laneType") != null) this.laneType = node.Attributes.GetNamedItem("laneType").Value;

            foreach (XmlNode ncr in node.SelectNodes("cornerRoad"))
            {
                CornerRoad cr = new CornerRoad(ncr);
                cornerroads.Add(cr);
            }

            foreach (XmlNode ncl in node.SelectNodes("cornerLocal"))
            {
                CornerLocal cl = new CornerLocal(ncl);
                cornerlocals.Add(cl);
            }
        }
    }

    /// <summary>
    /// Defines a corner point on the object’s outline in road co-ordinates.
    /// </summary>
    class CornerRoad
    {
        public double s;
        public double t;
        public double dz;
        public double height;
        public int id;

        public CornerRoad(XmlNode node)
        {
            this.id = Convert.ToInt32(node.Attributes.GetNamedItem("id").Value);
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.t = Convert.ToDouble(node.Attributes.GetNamedItem("t").Value);
            this.dz = Convert.ToDouble(node.Attributes.GetNamedItem("dz").Value);
            this.height = Convert.ToDouble(node.Attributes.GetNamedItem("height").Value);
        }
    }

    /// <summary>
    /// Defines a corner point on the object’s outline relative to the object's pivot point in local u/v co-ordinates. 
    /// The pivot point and the orientation of the object are given by the s/t/heading arguments of the <object> entry.
    /// </summary>
    class CornerLocal
    {
        public double u;
        public double v;
        public double z;
        public double height;
        public int id;

        public CornerLocal(XmlNode node)
        {
            this.id = Convert.ToInt32(node.Attributes.GetNamedItem("id").Value);
            this.u = Convert.ToDouble(node.Attributes.GetNamedItem("u").Value);
            this.v = Convert.ToDouble(node.Attributes.GetNamedItem("v").Value);
            this.z = Convert.ToDouble(node.Attributes.GetNamedItem("z").Value);
            this.height = Convert.ToDouble(node.Attributes.GetNamedItem("height").Value);
        }
    }

    /// <summary>
    /// For objects like patches which are within the road surface (and, typically, coplanar to the surface) and which represent a local deviation from the standard road material, a description of the material properties is required. 
    /// This description supersedes the one provided by the Road Material record and, again, is valid only within the outline of the parent road object.
    /// </summary>
    class ObjectMaterial
    {
        public string surface;
        public double friction;
        public double roughness;
        public ObjectMaterial(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("surface") != null) this.surface = node.Attributes.GetNamedItem("surface").Value;
            if (node.Attributes.GetNamedItem("roughness") != null) this.roughness = Convert.ToDouble(node.Attributes.GetNamedItem("roughness").Value);
            if (node.Attributes.GetNamedItem("friction") != null) this.friction = Convert.ToDouble(node.Attributes.GetNamedItem("friction").Value);
        }
    }

    /// <summary>
    /// Per default, objects are valid for all lanes pointing into the object’s direction. 
    /// This default validity may be replaced with explicit validity information for an object. 
    /// The validity record is an optional child record of the object record. 
    /// Multiple validity records may be defined per object.
    /// </summary>
    class Validity
    {
        public int fromLane;
        public int toLane;

        public Validity(XmlNode node)
        {
            this.fromLane = Convert.ToInt32(node.Attributes.GetNamedItem("fromLane").Value);
            this.toLane = Convert.ToInt32(node.Attributes.GetNamedItem("toLane").Value);
        }
    }

    /// <summary>
    /// Specifies a marking that is either attached to one side of the object’s bounding box or referencing outline points.
    /// </summary>
    class Marking
    {
        public string side;
        public string weight;
        public string color;
        public double width;
        public double zOffset;
        public double spaceLength;
        public double lineLength;
        public double startOffset;
        public double stopOffset;
        public List<CornerReference> cornerReferences = new List<CornerReference>();
        public Marking(XmlNode node)
        {
            this.side = node.Attributes.GetNamedItem("side").Value;
            this.weight = node.Attributes.GetNamedItem("weight").Value;
            this.color = node.Attributes.GetNamedItem("color").Value;
            if (node.Attributes.GetNamedItem("width") != null) this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
            if (node.Attributes.GetNamedItem("zOffset") != null) this.zOffset = Convert.ToDouble(node.Attributes.GetNamedItem("zOffset").Value);
            this.spaceLength = Convert.ToDouble(node.Attributes.GetNamedItem("spaceLength").Value);
            this.lineLength = Convert.ToDouble(node.Attributes.GetNamedItem("lineLength").Value);
            this.startOffset = Convert.ToDouble(node.Attributes.GetNamedItem("startOffset").Value);
            this.stopOffset = Convert.ToDouble(node.Attributes.GetNamedItem("stopOffset").Value);

            foreach (XmlNode ncr in node.SelectNodes("cornerReference"))
            {
                CornerReference cr = new CornerReference(ncr);
                cornerReferences.Add(cr);
            }
        }
    }

    /// <summary>
    /// Specifies a corner of a marking or a border by referencing an existing outline point
    /// </summary>
    class CornerReference
    {
        public int id;
        public CornerReference(XmlNode node)
        {
            this.id = Convert.ToInt32(node.Attributes.GetNamedItem("id").Value);
        }
    }

    /// <summary>
    /// Specifies a border along certain outline points.
    /// </summary>
    class ObjectBorder
    {
        public int width;
        public int outlineId;
        public string type;
        public bool useCompleteOutline;
        public ObjectBorder(XmlNode node)
        {
            this.width = Convert.ToInt32(node.Attributes.GetNamedItem("width").Value);
            this.outlineId = Convert.ToInt32(node.Attributes.GetNamedItem("outlineId").Value);
            this.type = node.Attributes.GetNamedItem("type").Value;
            this.useCompleteOutline = Convert.ToBoolean(node.Attributes.GetNamedItem("useCompleteOutline").Value);
        }
    }

    /// <summary>
    /// Since the same object may be referred to from several roads, a corresponding record is being provided. 
    /// This requires, however, that objects which are to be referred to be provided with a unique ID.
    /// The object reference record consists of a main record and an optional lane validity record.
    /// </summary>
    class ObjectReference
    {
        public double s;
        public double t;
        public double zOffset;
        public double validLength;
        public string id;
        public string orientation;
        public ObjectReference(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.orientation = node.Attributes.GetNamedItem("orientation").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.t = Convert.ToDouble(node.Attributes.GetNamedItem("t").Value);
            this.zOffset = Convert.ToDouble(node.Attributes.GetNamedItem("zOffset").Value);
            this.validLength = Convert.ToDouble(node.Attributes.GetNamedItem("validLength").Value);
        }
    }

    /// <summary>
    /// The tunnel record is – like an object record – applied to the entire cross section of the road within the
    /// given range unless a lane validity record with further restrictions is provided as child record.
    /// </summary>
    class Tunnel
    {
        public double s;
        public double length;
        public double lighting;
        public double daylight;
        public string id;
        public string name;
        public string type;
        public Tunnel(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.name = node.Attributes.GetNamedItem("name").Value;
            this.type = node.Attributes.GetNamedItem("type").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.length = Convert.ToDouble(node.Attributes.GetNamedItem("length").Value);
            this.lighting = Convert.ToDouble(node.Attributes.GetNamedItem("lighting").Value);
            this.daylight = Convert.ToDouble(node.Attributes.GetNamedItem("daylight").Value);
        }
    }

    /// <summary>
    /// The bridge record is – like an object record – applied to the entire cross section of the road within the
    /// given range unless a lane validity record with further restrictions is provided as child record.
    /// </summary>
    class Bridge
    {
        public double s;
        public double length;
        public string id;
        public string name;
        public string type;
        public Bridge(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            this.type = node.Attributes.GetNamedItem("type").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.length = Convert.ToDouble(node.Attributes.GetNamedItem("length").Value);
        }
    }

    class TypeElement
    {
        public double s;
        public string type;
        public string country; //country code of the road
        public string max;
        public string unit;
        public string name;
        public string width;
        public TypeElement(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.type = node.Attributes.GetNamedItem("type").Value;
            if (node.Attributes.GetNamedItem("country") != null) this.country = node.Attributes.GetNamedItem("country").Value;
            foreach (XmlNode node1 in node.SelectNodes("speed"))
            {
                this.max = node1.Attributes.GetNamedItem("max").Value;
                if (node1.Attributes.GetNamedItem("unit") != null) this.unit = node1.Attributes.GetNamedItem("unit").Value;
            }
            foreach (XmlNode node2 in node.SelectNodes("type"))
            {
                this.name = node2.Attributes.GetNamedItem("name").Value;
                this.width = node2.Attributes.GetNamedItem("width").Value;
            }

        }
    }

    class Lanes
    {
        public List<LaneOffset> laneoffsets = new List<LaneOffset>();
        public List<LaneSection> lanesections = new List<LaneSection>();
        public Lanes(XmlNode node)
        {
            foreach (XmlNode node1 in node.SelectNodes("laneOffset"))
            {
                LaneOffset laneoffset = new LaneOffset(node1);
                this.laneoffsets.Add(laneoffset);
            }

            foreach (XmlNode node2 in node.SelectNodes("laneSection"))
            {
                LaneSection lanesection = new LaneSection(node2);
                this.lanesections.Add(lanesection);
            }

        }

    }

    /// <summary>
    /// The lane section record defines the characteristics of a the road cross-section along the road. 
    /// It specifies the numbers and types of lanes and further features of the lanes. 
    /// At least one record must be defined in order to use a road. 
    /// A lane section record is valid until a new lane section record is defined. 
    /// If multiple lane section records are defined, they must be listed in ascending order. 
    /// If multiple single-sided lane section records start at identical positions, their order is arbitrary. 
    /// If the attribute "singleSide" is not given or false, the record is valid for all sides.
    /// </summary>
    class LaneSection
    {
        public double s;
        public string singleSide;
        public List<Lane> lanes = new List<Lane>();

        public LaneSection(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            if (node.Attributes.GetNamedItem("s") != null) this.singleSide = node.Attributes.GetNamedItem("s").Value;
            foreach (XmlNode node1 in node.ChildNodes)
            {
                Lane lane = new Lane(node1);
                lanes.Add(lane);
            }

        }
    }

    /// <summary>
    /// Lane records are found within the left/center/right records. 
    /// They define the IDs of the actual lanes (and, therefore, their position on the road, see conventions in 3). 
    /// In order to prevent confusion, lane records should represent the lanes from left to right (i.e. with descending ID). 
    /// All properties of the lanes are defined as children of the lane records.
    /// </summary>
    class Lane
    {
        public string location;
        public int id;
        public string type;
        public string level;
        public LaneLink link;
        public List<Width> widths = new List<Width>();
        public List<LaneBorder> borders = new List<LaneBorder>();
        public List<RoadMark> roadmarks = new List<RoadMark>();
        public List<LaneMaterial> materials = new List<LaneMaterial>();
        public List<Visibility> viss = new List<Visibility>();
        public List<Speed> speeds = new List<Speed>();
        public List<Access> accesses = new List<Access>();
        public List<Height> heights = new List<Height>();
        public List<Rule> rules = new List<Rule>();


        public Lane(XmlNode node)
        {
            //left/right/center
            this.location = node.Name;
            //lane
            XmlNode nlane = node.FirstChild;
            this.id = Convert.ToInt32(nlane.Attributes.GetNamedItem("id").Value);
            this.type = nlane.Attributes.GetNamedItem("type").Value;
            if (nlane.Attributes.GetNamedItem("level") != null) this.level = nlane.Attributes.GetNamedItem("level").Value;
            foreach (XmlNode nlink in nlane.SelectNodes("link"))
            {
                LaneLink ll = new LaneLink(nlink);
            }
            foreach (XmlNode nwidth in nlane.SelectNodes("width"))
            {
                Width lw = new Width(nwidth);
                widths.Add(lw);
            }

            foreach (XmlNode nborder in nlane.SelectNodes("border"))
            {
                LaneBorder lb = new LaneBorder(nborder);
                borders.Add(lb);
            }
            foreach (XmlNode nrm in nlane.SelectNodes("roadmark"))
            {
                RoadMark lrm = new RoadMark(nrm);
                roadmarks.Add(lrm);
            }
            foreach (XmlNode nmt in nlane.SelectNodes("material"))
            {
                LaneMaterial lmt = new LaneMaterial(nmt);
                materials.Add(lmt);
            }
            foreach (XmlNode nvs in nlane.SelectNodes("visibility"))
            {
                Visibility lvs = new Visibility(nvs);
                viss.Add(lvs);
            }
            foreach (XmlNode nsp in nlane.SelectNodes("speed"))
            {
                Speed lsp = new Speed(nsp);
                speeds.Add(lsp);
            }
            foreach (XmlNode nac in nlane.SelectNodes("access"))
            {
                Access lac = new Access(nac);
                accesses.Add(lac);
            }
            foreach (XmlNode nht in nlane.SelectNodes("height"))
            {
                Height lht = new Height(nht);
                heights.Add(lht);
            }
            foreach (XmlNode nr in nlane.SelectNodes("height"))
            {
                Rule lr = new Rule(nr);
                rules.Add(lr);
            }
        }
    }

    /// <summary>
    /// offset = a + b*ds + c*ds2 + d*ds3
    /// s = sstart + ds
    /// The lane offset record defines a lateral shift of the lane reference line 
    /// (which is usually identical to the road reference line). 
    /// This may be used for an easy implementation of a (local) lateral shift of the lanes relative to the road’s reference line. 
    /// Especially the modeling of inner-city layouts or "2+1" cross-country road layouts can be facilitated considerably by this feature.
    /// </summary>
    class LaneOffset
    {
        public double s;
        public double a;
        public double b;
        public double c;
        public double d;
        public LaneOffset(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// In order to facilitate navigation through a road network on a per-lane basis, lanes should be provided with predecessor/successor information. 
    /// Only when lanes end at a junction or have no physical link, this record should be omitted.
    /// </summary>
    class LaneLink
    {
        public List<LanePredecessor> predecessors = new List<LanePredecessor>();
        public List<LaneSuccessor> successors = new List<LaneSuccessor>();

        public LaneLink(XmlNode node)
        {
            foreach (XmlNode npre in node.SelectNodes("predecessor"))
            {
                this.predecessors.Add(new LanePredecessor(npre));
            }
            foreach (XmlNode nsuc in node.SelectNodes("successor"))
            {
                this.predecessors.Add(new LanePredecessor(nsuc));
            }
        }

    }

    /// <summary>
    /// This record provides detailed information about the predecessor of a lane.
    /// </summary>
    class LanePredecessor
    {
        public int id;
        public LanePredecessor(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("elementId") != null) this.id = Convert.ToInt32(node.Attributes.GetNamedItem("id").Value);
        }
    }

    /// <summary>
    /// This record provides detailed information about the successor of a lane.
    /// </summary>
    class LaneSuccessor
    {
        public int id;
        public LaneSuccessor(XmlNode node)
        {
            this.id = Convert.ToInt32(node.Attributes.GetNamedItem("id").Value);
        }
    }

    /// <summary>
    /// width = a + b*ds + c*ds2 + d*ds3
    /// s = ssection + offsetstart + ds
    /// Each lane within a road’s cross section can be provided with several width entries. 
    /// At least one entry must be defined for each lane, except for the center lane which is, per convention, of zero width (see 3.2). 
    /// Each entry is valid until a new entry is defined. If multiple entries are defined for a lane, they must be listed in ascending order.
    /// </summary>
    class Width
    {
        public double sOffset;
        public double a;
        public double b;
        public double c;
        public double d;
        public Width(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// tborder = a + b*ds + c*ds2 + d*ds3
    /// s = ssection + offsetstart + ds
    /// Instead of describing lanes by their width entries it might be more convenient to describe the outer border of a lane directly, i.e. independently of any inner lanes’ characteristics 
    /// (inner lane = each lane with lower absolute numeric ID than the lane that is currently being defined). 
    /// Especially in cases where road data is derived from measurements, this type of definition will provide a more convenient method without the need to create a large number of lane sections.
    /// </summary>
    class LaneBorder
    {
        public double sOffset;
        public double a;
        public double b;
        public double c;
        public double d;
        public LaneBorder(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// Each lane within a road cross section can be provided with several road mark entries. The road mark information defines the style of the line at the lane’s outer border. 
    /// For left lanes, this is the left border, for right lanes the right one. 
    /// The style of the line separating left and right lanes is determined by the road mark entry for lane zero (i.e. the center lane)
    /// </summary>
    class RoadMark
    {
        public double sOffset;
        public double width;
        public double height;
        public string type;
        public string weight;
        public string color;
        public string material;
        public string laneChange;
        public List<Sway> sways = new List<Sway>();
        public List<RoadMarkType> RMTypes = new List<RoadMarkType>();
        public List<RoadMarkExpLine> RMELines = new List<RoadMarkExpLine>();

        public RoadMark(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);

            if (node.Attributes.GetNamedItem("width") != null) this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);

            if (node.Attributes.GetNamedItem("height") != null) this.height = Convert.ToDouble(node.Attributes.GetNamedItem("height").Value);

            this.type = node.Attributes.GetNamedItem("type").Value;

            if (node.Attributes.GetNamedItem("weight") != null) this.weight = node.Attributes.GetNamedItem("weight").Value;

            this.color = node.Attributes.GetNamedItem("color").Value;

            if (node.Attributes.GetNamedItem("material") != null) this.material = node.Attributes.GetNamedItem("material").Value;

            if (node.Attributes.GetNamedItem("laneChange") != null) this.laneChange = node.Attributes.GetNamedItem("laneChange").Value;

            foreach (XmlNode ns in node.SelectNodes("sway"))
            {
                Sway lrm = new Sway(ns);
                sways.Add(lrm);
            }

            foreach (XmlNode ntype in node.SelectNodes("type"))
            {
                RoadMarkType lrm = new RoadMarkType(ntype);
                RMTypes.Add(lrm);
            }

            if (node.SelectSingleNode("explicit") != null)
            {
                foreach (XmlNode nrmtl in node.SelectSingleNode("explicit").SelectNodes("line"))
                {
                    RoadMarkExpLine rmel = new RoadMarkExpLine(nrmtl);
                    RMELines.Add(rmel);
                }
            }

        }
    }

    /// <summary>
    /// tborder = a + b*ds + c*ds2 + d*ds3
    /// </summary>
    class Sway
    {
        public double ds;
        public double a;
        public double b;
        public double c;
        public double d;
        public Sway(XmlNode node)
        {
            this.ds = Convert.ToDouble(node.Attributes.GetNamedItem("ds").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// Road marks may be further described in terms of their type. 
    /// Instead of providing additional parameters to the roadMark tag, type definitions shall be defined as children to the roadMark tag. 
    /// Each type definition must contain one or more line definitions with additional information about the lines the road mark is composed of.
    /// </summary>
    class RoadMarkType
    {
        public string name;
        public double width;
        public List<RoadMarkTypeLine> RMLines = new List<RoadMarkTypeLine>();
        public RoadMarkType(XmlNode node)
        {
            this.name = node.Attributes.GetNamedItem("name").Value;
            this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
            foreach (XmlNode nline in node.SelectNodes("line"))
            {
                RoadMarkTypeLine lrml = new RoadMarkTypeLine(nline);
                RMLines.Add(lrml);
            }
        }
    }

    /// <summary>
    /// A road mark may consist of one or more elements. Multiple elements will usually be positioned side by side.
    /// Currently, the elements can only be lines. 
    /// Each line can be defined by its line/space setup and by a lateral offset to the road mark's reference position 
    /// (i.e. the border between two lanes or the position defined by a <sway> record). 
    /// A line definition is valid for a given length (i.e. the total of visible line and invisible space) and will be repeated automatically.
    /// </summary>
    class RoadMarkTypeLine
    {
        public string rule;
        public string color;
        public double length;
        public double space;
        public double tOffset;
        public double sOffset;
        public double width;
        public RoadMarkTypeLine(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("rule") != null) this.rule = node.Attributes.GetNamedItem("rule").Value;
            if (node.Attributes.GetNamedItem("color") != null) this.color = node.Attributes.GetNamedItem("color").Value;
            this.length = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
            this.space = Convert.ToDouble(node.Attributes.GetNamedItem("space").Value);
            this.tOffset = Convert.ToDouble(node.Attributes.GetNamedItem("tOffset").Value);
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
        }
    }

    /// <summary>
    /// Road mark data that is highly irregular, may be defined with individual explicit entries per visible line. 
    /// In contrast to the <line> record, there is no inherent concept for repeating any definition; 
    /// therefore, only the explicitly defined entries will be valid.
    /// 
    /// This entry specifies a single line in an explicit road mark definition.
    /// </summary>
    class RoadMarkExpLine
    {
        public string rule;
        public string color;
        public double length;
        public double tOffset;
        public double sOffset;
        public double width;
        public RoadMarkExpLine(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("rule") != null) this.rule = node.Attributes.GetNamedItem("rule").Value;
            if (node.Attributes.GetNamedItem("color") != null) this.color = node.Attributes.GetNamedItem("color").Value;
            this.length = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
            this.tOffset = Convert.ToDouble(node.Attributes.GetNamedItem("tOffset").Value);
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
        }
    }

    /// <summary>
    /// Each lane within a road cross section may be provided with several entries defining its material. 
    /// Each entry is valid until a new entry is defined. 
    /// If multiple entries are defined, they must be listed in increasing order.
    /// </summary>
    class LaneMaterial
    {
        public string surface;
        public double friction;
        public double sOffset;
        public double roughness;
        public LaneMaterial(XmlNode node)
        {
            if (node.Attributes.GetNamedItem("surface") != null) this.surface = node.Attributes.GetNamedItem("surface").Value;
            if (node.Attributes.GetNamedItem("roughness") != null) this.roughness = Convert.ToDouble(node.Attributes.GetNamedItem("roughness").Value);
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.friction = Convert.ToDouble(node.Attributes.GetNamedItem("friction").Value);
        }
    }

    /// <summary>
    /// Each lane within a road cross section may be provided with several entries defining the visibility in four directions relative to the lane’s direction. 
    /// Each entry is valid until a new entry is defined. 
    /// If multiple entries are defined, they must be listed in increasing order.
    /// </summary>
    class Visibility
    {
        public double sOffset;
        public double forward;
        public double back;
        public double left;
        public double right;
        public Visibility(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.forward = Convert.ToDouble(node.Attributes.GetNamedItem("forward").Value);
            this.back = Convert.ToDouble(node.Attributes.GetNamedItem("back").Value);
            this.left = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.right = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
        }
    }

    /// <summary>
    /// This record defines the maximum allowed speed on a given lane.
    /// Each entry is valid in direction of the increasing s co-ordinate until a new entry is defined. 
    /// If multiple entries are defined, they must be listed in increasing order.
    /// </summary>
    class Speed
    {
        public double sOffset;
        public double max;
        public string unit;
        public Speed(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.max = Convert.ToDouble(node.Attributes.GetNamedItem("max").Value);
            if (node.Attributes.GetNamedItem("unit") != null) this.unit = node.Attributes.GetNamedItem("unit").Value;
        }
    }

    /// <summary>
    /// This record defines access restrictions for certain types of road users. 
    /// The record can be used to complement restrictions resulting from signs or signals in order to control the traffic flow in a scenario.
    /// 
    /// Each entry is valid in direction of the increasing s co-ordinate until a new entry is defined.If multiple entries are defined, they must be listed in increasing order; 
    /// entries may start at identical offset positions, though.
    /// </summary>
    class Access
    {
        public double sOffset;
        public string rule;
        public string restriction;
        public Access(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.rule = node.Attributes.GetNamedItem("rule").Value;
            this.restriction = node.Attributes.GetNamedItem("restriction").Value;
        }
    }

    /// <summary>
    /// The surface of a lane may be offset from the plane defined by the reference line and the corresponding elevation and crossfall entries 
    /// (e.g. pedestrian walkways are typically a few centimeters above road level). 
    /// The height record provides a simplified method to describe this offset by setting an inner and outer offset from road level at discrete positions along the lane profile.
    /// </summary>
    class Height
    {
        public double sOffset;
        public double inner;
        public double outer;
        public Height(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.inner = Convert.ToDouble(node.Attributes.GetNamedItem("inner").Value);
            this.outer = Convert.ToDouble(node.Attributes.GetNamedItem("outer").Value);
        }
    }

    /// <summary>
    /// Lane properties may be further described by additional rules which are not covered by any of the other lane attributes defined within this format specification. For example, the rules "no parking at any time", "disabled parking" 
    /// etc. may apply to entire lanes (in the USA, curb stones will show corresponding colors) and may not be derived implicitly from colors, signs etc. 
    /// For the time being, the description of the rules is up to the users. 
    /// Formal standardization within OpenDRIVE will be performed on the basis of user feedback.
    /// </summary>
    class Rule
    {
        public double sOffset;
        public string value;
        public Rule(XmlNode node)
        {
            this.sOffset = Convert.ToDouble(node.Attributes.GetNamedItem("sOffset").Value);
            this.value = node.Attributes.GetNamedItem("value").Value;
        }
    }
    class LateralProfile
    {
        public List<SuperElevation> superelevations = new List<SuperElevation>();
        public List<Crossfall> crossfalls = new List<Crossfall>();
        public List<Shape> shapes = new List<Shape>();

        public LateralProfile(XmlNode node)
        {
            foreach (XmlNode nele in node.SelectNodes("superelevation"))
            {
                SuperElevation ele = new SuperElevation(nele);
                superelevations.Add(ele);
            }
            foreach (XmlNode node1 in node.SelectNodes("crossfall"))
            {
                Crossfall cross = new Crossfall(node1);
                crossfalls.Add(cross);
            }
            foreach (XmlNode node2 in node.SelectNodes("shape"))
            {
                Shape shape = new Shape(node2);
                shapes.Add(shape);
            }
        }
    }

    /// <summary>
    /// sElev = a + b*ds + c*ds2 + d*ds3
    /// s = sstart + ds
    /// sElev: being the superelevation at a given position, default: sElev = 0
    /// The superelevation of the road is defined as the road section’s roll angle around the s-axis 
    /// (superelevation is positive for road surfaces “falling” to the right side, i.e. the following figure shows a negative superelevation).
    /// </summary>
    class SuperElevation
    {
        public double s;
        public double a;
        public double b;
        public double c;
        public double d;

        public SuperElevation(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// crfall = a + b*ds + c*ds2 + d*ds3
    /// s = sstart + ds
    /// The crossfall of the road is defined as the road surface´s angle relative to the t-axis. 
    /// Positive crossfall results in a road surface “falling” from the reference line to the outer boundary.
    /// </summary>
    class Crossfall
    {
        public string side;
        public double s;
        public double a;
        public double b;
        public double c;
        public double d;
        public Crossfall(XmlNode node)
        {
            this.side = node.Attributes.GetNamedItem("side").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// hShape = a + b*dt + c*dt2 + d*dt3
    /// t = tstart + dt
    /// The shape of the road is defined as the road section’s surface relative to the reference plane (which may itself be tilted around the s-axis due to an existing super-elevation). 
    /// This shape may be described as a series of 3rd order polynomials for a given "s" station. 
    /// Multiple shapes may be defined along a road at consecutive "s" stations. 
    /// Between the shapes at these stations, there shall be a linear interpolation along s.
    /// 
    /// </summary>
    class Shape
    {
        public double s;
        public double t;
        public double a;
        public double b;
        public double c;
        public double d;
        public Shape(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.t = Convert.ToDouble(node.Attributes.GetNamedItem("t").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    class Neighbor
    {
        public string side;
        public string elementId;
        public string direction;

        public Neighbor(XmlNode node)
        {
            this.side = node.Attributes.GetNamedItem("side").Value;
            this.elementId = node.Attributes.GetNamedItem("elementId").Value;
            this.direction = node.Attributes.GetNamedItem("direction").Value;
        }
    }

    class Signals
    {
        public List<SignalsReference> Sreferences = new List<SignalsReference>();
        public List<Signal> signals = new List<Signal>();
        public Signals(XmlNode node)
        {
            foreach (XmlNode ns in node.SelectNodes("signal"))
            {
                Signal s = new Signal(ns);
                signals.Add(s);
            }

            foreach (XmlNode nrf in node.SelectNodes("signalReference"))
            {
                SignalsReference rf = new SignalsReference(nrf);
                Sreferences.Add(rf);
            }
        }
    }

    /// <summary>
    /// The signal record is used to provide information about signs and signals along a road. 
    /// Signals are signs that can change their state dynamically (e.g. traffic lights). 
    /// The signal record consists of a main record and an optional lane validity record.
    /// </summary>
    class Signal
    {
        public string id;
        public string name;
        public string dynamic;
        public string orientation;
        public string country;
        public string countryRevision;
        public string type;
        public string subtype;
        public string unit;
        public string text;
        public double s;
        public double t;
        public double zOffset;
        public double value;
        public double height;
        public double width;
        public double hOffset;
        public double pitch;
        public double roll;
        public List<Validity> validities = new List<Validity>();
        public List<Dependency> dependencies = new List<Dependency>();
        public List<SignalReference> Sreferences = new List<SignalReference>();
        public PositionRoad positionroad;
        public PositionInertial postioninertial;
        public Signal(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            if (node.Attributes.GetNamedItem("name") != null) this.name = node.Attributes.GetNamedItem("name").Value;
            this.dynamic = node.Attributes.GetNamedItem("dynamic").Value;
            this.orientation = node.Attributes.GetNamedItem("orientation").Value;
            if (node.Attributes.GetNamedItem("country") != null) this.country = node.Attributes.GetNamedItem("country").Value;
            if (node.Attributes.GetNamedItem("countryRevision") != null) this.countryRevision = node.Attributes.GetNamedItem("countryRevision").Value;
            this.type = node.Attributes.GetNamedItem("type").Value;
            this.subtype = node.Attributes.GetNamedItem("subtype").Value;
            if (node.Attributes.GetNamedItem("unit") != null) this.unit = node.Attributes.GetNamedItem("unit").Value;
            if (node.Attributes.GetNamedItem("text") != null) this.text = node.Attributes.GetNamedItem("text").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.t = Convert.ToDouble(node.Attributes.GetNamedItem("t").Value);
            this.zOffset = Convert.ToDouble(node.Attributes.GetNamedItem("zOffset").Value);
            if (node.Attributes.GetNamedItem("value") != null) this.value = Convert.ToDouble(node.Attributes.GetNamedItem("value").Value);
            if (node.Attributes.GetNamedItem("height") != null) this.height = Convert.ToDouble(node.Attributes.GetNamedItem("height").Value);
            if (node.Attributes.GetNamedItem("width") != null) this.width = Convert.ToDouble(node.Attributes.GetNamedItem("width").Value);
            if (node.Attributes.GetNamedItem("hOffset") != null) this.hOffset = Convert.ToDouble(node.Attributes.GetNamedItem("hOffset").Value);
            if (node.Attributes.GetNamedItem("pitch") != null) this.pitch = Convert.ToDouble(node.Attributes.GetNamedItem("pitch").Value);
            if (node.Attributes.GetNamedItem("roll") != null) this.roll = Convert.ToDouble(node.Attributes.GetNamedItem("roll").Value);

            foreach (XmlNode nvl in node.SelectNodes("validity"))
            {
                Validity vl = new Validity(nvl);
                validities.Add(vl);
            }
            foreach (XmlNode nrf in node.SelectNodes("reference"))
            {
                SignalReference rf = new SignalReference(nrf);
                Sreferences.Add(rf);
            }
            foreach (XmlNode ndp in node.SelectNodes("dependency"))
            {
                Dependency dp = new Dependency(ndp);
                dependencies.Add(dp);
            }
            if (node.SelectSingleNode("positionRoad") != null) this.positionroad = new PositionRoad(node.SelectSingleNode("positionRoad"));
            if (node.SelectSingleNode("positionInertial") != null) this.postioninertial = new PositionInertial(node.SelectSingleNode("positionInertial"));
        }
    }

    /// <summary>
    /// The signal dependency record provides signals with a means to control other signals. 
    /// Signs can e.g. restrict other signs for various types of vehicles, warning lights can be turned on when a traffic light goes red etc. 
    /// The signal dependency record is an optional child record of the signal record. 
    /// A signal may have multiple dependency records.
    /// </summary>
    class Dependency
    {
        public string id;
        public string type;
        public Dependency(XmlNode node)
        {

            this.id = node.Attributes.GetNamedItem("id").Value;
            if (node.Attributes.GetNamedItem("type") != null) this.type = node.Attributes.GetNamedItem("type").Value;
        }
    }

    /// <summary>
    /// The reference record provides a means to link a signal to a series of other elements (e.g. objects and signals).
    /// </summary>
    class SignalReference
    {
        public string elementType;
        public string elementId;
        public string type;
        public SignalReference(XmlNode node)
        {
            this.elementType = node.Attributes.GetNamedItem("elementType").Value;
            this.elementId = node.Attributes.GetNamedItem("elementId").Value;
            if (node.Attributes.GetNamedItem("type") != null) this.type = node.Attributes.GetNamedItem("type").Value;
        }
    }

    /// <summary>
    /// In cases where an actual (physical) signal position deviates from its logical position, there should be a means to describe the reference point of the physical position in either inertial or road co-ordinates 
    /// (since this position may or may not be associated with any road).
    /// </summary>
    class PositionRoad
    {
        public string roadId;
        public double s;
        public double t;
        public double zOffset;
        public double hOffset;
        public double pitch;
        public double roll;

        public PositionRoad(XmlNode node)
        {
            this.roadId = node.Attributes.GetNamedItem("roadId").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.t = Convert.ToDouble(node.Attributes.GetNamedItem("t").Value);
            this.zOffset = Convert.ToDouble(node.Attributes.GetNamedItem("zOffset").Value);
            this.hOffset = Convert.ToDouble(node.Attributes.GetNamedItem("hOffset").Value);
            if (node.Attributes.GetNamedItem("pitch") != null) this.pitch = Convert.ToDouble(node.Attributes.GetNamedItem("pitch").Value);
            if (node.Attributes.GetNamedItem("roll") != null) this.roll = Convert.ToDouble(node.Attributes.GetNamedItem("roll").Value);
        }
    }

    /// <summary>
    /// In cases where an actual (physical) signal position deviates from its logical position, there should be a means to describe the reference point of the physical position in either inertial or road co-ordinates 
    /// (since this position may or may not be associated with any road).
    /// </summary>
    class PositionInertial
    {
        public double x;
        public double y;
        public double z;
        public double hdg;
        public double pitch;
        public double roll;

        public PositionInertial(XmlNode node)
        {
            this.x = Convert.ToDouble(node.Attributes.GetNamedItem("x").Value);
            this.y = Convert.ToDouble(node.Attributes.GetNamedItem("y").Value);
            this.z = Convert.ToDouble(node.Attributes.GetNamedItem("z").Value);
            this.hdg = Convert.ToDouble(node.Attributes.GetNamedItem("hdg").Value);
            if (node.Attributes.GetNamedItem("pitch") != null) this.pitch = Convert.ToDouble(node.Attributes.GetNamedItem("pitch").Value);
            if (node.Attributes.GetNamedItem("roll") != null) this.roll = Convert.ToDouble(node.Attributes.GetNamedItem("roll").Value);
        }
    }

    /// <summary>
    /// Depending on the way roads (especially in junctions) are laid out for different applications, it may be necessary to refer to the same (i.e. the identical) signal from multiple roads. 
    /// In order to prevent inconsistencies by multiply defining an entire signal entry, the user only needs to define the complete signal entry once and can refer to this complete record by means of the signal reference record.
    /// </summary>
    class SignalsReference
    {
        public double s;
        public double y;
        public string id;
        public string orientation;

        public SignalsReference(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.y = Convert.ToDouble(node.Attributes.GetNamedItem("y").Value);
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.orientation = node.Attributes.GetNamedItem("orientation").Value;
        }
    }

    class RoadLink
    {
        public RoadPredecessor pred;
        public RoadSuccessor succ;

        public RoadLink(XmlNode node)
        {
            if (node.SelectSingleNode("predecessor") != null) this.pred = new RoadPredecessor(node.SelectSingleNode("predecessor"));
            if (node.SelectSingleNode("successor") != null) this.succ = new RoadSuccessor(node.SelectSingleNode("successor"));
        }

    }
    class RoadPredecessor
    {
        public string type;
        public int id;
        public string cpoint;
        public RoadPredecessor(XmlNode node)
        {
            this.type = node.Attributes.GetNamedItem("elementType").Value;
            if (node.Attributes.GetNamedItem("elementId") != null) this.id = Convert.ToInt32(node.Attributes.GetNamedItem("elementId").Value);
            if (node.Attributes.GetNamedItem("contactPoint") != null) this.cpoint = node.Attributes.GetNamedItem("contactPoint").Value;
        }
    }

    class RoadSuccessor
    {
        public string type;
        public int id;
        public string cpoint;
        public RoadSuccessor(XmlNode node)
        {
            this.type = node.Attributes.GetNamedItem("elementType").Value;
            this.id = Convert.ToInt32(node.Attributes.GetNamedItem("elementId").Value);
            if (node.Attributes.GetNamedItem("contactPoint") != null) this.cpoint = node.Attributes.GetNamedItem("contactPoint").Value;
        }
    }

    class PlanView
    {
        public List<Geometry> geos = new List<Geometry>();

        public PlanView(XmlNode node)
        {
            XmlNodeList nlgeo = node.SelectNodes("geometry");
            foreach (XmlNode ngeo in nlgeo)
            {
                Geometry geo = new Geometry(ngeo);
                geos.Add(geo);
            }
        }
    }

    class Geometry
    {
        public double s;
        public double x;
        public double y;
        public double hdg;
        public double length;
        public Curve curve;
        public Geometry(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.x = Convert.ToDouble(node.Attributes.GetNamedItem("x").Value);
            this.y = Convert.ToDouble(node.Attributes.GetNamedItem("y").Value);
            this.hdg = Convert.ToDouble(node.Attributes.GetNamedItem("hdg").Value);
            this.length = Convert.ToDouble(node.Attributes.GetNamedItem("length").Value);
            this.curve = new Curve(node.FirstChild);
        }
    }

    class ElevationProfile
    {
        public List<Elevation> elevations = new List<Elevation>();

        public ElevationProfile(XmlNode node)
        {
            foreach (XmlNode nele in node.SelectNodes("elevation"))
            {
                Elevation ele = new Elevation(nele);
                elevations.Add(ele);
            }

        }
    }

    /// <summary>
    /// elev = a + b*ds + c*ds2 + d*ds3
    /// s = sstart + ds
    /// The elevation record defines an elevation entry at a given reference line position. Entries must be defined in increasing order along the reference line. 
    /// The parameters of an entry are valid until the next entry starts or the road’s reference line ends. Per default, the elevation of a road is zero.\
    /// </summary>
    class Elevation

    {
        public double s;
        public double a;
        public double b;
        public double c;
        public double d;
        public Elevation(XmlNode node)
        {
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);
        }
    }

    /// <summary>
    /// The available set of railroad records below the road level is currently limited to the definition of switches. 
    /// All other entries shall, for the moment, be covered with the existing records (e.g. track definition by <road>, signal definition by <signal> etc.). 
    /// It shall be noted again, that railroad specific elements are defined on the background of streetcar applications.
    /// </summary>
    class Railroad
    {
        public List<Switch> swcs = new List<Switch>();
        public Railroad(XmlNode node)
        {
            foreach (XmlNode nswc in node.SelectNodes("CRG"))
            {
                Switch swc = new Switch(nswc);
                swcs.Add(swc);
            }

        }
    }

    class Switch
    {
        public string name;
        public string id;
        public string position;
        public MainTrack maintrack;
        public SideTrack sidetrack;
        public Partner partner;
        public Switch(XmlNode node)
        {
            this.name = node.Attributes.GetNamedItem("name").Value;
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.position = node.Attributes.GetNamedItem("position").Value;
            this.maintrack = new MainTrack(node.SelectSingleNode("mainTrack"));
            if (node.SelectSingleNode("partner") != null) this.partner = new Partner(node.SelectSingleNode("partner"));
        }
    }


    class MainTrack
    {
        public string name;
        public double s;
        public string dir;
        public MainTrack(XmlNode node)
        {
            this.name = node.Attributes.GetNamedItem("name").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.dir = node.Attributes.GetNamedItem("dir").Value;
        }
    }

    class SideTrack
    {
        public string id;
        public double s;
        public string dir;
        public SideTrack(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.s = Convert.ToDouble(node.Attributes.GetNamedItem("s").Value);
            this.dir = node.Attributes.GetNamedItem("dir").Value;
        }
    }


    class Partner
    {
        public string id;
        public string name;
        public Partner(XmlNode node)
        {
            this.id = node.Attributes.GetNamedItem("id").Value;
            this.name = node.Attributes.GetNamedItem("name").Value;
        }
    }

    class Curve
    {
        public string type;
        public Line line;
        public Spiral spiral;
        public Arc arc;
        public Poly3 poly3;
        public ParamPoly3 parampoly3;
        public Curve(XmlNode node)
        {
            this.type = node.Name;
            switch (type)
            {
                case "line":
                    line = new Line(node);
                    break;
                case "spiral":
                    spiral = new Spiral(node);
                    break;
                case "arc":
                    arc = new Arc(node);
                    break;
                case "poly3":
                    poly3 = new Poly3(node);
                    break;
                case "paramPoly3":
                    parampoly3 = new ParamPoly3(node);
                    break;
                default:
                    break;
            }
        }
    }

    class Line
    {
        public Line(XmlNode node)
        {

        }
    }

    class Spiral
    {
        public double curvStart;
        public double curvEnd;
        public Spiral(XmlNode node)
        {
            this.curvStart = Convert.ToDouble(node.Attributes.GetNamedItem("curvStart").Value);
            this.curvEnd = Convert.ToDouble(node.Attributes.GetNamedItem("curvEnd").Value);
        }
    }

    class Arc
    {
        public double curvature;
        public Arc(XmlNode node)
        {
            this.curvature = Convert.ToDouble(node.Attributes.GetNamedItem("curvature").Value);
        }
    }

    /// <summary>
    /// ulocal = au + bu*p + cu*p2 + du*p3
    /// vlocal = av + bv* p + cv* p2 + dv* p3

    /// </summary>
    class ParamPoly3
    {
        public double aU;
        public double bU;
        public double cU;
        public double dU;
        public double aV;
        public double bV;
        public double cV;
        public double dV;
        public double pRange;
        public ParamPoly3(XmlNode node)
        {
            this.aU = Convert.ToDouble(node.Attributes.GetNamedItem("aU").Value);
            this.bU = Convert.ToDouble(node.Attributes.GetNamedItem("bU").Value);
            this.cU = Convert.ToDouble(node.Attributes.GetNamedItem("cU").Value);
            this.dU = Convert.ToDouble(node.Attributes.GetNamedItem("dU").Value);
            this.aV = Convert.ToDouble(node.Attributes.GetNamedItem("aV").Value);
            this.bV = Convert.ToDouble(node.Attributes.GetNamedItem("bV").Value);
            this.cV = Convert.ToDouble(node.Attributes.GetNamedItem("cV").Value);
            this.dV = Convert.ToDouble(node.Attributes.GetNamedItem("dV").Value);
            if (node.Attributes.GetNamedItem("pRange") != null) this.pRange = Convert.ToDouble(node.Attributes.GetNamedItem("pRange").Value);
        }
    }

    /// <summary>
    /// vlocal = a + b*du + c*du2 + d*du3
    /// </summary>
    class Poly3
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public Poly3(XmlNode node)
        {
            this.a = Convert.ToDouble(node.Attributes.GetNamedItem("a").Value);
            this.b = Convert.ToDouble(node.Attributes.GetNamedItem("b").Value);
            this.c = Convert.ToDouble(node.Attributes.GetNamedItem("c").Value);
            this.d = Convert.ToDouble(node.Attributes.GetNamedItem("d").Value);

        }
    }
}
