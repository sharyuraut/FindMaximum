using System;

namespace FindMaximum
{
    /// <summary>
    /// Called for finding maximum value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MaxValue<T> where T : IComparable
    {
        T[] values;
        /// <summary>
        /// Initializes a new instance of the <see cref="MaxValue{T}"/> class.
        /// </summary>
        /// <param name="values">The values.</param>
        public MaxValue(T[] values)
        {
            this.values = values;
        }
        /// <summary>
        /// Gets the maximum.
        /// </summary>
        /// <returns></returns>
        public T GetMaximum()
        {
            Array.Sort(values);
            return values[^1];
        }
        /// <summary>
        /// Prints the maximum.
        /// </summary>
        public void PrintMax()
        {
            Console.WriteLine("Maximum Value :" + GetMaximum());
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum program!");

            Console.WriteLine("------------------------");
            
            
            string[] values;
            int[] intValues = new int[100];
            Console.WriteLine("Enter integers to find maximum: ");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                intValues[i] = Convert.ToInt32(values[i]);
            }
            MaxValue<int> maxInt = new MaxValue<int>(intValues);
            maxInt.PrintMax();

            Console.WriteLine("------------------------");

            double[] doubleValues = new double[100];
            Console.WriteLine("Enter float numbers to find maximum: ");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                doubleValues[i] = Convert.ToDouble(values[i]);
            }
            MaxValue<double> maxDouble = new MaxValue<double>(doubleValues);
            maxDouble.PrintMax();

            Console.WriteLine("------------------------");

            Console.WriteLine("Enter Strings to compare: ");
            values = Console.ReadLine().Split(" ");
            MaxValue<string> maxString = new MaxValue<string>(values);
            maxString.PrintMax();

            Console.WriteLine("------------------------");
        }
    }
}
