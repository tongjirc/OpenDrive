using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Windows.Forms;
using VISSIMLIB;
using System.Collections;

using MsgFrame;
using OpenDrive;
using OpenStreetMapsParser;
using System.Security.Cryptography.X509Certificates;

namespace MapConvertor
{
    public partial class MapConvertor : System.Windows.Forms.Form
    {
        public MapConvertor()
        {
            InitializeComponent();
        }
        public bool startFlag;//初始化运行指令
        public bool socketcon = false;//socket通信信标
        public bool fileopen = false;//路网加载是否完成

        IPEndPoint Serverip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7777); //target server ip OBU
        IPEndPoint clientip1 = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);//sender own ip

        UdpClient udpServer;
        UdpClient udpClient;
        static Thread SendMAPThread;
        int count = 0;

        /// <summary>
        /// check buffer generate
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public byte check(byte[] a, int b, int c)
        {
            byte d = a[b];
            for (int i = b + 1; i < c; i++)
                d = (byte)(d ^ a[i]);
            return d;
        }


        public void InitialVissim()//初始化路网
        {
            VissimSim.vissim = new Vissim();

            if (VissimSim.vissim != null)
            {
                VissimSim.vissim.LoadNet(Convert.ToString(VissimSim.path));
            }

        }


        private void btnRdMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            // filter
            dlg.Filter = " (*.xodr, *.xml) | *.xodr; *.xml;| All files(*.*) | *.* ";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.tbSimFilePath.Text = dlg.FileName;
            }

            //string filepath = @"..\..\kreuz-frankfurt-sample-generic-2019-02-08.xodr";
            Opendrive opendrive = new Opendrive(this.tbSimFilePath.Text);
            tbMapRd.Text = "Link Number: "+ opendrive.roads.Count().ToString() + "\r\n\r\n" + "Connection Number: "+ opendrive.junctions.Count().ToString();
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            if (fileopen == false)
            {
                fileopen = true;
                startFlag = true;//已加载路网
                VissimSim.path = @"H:\onedrive\OneDrive-同济大学\OneDrive - 同济大学\马万经课题组\项目\项目书ing\人车在环\代码\路网生成\MapConverter软件\MapConverterUI\MapConverter\VissimMap\SimMap.inpx";

                InitialVissim();//调用InitialVissim函数

                VissimSim.sim = VissimSim.vissim.Simulation;
                VissimSim.net = VissimSim.vissim.Net;
                VissimSim.vehicles = VissimSim.net.Vehicles;
            }
            else { MessageBox.Show("已经加载路网"); }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            udpServer = new UdpClient(clientip1);
            udpServer.Connect(Serverip);
            SendMAPThread = new Thread(new ThreadStart(send2CIDI));
            SendMAPThread.IsBackground = true;//使得程序界面关闭时线程也可以关闭
            SendMAPThread.Start();
        }

        /// <summary>
        /// msg with check buffer
        /// </summary>
        public void send2CIDI()
        {
            try
            {
                while (true)
                {
                    #region 信息打包成CV2X消息 数据域
                    MessageFrame msgf = new MessageFrame();
                    PerUnalignedCodec codec = new PerUnalignedCodec();
                    MapData map = new MapData();
                    MsgFrame.Node node = new MsgFrame.Node();
                    BasicSafetyMessage bsm = new BasicSafetyMessage();
                    byte[] buffercidi = new byte[100];
                    bsm.MsgCnt = 0;
                    bsm.SecMark = count++;
                    Console.WriteLine(count.ToString() + " " + System.DateTime.Now.ToString());
                    //bsm.Pos.Lat = 322222222;
                    //bsm.Pos.Long = 121222222;
                    //bsm.Pos.Elevation = -10;
                    bsm.Pos = new MsgFrame.Position3D();
                    bsm.Accuracy = new MsgFrame.PositionConfidenceSet();
                    bsm.Transmission = new MsgFrame.TransmissionState();
                    bsm.Speed = 20;
                    bsm.Heading = 10;
                    bsm.AccelSet = new MsgFrame.AccelerationSet4Way();
                    bsm.Brakes = new MsgFrame.BrakeSystemStatus();
                    bsm.Size = new MsgFrame.VehicleSize();
                    bsm.VehicleClass = new MsgFrame.VehicleClassification();
                    bsm.SafetyExt = new MsgFrame.VehicleSafetyExtensions();
                    bsm.Angle = 100;
                    bsm.Id = new byte[8];
                    bsm.MotionCfd = new MsgFrame.MotionConfidenceSet();
                    bsm.PlateNo = new byte[8];
                    msgf.BsmFrame = bsm;

                    byte[] bysend = codec.Encode(msgf);
                    //Console.WriteLine(BitConverter.ToString(bysend, 16));
                    Console.WriteLine(bysend.Length.ToString());
                    #endregion

                    byte[] buffer3 = new byte[6 + bysend.Length]; //最大80字节
                    buffer3[0] = 0xAA; //帧头0
                    buffer3[1] = 0x55; //帧头1
                    buffer3[2] = 0x00; //00 标准消息 01自定义消息
                    buffer3[3] = 0x50; //数据域长度低8位
                    buffer3[4] = 0x00; //数据域长度高8位
                    buffer3[5] = check(buffer3, 0, 5); //校验位
                    for (int i = 0; i < bysend.Length; i++)
                    {
                        buffer3[i + 6] = bysend[i];
                    }
                    udpServer.Send(buffer3, buffer3.Length);

                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                udpServer.Close();
                udpClient.Close();
                Console.WriteLine(ex.ToString());
            }
        }


        /// <summary>
        /// mocato location
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public List<double> Moc(List<double> x)
        {
            double x1 = x[1] / 180 * 20037508.3427892 - 15091.228712049313;
            double y1 = x[0] / 180 * 20037508.3427892 - 4078.183952489868;
            return new List<double>() { y1, x1 };
        }


        /// <summary>
        /// add the link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuild_Click(object sender, EventArgs e)
        {

            MapLinks links = new MapLinks("[[121.2133820,31.285886],[121.2139638, 31.2865935]]", "[[121.2141660, 31.2866371]," +
                "[121.2160953, 31.2854671],[121.2163246, 31.2852151],[121.2163601, 31.2851393],[121.2163758, 31.2850646],[121.2163814, 31.2848733]," +
                " [121.2163925, 31.2840516],[121.2163873, 31.2839563],[121.2163765, 31.2838958],[121.2163440, 31.2837675],[121.2161880, 31.2834861]," +
                "[121.2152711, 31.2823441],[121.2151738, 31.2822313],[121.2150853, 31.2821396],[121.2149775, 31.2820633],[121.2148896, 31.2820111]," +
                "[121.2144256, 31.2818966],[121.2142475, 31.2819505],[121.2142216, 31.2819903],[121.2142148, 31.2820574],[121.2142168, 31.2821373]," +
                "[121.2142148, 31.2846036],[121.2142126, 31.2847458],[121.2141895, 31.2849460],[121.2140973, 31.2851871],[121.2138221, 31.2854833], " +
                "[121.2133835, 31.2857569]]", "[[121.2133550, 31.2856843],[121.2137920, 31.2854163],[121.2139446, 31.2852710],[121.2140375, 31.2851205]," +
                "[121.2141033, 31.2849395],[121.2141205, 31.2848163],[121.2141286, 31.2820856],[121.2141338, 31.2820461],[121.2141946, 31.2819106]," +
                "[121.2142898, 31.2818595],[121.2144180, 31.2818543],[121.2148526, 31.2819563],[121.2149904, 31.2820246],[121.2150815, 31.2820901]," +
                "[121.2151610, 31.2821546],[121.2152441, 31.2822470],[121.2162668, 31.2835153],[121.2163321, 31.2836178],[121.2163766, 31.2837161]," +
                "[121.2164089, 31.2838223],[121.2164310, 31.2839981],[121.2164246, 31.2849813],[121.2164263, 31.2850688],[121.2163846, 31.2852246]," +
                "[121.2163203, 31.2853258],[121.2162000, 31.2854486],[121.2141725, 31.2866793]]", "[[121.2139551,31.2866538],[121.2133464, 31.2858938]]",
                "[[121.2122708,31.2863276],[121.2131735, 31.2857866]]", "[[121.2132083,31.2858663],[121.2123150, 31.2864003]]");

            List<MapConnector> connectors = new List<MapConnector>();
            connectors.Add(new MapConnector(1, 1, 2, 1, 1, "[[121.2139761, 31.2866085],[121.2140386, 31.2866530],[121.2141176, 31.2866628]]"));
            connectors.Add(new MapConnector(2, 1, 1, 1, 1, "[[121.2133590, 31.2857876],[121.2133515, 31.2858090],[121.2133551, 31.2858465]]"));
            connectors.Add(new MapConnector(2, 1, 6, 1, 1, "[[121.2133313, 31.2857863],[121.2133009, 31.2858019],[121.2132711, 31.2858210]]"));
            connectors.Add(new MapConnector(3, 1, 4, 1, 1, "[[121.2141185, 31.2867008],[121.2140918, 31.2867055],[121.2140635, 31.2867065]]"));
            connectors.Add(new MapConnector(4, 1, 6, 1, 1, "[[121.2133193, 31.2858745],[121.2132875, 31.2858613],[121.2132538, 31.2858563]]"));
            connectors.Add(new MapConnector(4, 1, 3, 1, 1, "[[121.2132968, 31.2858205],[121.2132896, 31.2857678],[121.2133031, 31.2857371]]"));
            connectors.Add(new MapConnector(5, 1, 1, 1, 1, "[[121.2132478, 31.2857801],[121.2132943, 31.2857968],[121.2133323, 31.2858291]]"));
            connectors.Add(new MapConnector(5, 1, 3, 1, 1, "[[121.2132310, 31.2857565],[121.2132573, 31.2857410],[121.2132801, 31.2857261]]"));

            try
            {
                ILinkContainer linkCtn = VissimSim.net.Links;
                foreach (ILink link in linkCtn)
                {
                    linkCtn.RemoveLink(link);
                }

                for (int i = 0; i < links.Links.Count(); i++)
                {
                    object[] array = { 3.5 };
                    string str = "LineString(";
                    for (int j = 0; j < links.Links[i].nodes.Count(); j++)
                    {
                        List<double> loc1 = Moc(links.Links[i].nodes[j].gpsPot);
                        str += Convert.ToString(loc1[0]) + ' ' + Convert.ToString(loc1[1]) + ',';
                    }
                    str = str.Remove(str.Length - 1, 1);
                    str += ")";

                    linkCtn.AddLink(links.Links[i].LinkNo, str, array);

                    Thread.Sleep(500); //sleep 500ms 
                }


                for (int i = 0; i < connectors.Count(); i++)
                {
                    ILane laneFrom = linkCtn.ItemByKey[connectors[i].FLinkId].Lanes.ItemByKey[connectors[i].FLaneId];
                    ILane laneEnd = linkCtn.ItemByKey[connectors[i].TLinkId].Lanes.ItemByKey[connectors[i].TLaneId];
                    double fromPos = linkCtn.ItemByKey[connectors[i].FLinkId].AttValue["Length2D"];
                    double toPos = 0;

                    string str = "LineString(";
                    for (int j = 0; j < connectors[i].link.nodes.Count(); j++)
                    {
                        List<double> loc1 = Moc(connectors[i].link.nodes[j].gpsPot);
                        str += Convert.ToString(loc1[0]) + ' ' + Convert.ToString(loc1[1]) + ',';
                    }
                    str = str.Remove(str.Length - 1, 1);
                    str += ")";

                    linkCtn.AddConnector(Convert.ToInt32(connectors[i].FLinkId.ToString() + "000" + connectors[i].TLinkId.ToString()), laneFrom, fromPos, laneEnd, toPos, connectors[i].LaneNum, str);

                    Thread.Sleep(500); //sleep 500ms
                }

                foreach (ILink link in linkCtn)
                {
                    if(Convert.ToBoolean(link.AttValue["IsConn"]))link.RecalculateSpline();
                }

            }
            catch (Exception ex)
            {
                VissimSim.vissim.Exit();
                MessageBox.Show(ex.ToString());
            }
            //object[] array = { 3.5, 3.5 };
            //    Console.WriteLine(array[0].ToString());
            //    ILink link = linkCtn.AddLink(42, "LINESTRING(1 1,2 2)", array);
            //    Console.WriteLine(Convert.ToString(link.AttValue["FromPos"]));

        }
    }
}
