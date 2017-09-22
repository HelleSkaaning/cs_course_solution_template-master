using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPerson
{
    class Program
    {
        static void Main(string[] args)
        {

            Person o1 = new Person() { ForNavn = "Helle", EfterNavn = "Skaaning" };
            Console.WriteLine("Person "+o1.FuldtNavn());

            Elev o2 = new Elev { ForNavn = "Thomas", EfterNavn = "Hansen" ,KlasseLokale = "a354"};
            Console.WriteLine("Elev: "+o2.FuldtNavn());

            Instruktør o3 = new Instruktør() { ForNavn = "Jytte", EfterNavn = "Ibsen", NøgleId = 200 };
            Console.WriteLine("Instruktør: "+o3.FuldtNavn());




            Console.ReadKey();
        }
    }

    class Person
    {
        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }

        public string FuldtNavn()
        {
            //return ForNavn + " " + EfterNavn;
            return $"{ForNavn} {EfterNavn}";
        }
    }

    class Elev:Person
    {
        public string KlasseLokale { get; set; }
    }


    class Instruktør:Person
    {
        public int NøgleId { get; set; }


    }

}
