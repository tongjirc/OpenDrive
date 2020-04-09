using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;

namespace OpenDrive
{
    class Program
    {
         static void Main(string[] args)
        {
            string filepath = @"..\..\map.xodr";
            Opendrive opendrive = new Opendrive(filepath);
        }
    }
}
