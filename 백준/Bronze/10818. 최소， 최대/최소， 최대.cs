using System;

namespace Baekjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int N_number = int.Parse(Console.ReadLine());

            string numbers = Console.ReadLine();
            string[] parts = numbers.Split(' ');
            
            int min = int.Parse(parts[0]);
            int max = int.Parse(parts[0]);


            for (int i = 1; i < N_number; i++)
            {
                int currentNumber = int.Parse(parts[i]); 

                min = Math.Min(min, currentNumber);
                max = Math.Max(max, currentNumber);
            }
            
            Console.WriteLine(min + " " + max);
        }
    }
}