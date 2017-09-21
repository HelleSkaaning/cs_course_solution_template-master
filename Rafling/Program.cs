using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terning 1:");
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Console.WriteLine("Terning 2:");
//            Terning t2 = new Terning(false);
            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Console.ReadKey();
        }


    }
}
