using System;
using System.Net.Http.Headers;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            while (!isEven(number))
            {
                number += 20;
            }

            Console.WriteLine(number);






            static bool isEven(int number)
            {
                for (int i = 1; i < 21; i++)
                { 
                    if (number%i != 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}