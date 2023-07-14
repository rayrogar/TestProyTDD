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
                data.Add(new object[] { GetRandoArray(new Random().Next(1, 100)) });

            return data;
        }


        public static List<List<int[]>> GetStaticSet => 
            new List<List<int[]>>{
                    new List<int[]>{
                        new []{1,2,3}, new []{1,3,2}, new []{2,1,3},
                        new []{2,3,1}, new []{3,1,2}, new []{3,2,1}
                    },

                    new List<int[]>{
                        new []{1,2,3,4}, new []{1,2,4,3}, new []{1,3,2,4}, new []{1,3,4,2}, new []{1,4,2,3}, new []{1,4,3,2}, 
                        new []{2,1,3,4}, new []{2,1,4,3}, new []{2,3,1,4}, new []{2,3,4,1}, new []{2,4,1,3}, new []{2,4,3,1},
                        new []{3,1,2,4}, new []{3,1,4,2}, new []{3,2,1,4}, new []{3,2,4,1}, new []{3,4,1,2}, new []{3,4,2,1},
                        new []{4,1,2,3}, new []{4,1,3,2}, new []{4,2,1,3}, new []{4,2,3,1}, new []{4,3,1,2}, new []{4,3,2,1}
                        }
            };
    }
}