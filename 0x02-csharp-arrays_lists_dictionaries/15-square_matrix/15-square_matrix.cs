using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        if (myMatrix == null)
            return null;

        for (int y = 0; y < myMatrix.GetLength(0); y++)
        {
            for (int x = 0; x < myMatrix.GetLength(1); x++)
            {
                myMatrix[y, x] = (int)Math.Pow(myMatrix[y, x], 2);
            }
        }

        return myMatrix;
    }
}
