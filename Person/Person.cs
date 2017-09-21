using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person() : this("","",2000)
        {

        }

        public Person(string Fornavn, string Efternavn, int Fødselsår)
        {
            this.Fornavn = Fornavn.ToUpper();
            this.Efternavn = Efternavn.ToUpper();
            this.Fødselsår = Fødselsår;

        }

        public string FuldtNavn()
        {
            // return this.Fornavn + " " + this.Efternavn;
            return $"{Fornavn} {Efternavn}";
        }

        public int Alder()
        {
            return System.DateTime.Now.Year - this.Fødselsår;
        }
    }
}
