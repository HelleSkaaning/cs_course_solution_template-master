using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class 

    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + ' ' + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnlille = samletNavn.ToLower();
            Console.WriteLine(navnlille);
            string navnDel = samletNavn.Substring(fornavn.Length+1,4);
            Console.WriteLine(navnDel);

            Console.WriteLine();
            Console.WriteLine();

            string[] split = samletNavn.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine("Split["+i.ToString()+"]: "+split[i]);
            }

            //System.IO.File.WriteAllText(@"c:\temp\helle.txt", samletNavn);
            System.IO.File.WriteAllText("c:\\temp\\helle.txt", samletNavn);
            Console.WriteLine("Fil oprettet og tilskrevet");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
