using System;

namespace beakjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_number = int.Parse(Console.ReadLine());
        
            for ( int i = 0 ; i < test_number ; i++ )
            {
                string[] s = Console.ReadLine().Split();
            
                int r = int.Parse(s[0]);
            
                for ( int j = 0 ; j < s[1].Length; j++ )
                {
                    for ( int k = 0 ; k < r ; k++ )
                    {
                        Console.Write(s[1][j]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

        