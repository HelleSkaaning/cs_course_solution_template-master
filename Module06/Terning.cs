using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    public class Terning
    {
        private int værdi;  // så må man ikke skrive til den

        public Terning() : this(4)
        {
            //this.værdi = 4;
        }

        public Terning(int startværdi)
        {
            if (startværdi < 1 || startværdi > 6)
              this.værdi = 1;
            else
              this.værdi = startværdi;
        }

        /// <summary>
        /// Skriver Terningen ud til console
        /// </summary>
        public void Skriv()
        {

            Console.WriteLine("[" + this.værdi + "]");
        }

        public int HentVærdi() //getter
        {
            // log
            //sikkerhed
            return this.værdi;
        }

        public void GemVærdi(int værdi) //setter
        {
            // log
            //sikkerhed
            // validering
            if (værdi < 1 || værdi > 6)
                værdi = 1;
            
            this.værdi = værdi;
        }

    }
}
