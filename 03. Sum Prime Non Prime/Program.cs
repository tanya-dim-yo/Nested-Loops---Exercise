using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int counter = 0;
                int currentNumber = int.Parse(input);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i <= currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    sumPrime += currentNumber;
                }
                else
                {
                    sumNonPrime += currentNumber;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}