using System;

namespace BeakJoon
{
    class program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            long A = long.Parse(parts[0]);
            long B = long.Parse(parts[1]);
            long C = long.Parse(parts[2]);

            long answer = A + B + C;

            Console.WriteLine(answer);
        }
    }
}
