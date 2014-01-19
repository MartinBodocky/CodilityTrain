using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.CodilityTrain.PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 200000;
            int[] bList = new int[len];
            for (int i = 0; i < len; i++)
            {
                bList[i] = i + 2;
            }
            int[] list = new int[] { 1, 3, 2, 5, 6, 7, 8, 4, 10 };
            int res = new Solution().solution(bList);
            Console.WriteLine("Result ... {0}", res);
            Console.ReadLine();
        }
    }
    class Solution
    {
        public int solution(int[] A)
        {
            long sumOfAll = (A.LongLength + 1) * (A.LongLength + 2) / 2;
            long tmp = 0;
            for (int i = 0; i < A.Length; i++) tmp += A[i];
            long result = sumOfAll - tmp;
            return (int)result;
        }
    }
}
