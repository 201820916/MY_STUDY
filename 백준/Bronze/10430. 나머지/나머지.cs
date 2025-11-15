using System;

namespace baekjoon
{
    class program
    {
        public static void Main(String[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int A = int.Parse(parts[0]);
            int B = int.Parse(parts[1]);
            int C = int.Parse(parts[2]);
            
            int Type1 = (A+B)%C;
            int Type2 = ((A%C) + (B%C))%C;
            int Type3 = (A*B)%C;
            int Type4 = ((A%C) * (B%C))%C;
            
            Console.WriteLine(Type1);
            Console.WriteLine(Type2);
            Console.WriteLine(Type3);
            Console.WriteLine(Type4);
            
        }
    }
}

