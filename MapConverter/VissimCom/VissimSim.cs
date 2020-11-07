using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VISSIMLIB;

namespace MapConvertor
{
    public class VissimSim
    {
        //静态成员
        public static Vissim vissim;
        public static string path;//vissim路径
        public static ISimulation sim;
        public static INet net;
        public static IVehicleContainer vehicles;
        public static IVehicle vehicle;
        public static int itemTimeStep;//当前步数
        public static IVehicleInputContainer vehiclein1;
    }
}
