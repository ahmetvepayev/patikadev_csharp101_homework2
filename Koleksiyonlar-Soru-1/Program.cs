using System;
using System.Collections;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 20 positive integers. Press Enter after each integer:");
            ArrayList primeArrayList = new ArrayList();
            ArrayList nonPrimeArrayList = new ArrayList();
            List<int> primes = new List<int>(){2, 3};
            int input, i = 0;
            decimal primeSum = 0, nonPrimeSum = 0;

            
            while (i < 20)
            {
                if (int.TryParse(Console.ReadLine(), out input) && input >= 0)
                {
                    if (input.IsPrime(primes))
                    {
                        primeArrayList.Add(input);
                    }
                    else
                    {
                        nonPrimeArrayList.Add(input);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter only positive integer values");
                    continue;
                }

                i++;
            }

            primeArrayList.Sort();
            primeArrayList.Reverse();
            nonPrimeArrayList.Sort();
            nonPrimeArrayList.Reverse();
            

            Console.Write("\nThere are {0} prime numbers: ", primeArrayList.Count);
            foreach (var item in primeArrayList)
            {
                primeSum += Convert.ToDecimal(item);
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nAverage: {0}", (primeSum/primeArrayList.Count).ToString("N3"));

            Console.Write("\nThere are {0} non-prime numbers: ", nonPrimeArrayList.Count);
            foreach (var item in nonPrimeArrayList)
            {
                nonPrimeSum += Convert.ToDecimal(item);
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nAverage: {0}", (nonPrimeSum/nonPrimeArrayList.Count).ToString("N3"));
        }

        
    }

    public static class ExtensionMethods
    {
        public static bool IsPrime(this int number, List<int> primes)
        {
            while (number > primes[primes.Count - 1])
            {
                primes.AddNextPrime();
            }
            return number == 1 || primes.Contains(number);
        }

        public static void AddNextPrime(this List<int> primes)
        {
            int nextPrime = primes[primes.Count - 1] + 2;

            for (int i=0; primes[i] <= nextPrime/2; i++){
                if (nextPrime%primes[i] == 0){
                    nextPrime += 2;
                    i = -1;
                }
            }

            primes.Add(nextPrime);
        }
    }
}
