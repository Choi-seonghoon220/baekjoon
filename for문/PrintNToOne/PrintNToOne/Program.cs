using System;
using System.Text;

namespace PrintNToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder printNumber = new StringBuilder(n * 3);

            for (int i = 0; i < n; i++)
            {
                printNumber.AppendLine(Convert.ToString(n - i));
            }

            Console.Write(printNumber);
        }
    }
}
