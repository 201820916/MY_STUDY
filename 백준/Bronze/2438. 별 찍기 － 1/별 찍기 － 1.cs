using System;

namespace baekjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for ( int i = 1 ; i < N+1 ; i++ )
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}