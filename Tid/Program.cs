using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tid
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            //m.Log += AppendLog;
            //m.Log += delegate (string t) { System.IO.File.AppendAllText(@"c:\temp\helle.txt", t + "\r\n"); Console.WriteLine("Skriver til fil"); };
            m.Log += t => { System.IO.File.AppendAllText(@"c:\temp\helle.txt", t + "\r\n"); Console.WriteLine("Skrev til fil"); };

            m.StartLog();
            m.EndLog();

            Console.ReadKey();

        }

        //static void AppendLog(string t)
        //{
        //    System.IO.File.AppendAllText(@"c:\temp\helle.txt", t+"\r\n");

        //}

        public delegate void LogDelegate(string t);
        public class Maskine
        {

            public LogDelegate Log { get; set; }

            //public void StartLog()
            //{
            //    Log(DateTime.Now.ToLongTimeString("N2")+" Starter");
            //}
            public void StartLog() => Log(DateTime.Now.ToString("HH:mm:ss") + " Starter");

            //public void EndLog()
            //{
            //    Log(DateTime.Now.ToLongTimeString() + " Stopper");
            //}

            public void EndLog() => Log(DateTime.Now.ToLongTimeString() + " Stopper");

        }

    }
}
