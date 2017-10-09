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


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
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
