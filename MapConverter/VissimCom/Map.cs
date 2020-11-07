using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapConvertor
{
    public class MapLinks
    {
        public List<MapLink> Links;
        public MapLinks(params string[] LinkStr)
        {
            Links = new List<MapLink>();
            int i = 1;
            foreach (var str in LinkStr)
            {
                Links.Add(new MapLink(i++, str));
            }
        }
    }
    public class MapLink
    {
        public int LinkNo;
        public List<MapNode> nodes;
        public MapLink(int no,string str)
        {
            LinkNo = no;
            nodes = new List<MapNode>();
            string[] StrArr = str.Split(']');
            for(int i=0;i<StrArr.Length;i++)
            {
                if (StrArr[i]!="")
                {
                    MapNode node = new MapNode(StrArr[i]);
                    nodes.Add(node);
                }
            }
        }
    }

    public class MapNode
    {
        public List<double> gpsPot;
        public MapNode(string str)
        {
            string[] StrArr = str.Split(',');
            char[] trimChars = { '[', ']', ',', ' '};
            gpsPot = new List<double>();
            for (int i = 0; i < StrArr.Length; i++)
            {
                if (StrArr[i] != "")
                {
                    gpsPot.Add(Convert.ToDouble(StrArr[i].Trim(trimChars)));
                }
            }

        }
    }

    public class MapConnector
    {
        public int FLinkId, FLaneId, TLinkId, TLaneId, LaneNum;
        public MapLink link;
        public MapConnector(int FLinkId1, int FLaneId1, int TLinkId1, int TLaneId1, int LaneNum1,string str)
        {
            FLinkId= FLinkId1;
            FLaneId= FLaneId1;
            TLinkId = TLinkId1;
            TLaneId = TLaneId1;
            LaneNum = LaneNum1;
            link = new MapLink(0,str);
        }
    }

}
