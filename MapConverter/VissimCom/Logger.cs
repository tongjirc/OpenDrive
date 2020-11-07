using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace MapConvertor
{
    public static class Logger
    {
        public static string className="TestBed";

        private static void WriteLogs( string type, string content)
        {
            string dirName = "Log";
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (!string.IsNullOrEmpty(path))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + dirName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + (className ?? "") + " : " + type + " --> " + content);
                    sw.Close();
                }
            }
            
        }

        private static void Log(string type, string content)
        {
            WriteLogs(type, content);
        }

        public static void Debug(string content)
        {
            Log("Debug", content);
        }

        public static void Info(string content)
        {
            Log("Info", content);
        }

        public static void Warn(string content)
        {
            Log("Warn", content);
        }

        public static void Error(string content)
        {
            Log("Error", content);
        }

        public static void Fatal(string content)
        {
            Log("Fatal", content);
        }
    }
}
