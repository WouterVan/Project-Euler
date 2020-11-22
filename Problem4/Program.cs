using System;
using System.Linq;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var largestPalidrome = 0;
            
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    var number = i*j;
                    if (number.ToString() == new string(number.ToString().Reverse().ToArray()))
                    {
                        if (number > largestPalidrome)
                        {
                            largestPalidrome = number;
                        }
                    }
                }
            }
            Console.WriteLine(largestPalidrome);

        }
    }
}