using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());



            Console.ReadKey();
        }
    }


    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {

            //Random r = new Random();
            //int n = r.Next(1, 1002);

            //if (n <= 500)
            //    return true;
            //else 
            //    return false;

            return this.Next(1, 1002) < 500;
        } 
    }
}
