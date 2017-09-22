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

            public bool ValiderCpr() { return true}

            public void Print()
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

        }

        class Intruktør : Person
        {
            public int Nøgle { get; set; }
            public void KørLøn()
            {

            }

        }

        sealed class HjælpeInstruktør : Intruktør
        {
            public int MidlertidigNøgle { get; set; }
            public void FindKlasser()
            {

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
