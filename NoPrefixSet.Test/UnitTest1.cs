namespace NoPrefixSet.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test33()
        {
            var words = System.IO.File.ReadLines("input33.txt").Skip(1).ToList();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Result.noPrefix(words);
            var expected = string.Join(Environment.NewLine, File.ReadAllLines("output33.txt")) + Environment.NewLine;
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void test40()
        {
            var words = System.IO.File.ReadLines("input40.txt").Skip(1).ToList();
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Result.noPrefix(words);
            var expected = string.Join(Environment.NewLine, File.ReadAllLines("output40.txt")) + Environment.NewLine;
            Assert.AreEqual(expected, sw.ToString());
        }
    }
}