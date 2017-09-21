using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vareclass
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.Navn = "Cykel1";
            v.Pris = 1001;

            Console.WriteLine(v.Navn+" koster med moms "+v.PrisMedMoms());
            Console.WriteLine();


            Vare v2 = new Vare("Barnevogn",2000);
            Console.WriteLine(v2.Navn + " koster med moms " + v2.PrisMedMoms());
            Console.WriteLine();


            Console.ReadKey();
        }
    }

    class Vare
    {
        public Vare(): this("",0.0)
        {

        }

        public Vare(string Navn, double Pris)
        {
            this.navn = Navn;
            this.pris = Pris;
        }

        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Nu hentes navn");
                return navn; }
            set {
                Console.WriteLine("Nu sættes navn");
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu hentes pris");
                return pris; }
            set {
                Console.WriteLine("Nu sættes pris");
                pris = value; }
        }

        public double PrisMedMoms()
        {
          return pris * 1.25;
        }



    }

}
