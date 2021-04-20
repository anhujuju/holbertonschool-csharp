using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5];

        matrix[2, 2] = 1;

        for (int y = 0; y < matrix.GetLength(0); y++)
        {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                Console.Write(matrix[y, x]);

                if (x < matrix.GetLength(0) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
