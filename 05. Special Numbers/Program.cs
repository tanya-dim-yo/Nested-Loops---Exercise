using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int m = 1; m <= 9; m++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (n % m == 0 && n % k == 0 && n % j == 0 && n % i == 0)
                            {
                                Console.Write($"{m}{k}{j}{i} ");
                            }
                        }
                    }
                }
            }
        }
    }
}