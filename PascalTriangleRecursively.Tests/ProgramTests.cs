using Xunit;

namespace PascalTriangleRecursively.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Expect_A_PascalTriangle_Of_Five_rows()
        {
            int n = 5;
            int[][] triangle = new int[n][];
            int row = n;
            var actual = new[] { new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 3, 3, 1 }, new[] { 1, 4, 6, 4, 1 } };
            Assert.Equal(actual, Program.PascalTriangleRow(5));
        }        

        [Fact]
        public void Expect_A_PascalTriangle_Of_Ten_rows()
        {
            int n = 10;
            int[][] triangle = new int[n][];
            int row = n;
            var actual = new[] { new[] { 1 }, new[] { 1, 1 }, new[] { 1, 2, 1 }, new[] { 1, 3, 3, 1 }, new[] { 1, 4, 6, 4, 1 }, new[] { 1, 5, 10, 10, 5, 1 }, new[] { 1, 6, 15, 20, 15, 6, 1 }, new[] { 1, 7, 21, 35, 35, 21, 7, 1 }, new[] { 1, 8, 28, 56, 70, 56, 28, 8, 1 }, new[] { 1, 9, 36, 84, 126, 126, 84, 36, 9, 1 } };
            Assert.Equal(actual, Program.PascalTriangleRow(10));
        }
    }
}
