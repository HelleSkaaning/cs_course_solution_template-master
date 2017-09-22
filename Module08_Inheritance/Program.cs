namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Person o1 = new Person() { Navn = "Person xxx" };
            o1.Print();

            Student o2 = new Student() { Navn = "Student YYYY", StudentId = 1};
            o2.Print();

            Intruktør o3 = new Intruktør() { Navn = "Intstruktør zz", Nøgle = 12 };
            o3.Print();
            o3.KørLøn();

            HjælpeInstruktør o4 = new HjælpeInstruktør() { Navn = "Hjælpeintr dd", Nøgle = 10 };
            o4.Print();
            o4.KørLøn();
            o4.FindKlasser();
            o4.ValiderCpr();


            //Person o5 = new HjælpeInstruktør() { Navn = "navn tyt", MidlertidigNøgle=10 };
            //o5.Print();
            //// NOT o5.FindKlasser();

            //HjælpeInstruktør o6 = o5 as HjælpeInstruktør;

            //System.Object d = new object();
            //d.ToString();

            Person[] personer = new Person[4];
            personer[0] = o1;
            personer[1] = o2;
            personer[2] = o3;
            personer[3] = o4;

            foreach (var item in personer)
            {
                item.Print();
            }
            
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        class Hund
        {

        }

        class Person
        {
            public string Navn { get; set; }

            public string CPR { get; set; }

            public bool ValiderCpr() { return true; }

            public virtual void Print()
            {
                System.Console.WriteLine("Jeg er en person og hedder "+this.Navn);
            }

        }

        class Student : Person
        {
            public int StudentId { get; set; }
            public void BookEksamen()
            {

            }

            public override void Print()
            {
                System.Console.WriteLine("Jeg er en student og hedder " + this.Navn);
            }



        }

        class Intruktør : Person
        {
            public int Nøgle { get; set; }
            public void KørLøn()
            {

            }

            public override void Print()
            {
                System.Console.WriteLine("Jeg er en Intruktør og hedder " + this.Navn + "Med nøgleid: "+Nøgle);
            }


        }

        sealed class HjælpeInstruktør : Intruktør
        {
            public int MidlertidigNøgle { get; set; }
            public void FindKlasser()
            {

            }

            public override void Print()
            {
                System.Console.WriteLine("Jeg er en underinstruktør og hedder " + this.Navn+ "med midlertidig nøgle "+MidlertidigNøgle);
            }

        }

        // class A: HjælpeInstruktør { }
        // fx system er låst fra Ms side, så man ikke kan nedarve fra system.XX

        // Man kan nedaarve nogle ting fra system, fx random generator
        class MinRandom : System.Random
        {
            public int NyRandommetode()
            {
                return this.Next(1,400);

            }
        }


    }
}
