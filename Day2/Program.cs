using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hPos = 0;
            int depth = 0;
            int aim = 0;
            string[] input = File.ReadAllLines(@"..\..\..\input.txt");

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].StartsWith("forward"))
                {
                    int value = GetValue(input[i]);
                    hPos += value;
                    depth += aim * value;
                }
                if (input[i].StartsWith("down"))
                {
                    aim += GetValue(input[i]);
                }
                if (input[i].StartsWith("up"))
                {
                    aim -= GetValue(input[i]);
                }
            }

            Console.WriteLine("Horizontal position: " + hPos);
            Console.WriteLine("Depth: " + depth);
            Console.WriteLine("HPos x Depth = " + depth * hPos);
        }

        static int GetValue(string input)
        {
            int spacePos = input.IndexOf(" ");
            string valueString = input.Substring(spacePos + 1);
            return int.Parse(valueString);
        }
    }
}
