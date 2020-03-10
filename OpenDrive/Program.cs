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
            XmlDocument doc = new XmlDocument();
            //try
            //{
                doc.Load(@"..\..\kreuz-frankfurt-sample-generic-2019-02-08.xodr");
                Opendrive opendrive = new Opendrive(doc.DocumentElement);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}


        }
    }
}
