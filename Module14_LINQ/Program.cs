using System;
using System.Collections.Generic;
using System.Linq; // husk denne her, den er vigtig ved LINQ requests.


namespace Module14_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>();
            lst1.Add(1);
            lst1.Add(5);
            lst1.Add(6);
            lst1.Add(66);
            lst1.Add(33);
            lst1.Add(789);
            lst1.Add(2);
            lst1.Add(7);

            var r1 = from i in lst1 where i > 4 select i;
            //List<int> r1 = (from i in lst1 where i > 4 select i).ToList();

            foreach (var item in r1)
            {
                Console.WriteLine(item);
            }

            // brug tolist eller todictionary for at køre udtryk

            var p = new PersonNuGetPackage.PersonRepositoryRandom().Get10People();
            var r2 = from person in p
                     where person.Height > 170 && person.IsHealthy
                     select person.Name;

            var r4 = from person in p
                     where person.Height > 170 && person.IsHealthy
                     orderby person.Height, person.Name
                     select new { Navn = person.Name, Højde = person.Height};

            // sql syntaks
            var r5 = from person in p
                     where person.Height > 170 && person.IsHealthy
                     select person.Name;
            // lambda syntaks
            var r6 = p.Where(i => i.Height > 170 && i.IsHealthy == true).
                       OrderBy(i => i.Height).
                       ThenBy(i => i.Name).
                       Select(i => new { Navn = i.Name, Højde = i.Height });



            foreach (var item in r2)
            {
                Console.WriteLine(item);
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
