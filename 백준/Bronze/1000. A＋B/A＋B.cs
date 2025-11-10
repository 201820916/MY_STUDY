using System;

namespace Program
{
    class Plus
    {
        static void Main(string[] args) 
        {
            string input = Console.ReadLine();
        
            string[] parts = input.Split(' ');
            int A = int.Parse(parts[0]);
            int B = int.Parse(parts[1]);
        
            Console.WriteLine(A+B);
        }
    }
}