using System;
using System.Linq;

namespace _3._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            var sizes = new int[3];
            foreach (var number in numbers)
            {
                sizes[Math.Abs(number % 3)]++;
            }
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[sizes[0]];
            jaggedArray[1] = new int[sizes[1]];
            jaggedArray[2] = new int[sizes[2]];

            int currentIndex0 = 0;
            int currentIndex1 = 0;
            int currentIndex2 = 0;

            foreach (var number in numbers)
            {
                if(Math.Abs(number%3) == 0)
                {
                    jaggedArray[0][currentIndex0] = number;
                    currentIndex0++;
                }
                else if (Math.Abs(number % 3) == 1)
                {
                    jaggedArray[1][currentIndex1] = number;
                    currentIndex1++;
                }
                else if (Math.Abs(number % 3) == 2)
                {
                    jaggedArray[2][currentIndex2] = number;
                    currentIndex2++;
                }

            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
