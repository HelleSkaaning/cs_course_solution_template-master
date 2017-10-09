namespace Module09_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {







            //Dyr d = new Dyr();
            //try
            //{
            //    Dyr d = null;
            //    System.Console.WriteLine(d.ToString());

            //}
            //catch (System.NullReferenceException ex)
            //{
            //    System.Console.WriteLine(ex.Message);
            //}
            //catch (System.Exception ex)
            //{
            //    // log
            //    //redeirect
            //    System.Console.WriteLine(ex.Message);
            //}

            try
            {
                // Log
                // redirect
                F1();

            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    System.Console.WriteLine(ex.InnerException.Message);
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void F1()
        {
            F2();
        }

        static void F2()
        {
            F3();
        }

        static void F3()
        {
            Dyr d = null;
            System.Console.WriteLine(d.ToString());

        }

        class Dyr
        {

        }
    }
}
