using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arealberegner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ArealBeregn.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregn.BeregnArealCirkel(10));
            Console.ReadKey();
        }
    }
}
