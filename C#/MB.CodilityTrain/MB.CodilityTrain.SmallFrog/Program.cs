using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.CodilityTrain.FrogJmp
{
    class Program
    {
        static void Main(string[] args) 
        {
            var steps = new Solution().solution(10, 85, 30);
            Console.WriteLine("Necesarry steps: {0}", steps);
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int X, int Y, int D)
        {
            int steps = 0;
            // write your code in C# with .NET 2.0
            if (X < Y)
            {
                int distance = Y - X;
                steps = distance / D;
                //need additional step?
                if (distance % D != 0) steps += 1;
            }
            return steps;
        }
    }
}
