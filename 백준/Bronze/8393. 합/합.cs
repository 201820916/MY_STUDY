using System;

namespace BeakJoon
{
    class Project
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for ( int i = 0 ; i < N+1 ; i++ )
            {
                sum += i;
            }
            
            Console.WriteLine(sum);
        }
    }
}