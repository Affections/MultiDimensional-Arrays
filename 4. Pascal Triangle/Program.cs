using System;

namespace _4._Pascal_Triangle
{
    class Program
    {
        private static int triangleLength;

        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height][];
            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new long[currentHeight + 1];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentHeight] = 1;
                if(currentHeight >= 2)
                {
                    for (int width = 1; width < currentHeight; width++)
                    {
                        triangle[currentHeight][width] = triangle[currentHeight - 1][width - 1] + triangle[currentHeight - 1][width];
                    }
                }
            }
            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
