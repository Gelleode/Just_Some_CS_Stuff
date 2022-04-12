using System;

namespace Just_Some_CS_Stuff
{
    class Probability
    {
        public static double A(int m, int n)
        {
            return Factorial(n)/Factorial(n-m);
        }

        public static double C(int k, int n)
        {
            return Factorial(n) / (Factorial(n-k)*Factorial(k));
        }

        public static double P(int m, int n)
        {
            return m/n;
        }

        public static int Factorial(int a)
        {
            if (a == 1 || a == 0)
                return 1;
            return Factorial(a-1)*a;
        }
    }
}
