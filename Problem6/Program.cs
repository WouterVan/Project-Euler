using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareNumber = 0;
            var number = 0;
            for (int i = 1; i < 101; i++)
            {
                number += i * i;
                squareNumber += i;
            }
            
            Console.WriteLine((squareNumber * squareNumber) - number);
        }
    }
}