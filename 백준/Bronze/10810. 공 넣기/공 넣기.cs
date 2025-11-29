using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            
            string input = Console.ReadLine(); 
            string[] parts = input.Split(' ');
            
            int N = int.Parse(parts[0]);
            int M = int.Parse(parts[1]);
            
            
            int[] temps = new int[N]; 
            
            
            for (int all_number = 0; all_number < M; all_number++) 
            {
                
                string input2 = Console.ReadLine();
                string[] parts2 = input2.Split(' ');
                
                int i = int.Parse(parts2[0]);
                int j = int.Parse(parts2[1]);
                int k = int.Parse(parts2[2]);
                
                
                for (int s = i; s <= j; s++) 
                {
                    temps[s - 1] = k; 
                }
            }
            
            
            string answer = string.Join(" ", temps);
            
            Console.WriteLine(answer);
        }
    }
}