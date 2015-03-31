// https://codility.com/demo/results/demoYQ7CNG-KCT/
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.CodilityTrain.FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            int[] list = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            var res = new Solution().solution(X, list);
            Console.WriteLine("Position: {0}", res);
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int X, int[] A)
        {
            int steps = X;
            // posible steps
            bool[] map = new bool[steps + 1];
            for (int i = 0; i < A.Length; i++)
            {
                if (!map[A[i]])
                {
                    map[A[i]] = true;
                    steps--;
                }
                // step through river
                if (steps == 0) return i;
            }
            return -1;
        }
    }
}
