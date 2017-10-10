namespace Module13_Avanced
{
    class Program
    {
        static void Main(string[] args)
        {

            int? i = 6;
            int? y = null; // nu ligger den på stakken. Så kan man have noget, der er defineret men ikke tildelt en værdi

            int? alder = null;
            //bool AlderIsSet = false;
            if (alder.HasValue)
            {
                System.Console.WriteLine(alder);
            }
            else
            {

            }

            int? j = null;
            int l = i.Value + (j ?? 42);

            System.Console.WriteLine(StringHelper.Fancyformat("mathias"));
            string navn = "jonas";
            System.Console.WriteLine(navn.Fancyformat());

            var ty = new
            {
                navn = "mikkel",
                alder = 14
            };
            System.Console.WriteLine(ty.navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }

    static class StringHelper
    {
        public static string Fancyformat(this string t)
        {
            return t.Substring(0, 1).ToUpper() + t.Substring(1).ToLower();
        }
    }


}
