using System;
using System.Collections.Generic;
using System.Linq;

namespace Shortest_Path_To_1
{
    public class BruteForce
    {
        //Calculates all the possible paths, and returns the length of the shortest one.
        //Performance:
        //------------
        //calculated n = 200 in 1.733020689s

        public BruteForce() {  }

        public int Calculate(int n)
        {
            return CalculateSubStep(n, 0).Min();
        }

        private IEnumerable<int> CalculateSubStep(int n, int numStepsTaken)
        {
            if (n <= 1)
            {
                yield return numStepsTaken;
            }
            else
            {
                if(isDivisibleBy(n, 3))
                {
                    foreach(int c in CalculateSubStep(n / 3, numStepsTaken + 1))
                    {
                        Console.Write(n + ", ");
                        yield return c;
                    }
                }
                else if(isDivisibleBy(n, 2))
                {
                    foreach (int c in CalculateSubStep(n / 2, numStepsTaken + 1))
                    {
                        Console.Write(n + ", ");
                        yield return c;
                    }
                }
                else{
                    foreach (int c in CalculateSubStep(n - 1, numStepsTaken + 1))
                    {
                        Console.Write(n + ", ");
                        yield return c;
                    }
                }
            }

        }


        private bool isDivisibleBy(int n, int divider)
        {
            return (n % divider) == 0;
        }
    }
}
