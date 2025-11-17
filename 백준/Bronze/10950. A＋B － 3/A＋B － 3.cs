using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int test_number = int.Parse(Console.ReadLine());

            for ( int i = 0 ; i < test_number ; i++ )
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                
                int A = int.Parse(parts[0]);
                int B = int.Parse(parts[1]);
                
                Console.WriteLine(A+B);
                   
            }
         
        }
    }
}