using System;
using System.Text;

namespace fastSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeatNumber = int.Parse(Console.ReadLine());
            string[] numberList = new string[2];
            StringBuilder resultNumber = new StringBuilder(repeatNumber * 2);
            for (int i = 0; i < repeatNumber; i++)
            {
                numberList = Console.ReadLine().Split(" ");
                resultNumber.Append(int.Parse(numberList[0]) + int.Parse(numberList[1]));
                resultNumber.AppendLine();
             }

            Console.WriteLine(resultNumber.ToString());
        }
    }
}