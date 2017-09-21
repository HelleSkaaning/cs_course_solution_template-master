using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Default navn");
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());
            p1.Fornavn = "Helle";
            p1.Efternavn = "Skaaning";
            p1.Fødselsår = 1963;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());

            Console.WriteLine();
            Console.WriteLine();

            Person p2 = new Person("Gitte", "Karlsen", 1977);
            Console.WriteLine("Initieret navn");
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());
            p2.Fornavn = "Jytte";
            p2.Efternavn = "Mathisen";
            p2.Fødselsår = 1922;
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());
            
            Console.ReadKey();



        }
    }
}
