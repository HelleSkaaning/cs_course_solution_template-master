using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_OOP
{
    class Vare
    {
        public static double momsPct = 0.25;


        public string Navn { get; set; }

        public decimal Pris { get; set; }

        public static Vare DanSpecialVare()
        {
            // nej! this.xxxxxx
            Vare v = new Vare();
            v.Navn = "Cykel";
            return v;
        }

    }
}
