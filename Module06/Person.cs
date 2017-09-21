using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    partial class Person  // eller internal for at være privat, public for at være offentlig udenfor namespace
    {
        public string navn;
        public int alder;
        public bool erILive;

        // default constructor
        // ctor+ tab +tab
        public Person() : this("",0,true)  // default constructor med default værdier
        {
        //    navn = "";
        //    erILive = false;

        }

        // custom constructor
        public Person(string navn, int alder, bool erILive)
        {
            if (alder < 0 || alder > 110)
                this.alder = 0;
            else
                this.alder = alder;

            this.navn = navn;
            this.alder = alder;
            this.erILive = erILive;
        }


    }
}
