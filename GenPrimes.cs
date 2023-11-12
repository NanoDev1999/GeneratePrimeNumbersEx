using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the upper limit to generate prime numbers:");
        
        if (int.TryParse(Console.ReadLine(), out int limit))
        {
            List<int> primes = GeneratePrimes(limit);

            Console.WriteLine($"Prime numbers up to {limit}:");
            foreach (int prime in primes)
            {
                Console.Write(prime + " ");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static List<int> GeneratePrimes(int limit)
    {
        List<int> primes = new List<int>();
        bool[] isComposite = new bool[limit + 1];

        for (int i = 2; i <= limit; i++)
        {
            if (!isComposite[i])
            {
                primes.Add(i);

                for (int j = i * 2; j <= limit; j += i)
                {
                    isComposite[j] = true;
                }
            }
        }

        return primes;
    }
}
