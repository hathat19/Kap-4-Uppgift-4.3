using System;
namespace Uppgift4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=100; i++) 
            {
                if (i % 3 == 0 && i % 5 == 0) //delbart med 3 och 5?
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0) //delbart med 5?
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0) //Delbart med 3?
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}