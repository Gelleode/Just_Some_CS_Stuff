using System;
using System.Diagnostics;

namespace Just_Some_CS_Stuff
{
    class Program
    {
        static void Main()
        {

            Stopwatch DoubleTime = new Stopwatch();
            Stopwatch DecimalTime = new Stopwatch();

            Single d = 4141;

            Console.WriteLine(d);

            DecimalTime.Start();
            decimal y = 0.1M;
            decimal reult = 10 * y;
            decimal reult2 = y + y + y + y + y + y + y + y + y + y;
            DecimalTime.Stop();

            DoubleTime.Start();
            double x = .1;
            double result = 10 * x;
            double result2 = x + x + x + x + x + x + x + x + x + x;
            DoubleTime.Stop();

            Console.WriteLine("{0} - {1}", result, result2);
            Console.WriteLine("Elapsed Time is {0} ms", DoubleTime.ElapsedTicks);
            Console.WriteLine("{0} - {1}", reult, reult2);
            Console.WriteLine("Elapsed Time is {0} ms", DecimalTime.ElapsedTicks);
            // ic2EnergyLevels.PrintEnergyLevels();
            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine(Chance(0.12, i+1).ToString("0.#######"));
        }
        public static double Chance(double chance, int amount)
        {
            return 1 - Math.Pow(1-chance, amount);
        }
    }
}