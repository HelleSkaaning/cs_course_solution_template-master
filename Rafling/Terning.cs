using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafling
{
    class Terning
    {
        public int værdi;  // så må man ikke skrive til den
        private bool snyd;
        
        public Terning() : this(false)
        {
        }

        public Terning(bool startsnyd)
        {
            this.værdi = 1;
            this.snyd = startsnyd;
        }

        private static Random rnd = new Random();

        /// <summary>
        /// Skriver Terningen ud til console
        /// </summary>
        public void Skriv()
        {

            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            //if (this.snyd == false)
            //    this.værdi = rnd.Next(1, 7);
            //else
            //    this.værdi = 6;

            if (this.snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);

        }

        //public int HentVærdi() //getter
        //{
        //    // log
        //    //sikkerhed
        //    return this.værdi;
        //}

        //public void GemVærdi(int værdi) //setter
        //{
        //    // log
        //    //sikkerhed
        //    // validering
        //    if (værdi < 1 || værdi > 6)
        //        værdi = 1;

        //    this.værdi = værdi;
        //}

    }
}
