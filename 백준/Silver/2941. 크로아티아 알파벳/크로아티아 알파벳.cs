using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] alpha = new string[] {"dz=", "lj", "nj", "c=", "c-", "d-", "s=", "z="};

            for ( int i = 0 ; i < alpha.Length ; i++ )
            {
                input = input.Replace(alpha[i], "!");
            }
            
            Console.WriteLine(input.Length);
        }
    }
}