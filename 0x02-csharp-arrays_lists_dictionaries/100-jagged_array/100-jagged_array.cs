using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] {0, 1, 2, 3};
        jaggedArray[1] = new int[] {0, 1, 2, 3, 4, 5, 6};
        jaggedArray[2] = new int[] {0, 1};

        for (int y = 0; y < jaggedArray.Length; y++)
        {
            for (int x = 0; x < jaggedArray[y].Length; x++)
            {
                Console.Write(jaggedArray[y][x]);

                if (x < jaggedArray[y].Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
