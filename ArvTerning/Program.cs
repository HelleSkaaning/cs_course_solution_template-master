using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            Console.Write("Initielt ");
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            //Console.WriteLine();

            LudoTerning t2 = new LudoTerning(4);
            Console.Write("Initelt ");
            t2.Skriv();

            for (int i = 0; i < 10; i++)
            {
                t2.Ryst();
                t2.Skriv();

                if (t2.ErGlobus())
                {
                    Console.WriteLine("Det er en Globus");
                }
                if (t2.ErStjerne())
                {
                    Console.WriteLine("Det er en stjerne");
                }

            }

            Console.ReadKey();
        }
    }

    class Terning
    {
        private int værdi;
                
        public int Værdi
        {
            get {
                Console.WriteLine("Følgende værdi læses: " + this.værdi);
                return værdi; }
            set {
                if (value < 1 || value > 6)
                    value = 1;

                Console.WriteLine("Terning er tildelt værdi: " + value);
                værdi = value;
            }
        }

        private static Random rnd; 

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);

        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "] ");
        }


        static Terning()
        {
            rnd = new Random();
        }
        public Terning()
        {
            this.Ryst();
        }

        public Terning(int v)
        {
            this.Værdi = v;
        }
    }

    class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }


        public bool ErStjerne()
        {

            return this.Værdi == 5;
        }

        public LudoTerning(): base()
        {

        }

        public LudoTerning(int i): base(i)
        {

        }
    }

}
