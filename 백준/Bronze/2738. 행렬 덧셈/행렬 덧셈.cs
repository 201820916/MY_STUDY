using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string[] sizeInput = Console.ReadLine().Split(' ');
            int n = int.Parse(sizeInput[0]); 
            int m = int.Parse(sizeInput[1]);
            int[,] A = new int[n, m];
            
            for(int i = 0 ; i < n ; i++ )
            {
                string[] input = Console.ReadLine().Split(' ');
                
                for ( int j = 0 ; j < m ; j++ )
                {
                    A[i,j] = int.Parse(input[j]);
                }
            }
            
            for ( int i = 0 ; i < n ; i++ )
            {
                string[] input = Console.ReadLine().Split(' ');
                for ( int j = 0 ; j < m ; j++ )
                {
                    A[i, j] += int.Parse(input[j]);
                    
                    Console.Write(A[i, j] + " ");
                }
                
                Console.WriteLine();
            }
            
        }
    }
}