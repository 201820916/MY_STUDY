using System;

namespace BaekJoon
{
    class program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            
            long A = long.Parse(parts[0]);
            long B = long.Parse(parts[1]);
            
            if (A < B)
            {
                Console.WriteLine("<");
            }
            
            else if ( B < A )
            {
                Console.WriteLine(">");
            }
            
            else
            {
                Console.WriteLine("==");
            }
            
        }
    }
}