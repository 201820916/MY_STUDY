using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            
            for ( int i = 1 ; i <= quantity ; i++ )
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                
                int A = int.Parse(parts[0]);
                int B = int.Parse(parts[1]);
                
                int answer = A+B;
                
                Console.WriteLine($"Case #{i}: {answer}");
            }
        }
    }
}