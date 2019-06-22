namespace PascalTriangleRecursively
{
    public class Triangle
    {
        const int INT2 = 2;

        public int[][] GenerateLastTriangleRow(int[][] triangle, int row)
        {
            int[][] newTriangle = new int[row][];
            for (int i = 0; i < row - 1; i++)
            {
                if (triangle == null || triangle.Length == 0)
                {
                    return null;
                }

                newTriangle[i] = triangle[i];
            }

            newTriangle[row - 1] = new int[row];
            newTriangle[row - 1][0] = 1;
            newTriangle[row - 1][row - 1] = 1;

            for (int i = 1; i < row - 1; i++)
            {
                newTriangle[row - 1][i] = newTriangle[row - INT2][i] + newTriangle[row - INT2][i - 1];
            }

            return newTriangle;
        }

        public int[][] PascalTriangleRow(int row)
        {
            var triangle = new int[row][];
            if (row == 1)
            {
                triangle[0] = new[] { 1 };
                return triangle;
            }

            triangle = PascalTriangleRow(row - 1);

            return GenerateLastTriangleRow(triangle, row);
        }
    }
}
