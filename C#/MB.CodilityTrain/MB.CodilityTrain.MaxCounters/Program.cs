using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.CodilityTrain.MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            int[] list = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            var res = new Solution().solution(X, list);
            Console.WriteLine("Result ... ");
            res.ToList().ForEach(a => Console.Write(a + ","));
            Console.ReadLine();
        }
    }
    class Solution
    {
        public int[] solution(int X, int[] A)
        {
            int[] counters = new int[X];
            int max = 0;
            int pass = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > X)
                {
                    // passing information to grow up
                    pass = max;
                }
                else
                {
                    //increase index or increase and replace by passing value 
                    if (counters[A[i] - 1] < pass)
                        counters[A[i] - 1] = pass;
                    counters[A[i] - 1] += 1;
                    if (counters[A[i] - 1] > max) max = counters[A[i] - 1];
                }
            }

            // increase for minimal value in counter
            for (int i = 0; i < counters.Length; i++)
                if (counters[i] < pass)
                    counters[i] = pass;

            return counters;
        }
    }
}
