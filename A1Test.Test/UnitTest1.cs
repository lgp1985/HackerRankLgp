namespace A1Test.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            _ = System.IO.File.ReadLines("input.txt").Skip(1).ToList();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Result.plusMinus(null!);
            var expected = string.Join(Environment.NewLine, File.ReadAllLines("output.txt")) + Environment.NewLine;
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}