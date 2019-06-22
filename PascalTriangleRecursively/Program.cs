using System;

namespace PascalTriangleRecursively
{
    public class Program
    {
        public static void Main()
        {
            var pascal = new Triangle();
            Print(pascal.PascalTriangleRow(Convert.ToInt32(Console.ReadLine())));
            Console.ReadLine();
        }

        public static void Print(int[][] triangle)
        {
            if (triangle == null)
            {
                return;
            }

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
