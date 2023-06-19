using System.Diagnostics;

namespace BalancedBrackets.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test09()
        {
            var testInput = System.IO.File.ReadLines("input09.txt").ToArray();
            var testOutput = System.IO.File.ReadLines("output09.txt").ToArray();
            for (var i = 0; i < Convert.ToInt32(testInput.First()); i++)
            {
                Debug.WriteLine(i);
                Assert.AreEqual(testOutput[i], Result.isBalanced(testInput[i + 1]), $"line:{i}");
            }
        }
    }
}