using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            long sum = 0;
            long tempSum = 0;
            int indexOfRow = 0;
            int indexOfColumn = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int  j = 0;  j < matrix.GetLength(1) - 1;  j++)
                {
                    tempSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if(tempSum > sum)
                    {
                        indexOfRow = i;
                        indexOfColumn = j;
                        sum = tempSum;
                    }
                }
            }
            Console.WriteLine(matrix[indexOfRow, indexOfColumn] + " " + matrix[indexOfRow, indexOfColumn + 1]);
            Console.WriteLine(matrix[indexOfRow + 1, indexOfColumn] + " " + matrix[indexOfRow + 1, indexOfColumn + 1]);
            Console.WriteLine(sum);
        }
    }
}
