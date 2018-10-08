namespace Shortest_Path_To_1
{
    public class BottomUp
    {
        private int[] lookUp;
        
        public BottomUp() { }

        public int Calculate(int n)
        {
            lookUp = new int[n + 1];
            lookUp[1] = 0;

            for (int i = 0; i <= n + 1; i+=2)
            {
                lookUp[i] = CalculateStep(i);
            }
            return lookUp[n];
        }
        
        private int CalculateStep(int n)
        {
            if (isDivisibleBy(n, 3))
            {
                return lookUp[n / 3] + 1;
            }
            if (isDivisibleBy(n, 2))
            {
                return lookUp[n / 2] + 1;
            }
            return lookUp[n - 1] + 1;
        }

        private bool isDivisibleBy(int n, int divider)
        {
            return (n % divider) == 0;
        }
    }
}
