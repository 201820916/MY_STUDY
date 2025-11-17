using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int A = int.Parse(parts[0]);
            int B = int.Parse(parts[1]);
            int C = int.Parse(parts[2]);
            int reward = 0;
        
            if ( A == B && B == C )
            {
                reward = 10000+A*1000;
            }
       
        
            else if ( A == B || A == C )
            {
                reward = 1000 + A * 100;
            }
        
            else if ( B == C )
            {
                reward = 1000 + B * 100;
            }
        
            else
            {
                int max = Math.Max(A, Math.Max(B, C));
            
                reward = max*100;  
            }
        
            Console.WriteLine(reward);
        }
    }
}