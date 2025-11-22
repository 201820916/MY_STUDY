using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        { 
            while(true)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                int A = int.Parse(parts[0]);
                int B = int.Parse(parts[1]);
            
                if (A == 0 && B == 0)
                {
                    break;
                }
                
                else
                {
                    Console.WriteLine(A+B);
                }
            }
        }
    }
}