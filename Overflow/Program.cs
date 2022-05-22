using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; // Max value of uint -> 4294967295

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}