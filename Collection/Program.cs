using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person > lst = new List<Person>();
            lst.Add(new Person() { Id = 12, Navn = "Helle"});
            lst.Add(new Person() { Id = 23, Navn = "Hans" });
            lst.Add(new Person() { Id = 56, Navn = "Rikke"});

            foreach (var item in lst)
            {
                Console.WriteLine(item.Navn);
            }

            Console.WriteLine();

            Dictionary<int, Person> plst = new Dictionary<int, Person>();
            plst.Add(12, new Person() { Id = 12, Navn = "Didrik"});
            plst.Add(8, new Person() { Id = 8, Navn = "Rikke" });
            plst.Add(5, new Person() { Id = 3, Navn = "Gustav" });
            plst.Add(65, new Person() { Id = 456, Navn = "Nikolaj" });

            var p = plst[5];
            Console.WriteLine(p.Navn);
            p = plst[65];
            Console.WriteLine(p.Navn);

            //Dictionary<int, Hund> lst8 = new Dictionary<int, Hund>();
            //lst8.Add(4, new Hund() { Navn = "b" });

            Console.ReadKey();
        }


        class Hund
        {
            public string Navn { get; set; }
        }

        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }

        }

    }
}
