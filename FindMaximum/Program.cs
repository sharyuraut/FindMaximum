using System;

namespace FindMaximum
{
    public class MaxValue<T> where T : IComparable
    {
        T[] values;
        public MaxValue(T[] values)
        {
            this.values = values;
        }
        public T GetMaximum()
        {
            Array.Sort(values);
            return values[^1];
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum program!");

            /*Console.WriteLine("Maximum Integer: " + GetMaxInt(4, 2, 8));
            Console.WriteLine("Maximum Float Value: " + GetMaxFloat(11.4, 334.6, 234.8));
            Console.WriteLine("Maximum String is: " + GetMaxString("Apple", "Banana", "Grapes"));*/

            string[] values;
            int[] intValues = new int[100];
            Console.WriteLine("Enter integers to find maximum: ");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                intValues[i] = Convert.ToInt32(values[i]);
            }
            MaxValue<int> maxInt = new MaxValue<int>(intValues);
            int maxIntNumber = maxInt.GetMaximum();
            Console.WriteLine("Maximum of Integer: " + maxIntNumber);



            double[] doubleValues = new double[100];
            Console.WriteLine("Enter float numbers to find maximum: ");
            values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length; i++)
            {
                doubleValues[i] = Convert.ToDouble(values[i]);
            }
            MaxValue<double> maxDouble = new MaxValue<double>(doubleValues);
            double maxDoubleNumber = maxDouble.GetMaximum();
            Console.WriteLine("Maximum :" + maxDoubleNumber);


            Console.WriteLine("Enter Strings to compare: ");
            values = Console.ReadLine().Split(" ");
            MaxValue<string> maxString = new MaxValue<string>(values);
            string maxStringValue = maxString.GetMaximum();
            Console.WriteLine("Maximum :" + maxStringValue);
        }
    }
}
