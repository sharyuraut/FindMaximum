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
            Program maximumNumber = new Program();

            int max = Program.GetMaxInt(10, 2, -47);

            Assert.AreEqual(10, max);
        }

        //TC 1.2
        [TestMethod]
        public void GivenInteger_MaxSecondNumber_ShouldReturnSecondNumber()
        {
            Program maximumNumber = new Program();

            int max = Program.GetMaxInt(1, 5, 2);

            Assert.AreEqual(5, max);
        }

        //TC 1.3
        [TestMethod]
        public void GivenInteger_MaxThirdNumber_ShouldReturnThirdNumber()
        {
            Program maximumNumber = new Program();

            int max = Program.GetMaxInt(-11, -20, 45);

            Assert.AreEqual(45, max);
        }
    }
}
