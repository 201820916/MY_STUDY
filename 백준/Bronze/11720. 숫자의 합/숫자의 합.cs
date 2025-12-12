using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            string input = Console.ReadLine();
            
            char[] input2 = input.ToCharArray();
            
            int sum = 0;
            int temp = 0;
            
            for ( int i = 0 ; i < N ; i++ )
            {
               temp = int.Parse(input2[i].ToString());
               sum += temp; 
            }
            
            Console.WriteLine(sum);
        }
    }
}