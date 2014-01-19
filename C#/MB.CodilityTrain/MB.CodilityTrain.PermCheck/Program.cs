using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.CodilityTrain.PermCheck
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

            int[] list = new int[] { 4, 2, 2, 2 };
            var res = new Solution().solution(bList);
            if (res == 1) Console.WriteLine("Permutation");
            else Console.WriteLine("Not a permutation");
            Console.ReadLine();
        }

        class Solution
        {
            public int solution(int[] A)
            {
                long sum = A.LongLength * (A.LongLength + 1) / 2;
                long sumofList = 0;
                for (int i = 0; i < A.Length; i++)
                    sumofList += A[i];
                if (sum == sumofList)
                    return A.Distinct().Count() != A.LongLength ? 0 : 1;
                else
                    return 0;
            }
        }
    }
}
