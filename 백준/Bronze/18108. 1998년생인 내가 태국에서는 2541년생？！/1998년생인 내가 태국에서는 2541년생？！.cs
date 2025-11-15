using System;

namespace BAEKJOON
{
    class Program
    {
        public static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int gap = 2541-1998;
            int answer = year-gap;
            Console.WriteLine(answer);
        }
    }
}
