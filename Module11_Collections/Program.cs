using System;

namespace Module11_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Tandbørste t = new Tandbørste();
            t.Stop();
            t.id = 2;


            Turbine u = new Turbine();
            u.Stop();
            u.FyldBenzinPå();

            System.Console.WriteLine();

            IMaskine[] maskiner = new IMaskine[2];
            maskiner[0] = new Tandbørste();
            maskiner[1] = new Turbine();

            foreach (var item in maskiner)
            {
                System.Console.WriteLine(item.Fejlkode());
            }

            ICrud[] m = new ICrud[2];
            m[0] = new Tandbørste();
            m[1] = new Turbine();

            foreach (var item in m)
            {
                System.Console.WriteLine(item.ToString()); // så må man ikke længere bruge medlemmerne for tandbørst for nu er det icrud
            }

            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Navn = "A", Alder = 4 };
            hunde[1] = new Hund() { Navn = "B", Alder = 2 };
            hunde[2] = new Hund() { Navn = "C", Alder = 8 };

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

            // nedlæg hunde;
            hunde[2].Dispose();


            using (Hund h = new Hund())
            {
                Console.WriteLine(h.Navn);

            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

    }

    public class Hund: IComparable, IDisposable

    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public Hund()
        {
            Console.WriteLine("Jeg bliver født");
        }

        ~Hund() // destructor bruges ikke så meget
        {
            Console.WriteLine("Jeg dør");
        }

        public void Dispose()
        {
            Console.WriteLine("Jeg rydder op inden jeg dør");
        }

        public int CompareTo(object obj)
        {
            Hund h1 = this;
            Hund h2 = obj as Hund;

            if (h1.Alder < h2.Alder)
            {
                return -1;
            }
            else if (h1.Alder >h2.Alder)
            {
                return 1;
            }
            return 0;
        }
    }

    interface ICrud
    {
        IMaskine Opret();
        void Gem(IMaskine m);
    }


    interface IMaskine
    {
        void Stop();
        int Fejlkode();
        int StopMaskine(int StatusKode);

    }

    class Tandbørste : IMaskine, ICrud
    {
        public int id { get; set; }

        public int Fejlkode()
        {
            //throw new System.NotImplementedException();
            return 2;
        }

        public void Gem(IMaskine m)
        {
            //Gemmer noget
            //throw new System.NotImplementedException();
        }

        public IMaskine Opret()
        {
            return new Tandbørste();
        }

        public void Stop()
        {
            //throw new System.NotImplementedException();
            System.Console.WriteLine("Jeg stopper");
        }

        public int StopMaskine(int StatusKode)
        {
            //throw new System.NotImplementedException();
            return StatusKode + 1;
        }
    }

    class Turbine : IMaskine, ICrud
    {
        public void FyldBenzinPå()
        {
        }
            
        public int Fejlkode()
        {
            return 99;
        }

        public void Stop()
        {
            System.Console.WriteLine("Stort maskinstop");
        }

        public int StopMaskine(int StatusKode)
        {
            return StatusKode + 100;
        }

        public IMaskine Opret()
        {
            // throw new System.NotImplementedException();
            return new Turbine();
        }

        public void Gem(IMaskine m)
        {
            //throw new System.NotImplementedException();
            // Do something
        }
    }

}
