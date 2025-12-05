using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int[] temp = new int[42];
            int answer = 0;
            for ( int i = 0 ; i < 42 ; i++ )
            {
                temp[i] = 0;
            }
            
            for ( int j = 0 ; j < 10 ; j ++ )
            {
                int input = int.Parse(Console.ReadLine());
                int input42 = input%42;
                
                temp[input42] += 1;
            }
            
            for ( int k = 0 ; k < 42; k++ )
            {
                if (temp[k] != 0)
                {
                    answer += 1;
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}