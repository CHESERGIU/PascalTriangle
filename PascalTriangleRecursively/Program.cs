using System;

namespace PascalTriangleRecursively
{
    public class Program
    {
        public static void Main()
        {
            Print(PascalTriangleRow(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }

        public static int[][] PascalTriangleRow(int row)
        {
            var triangle = new int[row][];
            switch (row)
            {
                case 1:                    
                    triangle[0] = new int[] { 1 };
                    return triangle;
                default:
                    triangle = PascalTriangleRow(row - 1);
                    break;
            }

            return GenerateLastTriangleRow(triangle, row);
        }

        private static int[][] GenerateLastTriangleRow(int[][] triangle, int row)
        {
            
            int[][] newTriangle = new int[row][];
            for (int i = 0; i < row - 1; i++)
            {
                newTriangle[i] = triangle[i];
            }

            newTriangle[row - 1] = new int[row];
            newTriangle[row - 1][0] = 1;
            newTriangle[row - 1][row - 1] = 1;

            for (int i = 1; i < row - 1; i++)
            {
                newTriangle[row - 1][i] = newTriangle[row - 2][i] + newTriangle[row - 2][i - 1];
            }
            return newTriangle;
        }

        public static void Print(int[][] triangle)
        {
            for (int row = 0; row < triangle.GetLength(0); row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(triangle[row][col] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
