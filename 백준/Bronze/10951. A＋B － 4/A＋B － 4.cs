using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string line;
            while((line = Console.ReadLine()) != null)
            {
                string[] parts = line.Split(' ');
                
                int A = int.Parse(parts[0]);
                int B = int.Parse(parts[1]);
                
                Console.WriteLine(A+B);
               
            } 
               
        }
    }
}