using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int N = 30;
            
            int[] student = new int[N];
            
            
            for ( int i = 0 ; i < 30 ; i++ )
            {
                student[i] = i+1;
            }
            
            for ( int j = 0 ; j < 28 ; j++ )
            {
                int input = int.Parse(Console.ReadLine());
                
                for ( int k = 0 ; k < 30 ; k++ )
                {
                    if ( student[k] == input )
                    {
                        student[k] = 0;
                    }
                }
            }
            
            for ( int Q = 0 ; Q < 30 ; Q++ )
            {
                if ( student[Q] != 0 )
                {
                    Console.WriteLine(student[Q]);
                }
                
                else
                {
                    
                }
            }
        }
    }
}