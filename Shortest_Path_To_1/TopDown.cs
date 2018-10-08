using System;
using System.Collections.Generic;
using System.Linq;

namespace Shortest_Path_To_1
{
    public class TopDown
    {
        private int[] lookUp; // = new int[20000000];

        public TopDown(){ }

        public int Calculate(int n)
        {
            lookUp = new int[n];
            lookUp[1] = 0;
            return GetSubStep(n);
        }

        private int GetSubStep(int n)
        {
            if (!lookUp.Contains(n)){
               // Console.Write(n + ", ");
                lookUp[n] = CalculateSubStep(n).Min();
            }
            return lookUp[n];
        }

        private IEnumerable<int> CalculateSubStep(int n)
        {
            if(isDivisibleBy(n, 3))
            {
               yield return GetSubStep(n / 3) + 1;
            }
            if(isDivisibleBy(n, 2))
            {
               yield return GetSubStep(n / 2) + 1;
            }
            yield return GetSubStep(n - 1) + 1;
        }

        private bool isDivisibleBy(int n, int divider)
        {
            return (n % divider) == 0;
        }
    }
}
