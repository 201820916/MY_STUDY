using System;
using System.Linq;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int test_number = int.Parse(Console.ReadLine());
            
            double temp = 0;
            
            string numbers = Console.ReadLine();
            string[] parts = numbers.Split(' ');
            
            int[] C_parts = Array.ConvertAll(parts, int.Parse);
            
            int MaxValue = C_parts.Max();
            
            
            for ( int i = 0 ; i < test_number ; i++ )
            {
                temp += (double)C_parts[i] / MaxValue * 100;
            }
            
            double answer = temp / test_number;
            
            Console.WriteLine(answer);
            
        }
    }
}