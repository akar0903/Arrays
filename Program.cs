using System;
class MatrixDemo
{
    public static void Main(string[] args)
    {
        int i = 0;
        int j = 0;
        int sum = 0;
        int row = 2;
        int col = 2;
        int[,] Matrix = new int[row, col];
        Console.Write("Enter the elements of matrix: ");
        for (i = 0; i < row; i++)
        {
            for (j = 0; j < col; j++)
            {
                Matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nMatrix: ");
        for (i = 0; i < row; i++)
        {
            for (j = 0; j < col; j++)
            {
                Console.Write(Matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        for (i = 0; i < row; i++)
        {
            sum = 0;
            for (j = 0; j < col; j++)
            {
                sum += Matrix[i, j];
            }
            Console.WriteLine("Sum of row[{0}]: {1}", (i + 1), sum);
        }
        Console.ReadLine();
    }
}
