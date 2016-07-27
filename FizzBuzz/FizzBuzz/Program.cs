using FizzBuzz.Library;
using System;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GETValue(i));
            }

            Console.ReadLine();
        }
    }
}
