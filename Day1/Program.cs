using System;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part one
            int largerMeasurements = 0;
            string[] input = File.ReadAllLines(@"..\..\..\input.txt");
            for (int i = 1; i < input.Length; i++)
            {
                if (int.Parse(input[i - 1]) < int.Parse(input[i]))
                {
                    largerMeasurements++;
                }
            }
            Console.WriteLine("Amount of larger measurements: " + largerMeasurements);

            //Part two
            int largerSums = 0;
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    int sumA = int.Parse(input[i]) + int.Parse(input[i + 1]) + int.Parse(input[i + 2]);
                    int sumB = int.Parse(input[i + 1]) + int.Parse(input[i + 2]) + int.Parse(input[i + 3]);
                    if (sumA < sumB)
                    {
                        largerSums++;
                    }
                }
                catch (Exception e)
                {
                    break;
                }
            }
            Console.WriteLine("Amount of larger sums: " + largerSums);
        }
    }
}