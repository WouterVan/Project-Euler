using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 1;
            var c = 0;
            var sum = 0;
            
            while (c < 4000000)
            {
                c = a + b;
                if ((c%2) == 0 )
                {
                    sum += c;
                }
                b = a;
                a = c;
            }
            
            Console.WriteLine(sum);
        }
    }
}