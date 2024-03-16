using System;

namespace Progression{

    class Program
    {
        static void Main(string[] args)
        {
            Progression pr = new Progression();
            pr.Printprogress(2);
            int n = 15;
            pr.PrintProgression(n);

            Console.WriteLine();

            GeomProgression geoml = new GeomProgression(10);
            geoml.PrintProgression(25);
        }
    }
}