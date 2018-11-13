using Microsoft.VisualStudio.TestTools.UnitTesting;
using teamAxceligent;

namespace TestProject
{
    [TestClass]
    public class TestMaxSum
    {
        [TestMethod]
        public void TestCase1()
        {
            var input = new int[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            var maxSum = BiggestNeighborSum.Challenge(input);
            Assert.IsTrue(maxSum == 10, $"TestMaxSum test case 1 should return 10, but it is returning {maxSum} instead");
        }
        [TestMethod]
        public void TestCase2()
        {
            var input = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            var maxSum = BiggestNeighborSum.Challenge(input);
            Assert.IsTrue(maxSum == 12, $"TestMaxSum test case 2 should return 12, but it is returning {maxSum} instead");
        }
        [TestMethod]
        public void TestCase3()
        {
            var input = new int[1000];
            for (int i = 0; i < 1000;i++)
            {
                input[i] = i % 100;
            }
            var maxSum = BiggestNeighborSum.Challenge(input);
            Assert.IsTrue(maxSum == 197, $"TestMaxSum test case 3 should return 197, but it is returning {maxSum} instead");
        }

    }

}
