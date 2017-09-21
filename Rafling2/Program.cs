using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafling2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Terning 1:");
            //Terning t1 = new Terning();
            //t1.Skriv();
            //t1.Ryst();
            //t1.Skriv();
            //t1.Værdi = 7;
            //t1.Skriv();

            //Console.WriteLine("Terning 2:");
            ////            Terning t2 = new Terning(false);
            //Terning t2 = new Terning(4);
            //t2.Skriv();
            //t2.Ryst();
            //t2.Skriv();
            //t2.Ryst();
            //t2.Skriv();
            //t2.Ryst();
            //t2.Skriv();
            //t2.Ryst();
            //t2.Skriv();

            YatzyBæger y = new YatzyBæger();
            y.Skriv();
            y.Ryst();
            y.Skriv();
            y.Ryst();
            y.Skriv();
            y.Ryst();
            y.Skriv();
            y.Ryst();
            y.Skriv();
            y.Ryst();
            y.Skriv();

            Console.ReadKey();
        }
    }

    class Terning
    {
        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }

        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                if (value < 1 || value > 6)
                    value = 1;
                værdi = value; }
        }

        private static Random rnd = new Random();

        public void Ryst()
        {
           this.værdi = rnd.Next(1, 7);

        }

        public void Skriv()
        {
           Console.Write("[" + this.værdi + "] ");
        }

    }

    class YatzyBæger
    {
        private Terning[] terninger;

        public YatzyBæger()
        {
            terninger = new Terning[5];
           
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
        }

        public void Ryst()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    terninger[i].Ryst();
            //}

            foreach (var item in this.terninger)
                item.Ryst();
        }

        public void Skriv()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("["+terninger[i].Værdi+ "] ");
            //}
            //Console.WriteLine();
            foreach (var item in this.terninger)
            {
                item.Skriv();
            }
            Console.WriteLine();
        }


    }
}
