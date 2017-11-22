using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsExtensionMethods
{
    public static class SEM
    {
        /// <summary>
        /// Median of int,double,long values as extension for IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double Median<T>(this IEnumerable<T> numbers) where T:struct
        {
            int numberCount = numbers.Count();
            int halfIndex = numbers.Count() / 2;
            var sortedNumbers = numbers.Select(n => Convert.ToDouble(n)).OrderBy(n => n);
            double median;
            if ((numberCount % 2) == 0)
            {
                median = (sortedNumbers.ElementAt(halfIndex) +
                    sortedNumbers.ElementAt(halfIndex - 1)) / 2;
            }
            else
            {
                median = sortedNumbers.ElementAt(halfIndex);
            }
            return median;
        }

        /// <summary>
        /// Median for a field in class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <param name="fieldSelector"></param>
        /// <returns></returns>
        public static double Median<T>(this IEnumerable<T> numbers, Func<T, double> fieldSelector)
        {
            return numbers.Select(fieldSelector).Median();
        }

        /// <summary>
        /// Standard Deviation for a field in class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double StandardDeviation<T>(this IEnumerable<T> numbers, Func<T,double> fieldSelector) 
        {
            return numbers.Select(fieldSelector).StandardDeviation();
        }

        /// <summary>
        /// Standatd Deviation of int,double,long values as extension for IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double StandardDeviation<T>(this IEnumerable<T> numbers) where T:struct
        {
            var numList = numbers.Select(n => Convert.ToDouble(n));
            return Math.Sqrt(numList.Variance());
        }

        /// <summary>
        /// Average for a field in class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static double Average<T>(this IEnumerable<T> numbers, Func<T,double> fieldSelector)
        {
            return numbers.Select(fieldSelector).Average();
        }

        /// <summary>
        /// Variance of int,double,long values as extension for IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static double Variance<T>(this IEnumerable<T> values) where T : struct
        {
            double variance = 0;
            var newList = values.Select(i => Convert.ToDouble(i)).ToArray();
            var mean = newList.Average();
            int start = 0, end = newList.Count();
            for (int i = start; i < end; i++)
            {
                variance += Math.Pow((newList[i] - mean), 2);
            }

            int n = end - start;
            if (start > 0) n -= 1;

            return variance / (n);
        }

        /// <summary>
        /// Variance for a field in class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="fieldSelector"></param>
        /// <returns></returns>
        public static double Variance<T>(this IEnumerable<T> values, Func<T, double> fieldSelector) 
        {
            return values.Select(fieldSelector).Variance();
        }

    }
}
