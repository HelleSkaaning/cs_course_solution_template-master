using System;

namespace Module12_Delegates
{
    class Program
    {
        public delegate void MinDelegate();
        public delegate bool MinDelegate2(int a);
        public delegate double MinDelegate3(double a, double b);
        public delegate void MinDelegate4(string s);

        class Hund
        {
            public string Navn { get; set; }
            public event EventHandler SkalTisse;
            public event EventHandler<HundeTisEventArgs> SkalTisse2;

            public void Test() {
                if (SkalTisse != null)
                {
                    SkalTisse(this, new EventArgs());
                    SkalTisse2(this, new HundeTisEventArgs() { Niveau = 80});
                }
            }
                 
        }

        class HundeTisEventArgs : EventArgs {
            public int Niveau { get; set; }

        }


        static void Main(string[] args)
        {

            Hund h = new Hund();
            h.Navn = "Fido";
            h.SkalTisse += (s, e) => {
                Hund hund = s as Hund;
                Console.WriteLine(hund.Navn +" skal Tisse"); };
            h.SkalTisse += (s, e) => { Console.WriteLine("Jeg vil UUUDDD "); };
            h.SkalTisse2 += (s, e) => {
                Hund hund = s as Hund;
                Console.WriteLine(hund.Navn + " skal Tisse på niveau "+ e.Niveau);
            };

            h.Test();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }


            return;

            #region test
            /*
            System.Timers.Timer tt = new System.Timers.Timer();
            tt.Enabled = true;
            tt.Interval = 1000;
            tt.Elapsed += (s, e) => { Console.WriteLine("Tick"); };


            do { } while (true);

            //Console.ReadKey();


            System.IO.FileSystemWatcher fw = new System.IO.FileSystemWatcher(@"c:\temp");
            fw.EnableRaisingEvents = true;

            fw.Created += Fw_Created;
            fw.Deleted += delegate (object sender, System.IO.FileSystemEventArgs e) { Console.WriteLine("Fil slettet"); };

            fw.Changed += (s, e) => { Console.WriteLine("Fil ændret"); };



            MinDelegate m1 = Test1; // new MinDelegate(Test1);
            // kan afvikles på begge måde
            Test1();
            m1.Invoke();
            m1();

            //MinDelegate2 m2 = new MinDelegate2(Test2);
            MinDelegate2 m2 = Test2; // syntakssukker
            bool res1 = Test2(3);
            bool res2 = m2.Invoke(233);
            res2 = m2(45); // syntakssukker

            MinDelegate3 m3 = Test3;
            double g = m3(3,6);

            MinDelegate4 m4 = Console.WriteLine;
            m4 += Test4;
            m4("Hfjkld");

            Action p1 = Test1;
            Action<string> p2 = Console.WriteLine;
            Action<string, object> p3 = Console.Write;

            Func<int, int, int> p4 = Test5;
            Func<double, double, double> p5 = Math.Atan2; // Find noget, der passer

            Action<string> p6 = Test4;
            p6 += Console.WriteLine;
            p6 += delegate (string txt) { Console.WriteLine("I min anonyme funktion" + txt); };
            p6 += delegate (string t) { System.IO.File.WriteAllText(@"c:\temp\t.txt", t); };
            p6 += (string t) => { System.IO.File.WriteAllText(@"c:\temp\t2.txt", t); };
            p6 += t => { System.IO.File.WriteAllText(@"c:\temp\t3.txt", t); };
            p6("ffgg");

            Action<string, string> p7 = (p, c) => { System.IO.File.WriteAllText(p, c); };
            p7(@"c:\temp\t4.txt", "flkgæsjglksgjlkfæjgæls");


            int[] a = { 2, 3, 76, 45, 7, 5, 77 };
            var b = Array.FindAll(a, type => type < 10);
*/

 #endregion
        }


        class Dice
        {
            public int Value { get; set; }
            // Gør den færdig en anden dag
        }


        private static void Fw_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Fil oprettet: "+ e.FullPath);
        }

        static double Test3(double a, double b)
        {
            Console.WriteLine("Test3");
            return a + b;
        }
        static bool Test2(int a)
        {
            Console.WriteLine(a);
            return true;
        }

        static int Test5(int a, int b)
        {
            Console.WriteLine(a);
            return a+b;
        }

        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static void Test4(string s)
        {
            Console.WriteLine("*****"+s);
        }

    }
}
