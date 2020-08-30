using System;
namespace Crash1
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            int i;
            double d = 4344.44;
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();

        }
    }
}