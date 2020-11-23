using System;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 5;
            var count = 3;




            while (count < 10001)
            {
                number += 2;
                bool isPrime = true;
                for (int i = 2; i < number; i++)
                    if (number % i == 0 || number % 3 == 0)
                    {
                        isPrime = false;
                        break;
                    }

                if (isPrime)
                {
                    count++;

                }

            }

            Console.WriteLine(number);
        }
    }
}