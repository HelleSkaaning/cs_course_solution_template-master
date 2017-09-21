using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    class Program
    {
        static void Main(string[] args)
        {
            Person  p;
            p = new Person("Hanne",54,true);
            Console.WriteLine(p);

            p.navn = "Mikkel";
            p.alder = 14;
            p.erILive = true;

            Person i = new Person("Lotte", 14, true);


            //Person u = new Person(); Ulovlig fordi der skal være værdier med i new
            //u.navn = "Lene";
            //Console.WriteLine(u);

            Person w = null;

            Console.WriteLine(w);

            //u = null;
            //u = p;
            Console.WriteLine(p.navn);
            //Console.WriteLine(u.navn);
            //w = u; // Det er referencer så det er IKKE kopiering men pege på noget andet objekt
            //Console.WriteLine(w.navn);

            //w = null;
            //Console.WriteLine(w.navn);

            // Man vil gerne undgå offentlige felter altså public variable

            Console.WriteLine();
            Console.WriteLine();

            Terning t1 = new Terning();
            t1.Skriv();
            Terning t2 = new Terning(3);
            t2.Skriv();
            Terning t3 = new Terning(60);
            t3.Skriv();

            //t3.værdi = 600;

            t3.Skriv();

            Console.WriteLine("værdien er "+t3.HentVærdi());

            t3.GemVærdi(6);
            Console.WriteLine("værdien er " + t3.HentVærdi());

            t3.GemVærdi(600);
            Console.WriteLine("værdien er " + t3.HentVærdi());


            Console.ReadKey();

        }
    }
}
