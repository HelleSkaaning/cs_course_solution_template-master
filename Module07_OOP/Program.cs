namespace Module07_OOP
{
    partial class Program
    {
        static void Main(string[] args)
        {

            TerningMedMetoder t = new TerningMedMetoder();
            //t.værdi = 10; NEJ!!!!
            t.SetVærdi(15);
            System.Console.WriteLine(t.GetVærdi());


            Terning t2 = new Terning();
            t2.Værdi = 10;
            System.Console.WriteLine(t2);

            t2.Snyd = true;
            System.Console.WriteLine(t2.Snyd);


            Person p = new Person() { Navn = "x", Land = "y", Alder = 45 };



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }


    internal class Person
    {

         // Prop eller profull brug disse

        
        public string Navn { get; set; }
        //public int Alder { get; set; }



        private int alder;
                
        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }




        public string Land{ get; set; }

        public string Adress { get; private set; }

    }
}
