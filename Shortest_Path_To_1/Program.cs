using System;
using System.Diagnostics;

namespace Shortest_Path_To_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Stopwatch sw = Stopwatch.StartNew();

            //TopDown topDown = new TopDown();
            //int a = topDown.Calculate(2000);
            //Console.WriteLine("Result: " + a);

            //BruteForce bruteForce = new BruteForce();
            //int b = bruteForce.Calculate(200000000);
            //Console.WriteLine("Result: " + b);

            BottomUp bottom = new BottomUp();
            int b = bottom.Calculate(200);
            Console.WriteLine("Result: " + b);

            sw.Stop();

            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalSeconds);


        }
    }
}
