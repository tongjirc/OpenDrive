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
            string filepath = @"..\..\kreuz-frankfurt-sample-generic-2019-02-08.xodr";
            Opendrive opendrive = new Opendrive(filepath);
        }
    }
}
