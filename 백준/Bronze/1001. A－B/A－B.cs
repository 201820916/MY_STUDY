using System;

namespace BAEKJOON
{
    class minus
    {
        static void Main(String[] args)
        {
            String input = Console.ReadLine();
            
            string[] parts = input.Split(' ');
            int A = int.Parse(parts[0]);
            int B = int.Parse(parts[1]);
            
            Console.WriteLine(A-B);
        }
    }
}