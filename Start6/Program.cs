using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 5,1,7,12,1,5};      
            int test = 10;

            // TODO: JKLÆJDLAJLDA Det er ikke smart
            ArrayResultat r = Beregn(v, ref test);

            Console.WriteLine(r.Sum);
            Console.WriteLine(r.Gennemsnit.ToString("N2"));

            Console.ReadKey();
        }



        static ArrayResultat Beregn(int[] værdier, ref int y)
        {
            ArrayResultat resultat;
            resultat.Sum = 0;
            resultat.Gennemsnit = 0;

            // todo: klfdjgklsægjfldæs
            y = 100000;

            for (int i = 0; i < værdier.Length; i++)
            {
                resultat.Sum += værdier[i];
            }

            resultat.Gennemsnit = resultat.Sum / værdier.Length;

            værdier[0] = 10000;

            return resultat;

        }


    }


}
