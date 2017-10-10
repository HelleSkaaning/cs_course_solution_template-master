using System;

namespace Module12_Delegates
{
    class Program
    {
        public delegate void MinDelegate();
        public delegate bool MinDelegate2(int a);
        public delegate double MinDelegate3(double a, double b);
        public delegate void MinDelegate4(string s);

        static void Main(string[] args)
        {
            MinDelegate m1 = Test1; // new MinDelegate(Test1);

            // kan afvikles på begge måde
            Test1();
            m1.Invoke();
            m1();

            //MinDelegate2 m2 = new MinDelegate2(Test2);
            MinDelegate2 m2 = Test2; // syntakssukker
            bool res1 = Test2(3);
            bool res2 = m2.Invoke(233);
            res2 = m2(45); // syntakssukker

            MinDelegate3 m3 = Test3;
            double b = m3(3,6);

            MinDelegate4 m4 = Console.WriteLine;
            m4 += Test4;
            m4("Hfjkld");
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static double Test3(double a, double b)
        {
            Console.WriteLine("Test3");
            return a + b;
        }
        static bool Test2(int a)
        {
            Console.WriteLine(a);
            return true;
        }

        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static void Test4(string s)
        {
            Console.WriteLine("*****"+s);
        }

    }
}
