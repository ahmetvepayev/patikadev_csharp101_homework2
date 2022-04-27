using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 20 numeric values. Press Enter after each entry:");
            decimal input;
            int i = 0, take = 3;
            decimal[] numbers = new decimal[20];
            decimal startSum = 0, endSum = 0;
            
            while (i < 20)
            {
                if (decimal.TryParse(Console.ReadLine(), out input))
                {
                    numbers[i] = input;
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter only numeric values");
                    continue;
                }

                i++;
            }

            Array.Sort(numbers);

            for (i = 0; i < take && i < numbers.Length; i++)
            {
                startSum += numbers[i];
                endSum += numbers[numbers.Length - 1 - i];
            }

            Console.WriteLine("\nAverage of the first {0} numbers in the sorted array: {1}", take, (startSum/take).ToString("N3"));
            
            Console.WriteLine("\nAverage of the last {0} numbers in the sorted array: {1}", take, (endSum/take).ToString("N3"));

            Console.WriteLine("\nSum of the averages: {0}", ((startSum + endSum)/take).ToString("N3"));
        }
    }
}
