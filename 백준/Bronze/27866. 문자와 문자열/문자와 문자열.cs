using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            char[] stochar = s.ToCharArray();
            
            int one_number = int.Parse(Console.ReadLine());
            
            char answer = stochar[one_number-1];
            
            Console.WriteLine(answer);
        }
    }
}