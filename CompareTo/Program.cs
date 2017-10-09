using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTo
{
    class Program
    {

        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Navn = "Rollo4", Alder = 4 };
            hunde[1] = new Hund() { Navn = "King2", Alder = 2 };
            hunde[2] = new Hund() { Navn = "Pippo8", Alder = 8 };

            foreach (var item in hunde)
            {
                System.Console.WriteLine(item.Navn);
            }

            Array.Sort(hunde);
            Console.WriteLine();

            foreach (var item in hunde)
            {
                System.Console.WriteLine(item.Navn);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        public class Hund : IComparable

        {
            public string Navn { get; set; }
            public int Alder { get; set; }

            public int CompareTo(object obj)
            {
                Hund h1 = this;
                Hund h2 = obj as Hund;

                if (h1.Alder < h2.Alder)
                {
                    return -1;
                }
                else if (h1.Alder > h2.Alder)
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}