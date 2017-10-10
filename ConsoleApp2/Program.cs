using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner{
    class Program
    {

        public delegate int Beregn(int a, int b);

        static void Main(string[] args)
        {

            int i = Beregner(2, 3, Plus);
            Console.WriteLine();
            Console.WriteLine(Beregner(2, 4, Plus));
            Console.WriteLine(Beregner(9, 3, Minus));
            Console.WriteLine(Beregner(2, 3, Gange));
            Console.WriteLine(Beregner(12, 2, Divider));

            Console.ReadKey();

        }

        public static int Beregner(int a, int b, Beregn f)
        {
            return f(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
