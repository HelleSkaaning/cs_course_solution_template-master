using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] i = new IDbFunktioner[4];
            i[0] = new Hund();
            i[1] = new Ubåd();
            i[2] = new Hund();
            i[3] = new Ubåd();

            foreach (var item in i)
            {
                item.Gem();
            }
 

            Console.ReadKey();
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }



    class Hund: IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund");
        }
    }

    class Ubåd: IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd");
        }
    }

}
