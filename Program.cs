using System;

namespace GivesTriPerfect
{
    class Program
    {
        public static void FindTriPerfect(double x)
        {
           
            for (int i = 1; i < x; i++)
            {
                double factorSum = 0;
                for(int j = 1; j <= x/2; j++)
                {
                    if (i % j == 0)
                    {
                        factorSum += j;
                    }
                }
                if (factorSum == i *3)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            FindTriPerfect(1000000);
            Console.WriteLine("Hello World!");
        }
    }
}
