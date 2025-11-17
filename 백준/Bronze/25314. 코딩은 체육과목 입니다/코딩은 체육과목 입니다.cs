using System;
using System.Text;

namespace BeakJoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int Long_N = N / 4;

            StringBuilder S = new StringBuilder();

            for (int i = 0; i < Long_N; i++)
            {
                S.Append("long ");
            }

            S.Append("int");

            Console.WriteLine(S.ToString());
        }
    }
}
