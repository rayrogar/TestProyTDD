using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextPermutation.Test
{
    public static class TestData
    {
        /// <summary>
        /// Generate random int array with values between 1 <= x <= 1000
        /// </summary>
        /// <param name="size">Size of random array</param>
        public static IEnumerable<int> GetRandoArray(int size)
        {
            int[] arr = new int[size];
            return arr.Select(x => x = new Random().Next(1, 1000));
        }

        /// <summary>
        /// Generate a set of Data test arrays
        /// </summary>
        /// <param name="cont">Number of arrays desired</param>
        public static IEnumerable<object[]> GetManyArraySet(int cont){
            List<object[]> data = new List<object[]>();
            for (int i = 0; i < cont; i++)
            {
                data.Add(new object[] { GetRandoArray(new Random().Next(1, 100)) });
            }

            return data;
        }
        
    }
}