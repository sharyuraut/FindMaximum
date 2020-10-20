using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMaximumWithGenerics
{
    [TestClass]
    public class MaxValueTest
    {
        //TC 1.1
        [TestMethod]
        public void GivenInteger_MaxFirstNumber_ShouldReturnFirstNumber()
        {
            Program Program = new Program();

            int max = Program.GetMaxInt(10, 2, -47);

            Assert.AreEqual(10, max);
        }

        //TC 1.2
        [TestMethod]
        public void GivenInteger_MaxSecondNumber_ShouldReturnSecondNumber()
        {
            Program Program = new Program();

            int max = Program.GetMaxInt(1, 5, 2);

            Assert.AreEqual(5, max);
        }

        //TC 1.3
        [TestMethod]
        public void GivenInteger_MaxThirdNumber_ShouldReturnThirdNumber()
        {
            Program Program = new Program();

            int max = Program.GetMaxInt(-11, -20, 45);

            Assert.AreEqual(45, max);
        }

        //TC 2.1
        [TestMethod]
        public void GivenDouble_MaxFirstNumber_ShouldReturnFirstNumber()
        {
            double max = Program.GetMaxFloat(30.5, 12.9, 18.6);
            Assert.AreEqual(30.5, max);
        }

        //TC 2.2
        [TestMethod]
        public void GivenDouble_MaxSecondNumber_ShouldReturnSecondNumber()
        {
            double max = Program.GetMaxFloat(16.5, 50.8, 24.9);
            Assert.AreEqual(50.8, max);
        }

        //TC 2.3
        [TestMethod]
        public void GivenDouble_MaxThirdNumber_ShouldReturnThirdNumber()
        {
            double max = Program.GetMaxFloat(15.9, 20.2, 45.5);
            Assert.AreEqual(45.5, max);
        }

        //TC 3.1
        [TestMethod]
        public void GivenString_MaxFirstString_ShouldReturnFirstString()
        {
            string max = Program.GetMaxString("88.8", "55.99", "-111");
            Assert.AreEqual("88.8", max);
        }

        //TC 3.2
        [TestMethod]
        public void GivenString_MaxSecondString_ShouldReturnSecondString()
        {
            string max = Program.GetMaxString("2.22", "99", "55");
            Assert.AreEqual("99", max);
        }

        //TC 3.3
        [TestMethod]
        public void GivenString_MaxThirdString_ShouldReturnThirdString()
        {
            string max = Program.GetMaxString("4.44", "33.3", "99.99");
            Assert.AreEqual("99.99", max);
        }
    }
}
