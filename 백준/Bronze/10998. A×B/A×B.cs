using System;

namespace BAEKJOON
{
    class math
    {
        static void Main(String[] args)
        {
            string input = Console.ReadLine();
            
            String[] parts = input.Split(' ');
            int A = int.Parse(parts[0]);
            int B = int.Parse(parts[1]);
            
            Console.WriteLine(A*B);
        }
    }
}