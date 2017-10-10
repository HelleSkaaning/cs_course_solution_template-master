using System;
using System.Collections.Generic;

namespace Module11_Collections
{
    class Program

    {

        //private static double Momspct = 0.25;

        static void Main(string[] args)
        {
            // så kan man spørge på argumenter til programmet
            if (args.Length > 0)
            {
                foreach (var item in args)
                {
                    System.Console.WriteLine(item);
                };
            };
          
            // Så kan man hente i konfigurationsfilen
            //modul+add+reference: system.coonfiguration
            string m = System.Configuration.ConfigurationManager.AppSettings["moms"];
            double moms = 0;
            if (m != null)
            {
                moms = Convert.ToDouble(m);
            }

            //Eller bruge program properties + settings. 
            //kan bruges som en mini dattabase.
            string x = Module11_Collections.Properties.Settings.Default.Xpos;
                

            System.Collections.ArrayList lst1 = new System.Collections.ArrayList();
            lst1.Add(1);
            lst1.Add(2);

            lst1.Remove(1);

            System.Collections.ArrayList lst2 = new System.Collections.ArrayList();
            lst2.Add(new Hund() { Navn = "a" });
            lst2.Add(new Hund() { Navn = "b" });

            lst2.Remove(1);

            System.Collections.Stack lst3 = new System.Collections.Stack();
            lst3.Push(1);
            lst3.Push(2);
            lst3.Push(133);

            System.Collections.Queue lst4 = new System.Collections.Queue();
            lst4.Enqueue(new Hund() { Navn = "A"});
            lst4.Enqueue(new Hund() { Navn = "B" });
            lst4.Enqueue(new Hund() { Navn = "C" });
            Hund h = (Hund)lst4.Dequeue();

            System.Collections.Hashtable lst5 = new System.Collections.Hashtable();
            lst5.Add("a","a");
            lst5.Add("b", "a");
            lst5.Add("c", "a");
            string r = lst5["b"].ToString();


            Kennel kennel = new Kennel();
            kennel.TilføjHund(h);

            //////////////////
            System.Collections.Generic.List<Hund> lst6 = new System.Collections.Generic.List<Hund>();
            lst6.Add(new Hund() { Navn = "a"});
            lst6.Add(new Hund() { Navn = "b" });

            Hund hh = lst6[0];

            Queue<int> lst7 = new Queue<int>();
            lst7.Enqueue(5);
            int ii = lst7.Dequeue();

            Dictionary<int, Hund> lst8 = new Dictionary<int, Hund>();
            lst8.Add(4, new Hund() { Navn = "b"});
            lst8.Add(22, new Hund() { Navn = "g"});
            Hund hhh = lst8[4];

            List<string> lst9 = new List<string>();
            lst9.Add("A1");
            lst9.Add("B1");
            lst9.Add("E1");
            lst9.Add("C1");
            
            foreach (var item in lst9)
            {
                System.Console.WriteLine(item);
            }

            for (int i = 0; i < lst9.Count; i++)
            {
                System.Console.WriteLine(lst9[i].ToString());
            }


            //Test<MinType> t1 = new Test<MinType>();


            Kennel2 k2 = new Kennel2();
            //k2.Add(new Hund);
            //k2.Add(Hund );



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        class Test<MinType>
        {
            private MinType x;
            private MinType y;

        }

        class Kennel2 : List<Hund>
        {

        }


        // Collection klasse
        class Kennel
        {
            private System.Collections.ArrayList lst = new System.Collections.ArrayList();

            public void TilføjHund (Hund h) // Nu er den lavet type stærk
            {
                lst.Add(h);
            }


        }

        class Hund
        {
            public string Navn { get; set; }
        }
    }
}


