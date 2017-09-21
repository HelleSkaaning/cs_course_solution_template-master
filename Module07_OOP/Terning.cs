namespace Module07_OOP
{
    partial class Program
    {
        class Terning
        {
            private int værdi;

            public int Værdi
            {
                get {
                    return this.værdi;
                }
                set {
                    if (value < 1 || value > 6)
                        value = 1;

                    this.værdi = value;
                }
            }


            private bool _snyd; // Man kan bruge _ for at adskille de to privat og offentlig
            
            public bool Snyd
            {
                get { return _snyd; }
                set { _snyd = value; }
                // eller private set{ _snyd = value}
            }

            public string Name { get; set; } // så er det rent og der er stadig beskyttelse, hvis man senere får brug for det.


        }
    }
}
