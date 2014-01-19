using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.CodilityTrain.TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 100000;
            int[] bList = new int[len];
            for (int i = 0; i < len; i++)
            {
                bList[i] = new Random().Next(-1000, 1000);
            }

            int[] list = new int[] { -3, 1, -2, 4 - 3 };
            int res = new Solution().solution(list);
            Console.WriteLine("Result ...  {0}",res);
            Console.ReadLine();
        }
    }
    class Solution
    {
        public int solution(int[] A)
        {
            int res = int.MaxValue;
            int sum1 = 0;
            int sum2 = A.Sum();
            for (int i = 1; i < A.Length; i++)
            {
                int currentValue = A[i - 1];
                sum1 += currentValue;
                sum2 -= currentValue;
                int tmp = Math.Abs(sum2 - sum1);
                if (tmp < res) res = tmp;
            }
            return res;
        }
    }
}
