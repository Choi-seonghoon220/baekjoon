using System;
using System.Text;
using System.Diagnostics;

namespace PrintOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st1 = new Stopwatch();
            Stopwatch st2 = new Stopwatch();
            st1.Start();
            int n = 100000;  // int.Parse(Console.ReadLine());
            StringBuilder printNumber = new StringBuilder(n * 2);

            for (int i = 0; i < n; i++)
            {
                printNumber.AppendLine(Convert.ToString(i + 1));
            }

            Console.WriteLine(printNumber);
            st1.Stop();


            st2.Start();

            uint N = 100000; // uint.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i + 1);
            }

            st2.Stop();
            Console.WriteLine($"첫번째 걸린 시간 : {st1.ElapsedMilliseconds}");
            Console.WriteLine($"두번째 걸린 시간 : {st2.ElapsedMilliseconds}");
        }
    }
}
