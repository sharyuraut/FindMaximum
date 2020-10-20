using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMaximumWithGenerics
{
    [TestClass]
    public class MaxValueTest
    {
        /// <summary>
        /// Givens the integer array should return largest integer.
        /// </summary>
        [TestMethod]
        public void GivenIntegerArray_ShouldReturnLargestInteger()
        {
            int[] values = { 3, 6, 7, 10, 4, 8 };
            MaxValue<int> maximumNumber = new MaxValue<int>(values);

            int max = maximumNumber.GetMaximum();

            Assert.AreEqual(10, max);
        }
        /// <summary>
        /// Givens the double array should return largest double.
        /// </summary>
        [TestMethod]
        public void GivenDoubleArray_ShouldReturnLargestDouble()
        {
            double[] values = { 10.6, 25.9, 8.2, 9.56, 20.8, 6.9, 21.5 };
            MaxValue<double> maximumNumber = new MaxValue<double>(values);

            double max = maximumNumber.GetMaximum();

            Assert.AreEqual(25.9, max);
        }
        /// <summary>
        /// Givens the string array should return largest string.
        /// </summary>
        [TestMethod]
        public void GivenStringArrayShouldReturnLargestString()
        {
            string[] values = { "222", "498", "999", "333", "777", "888" };
            MaxValue<string> maximumNumber = new MaxValue<string>(values);

            string max = maximumNumber.GetMaximum();

            Assert.AreEqual("999", max);
        }


    }
}
