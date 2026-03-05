using System;

namespace beakjoon
{
    class project
    {
        

        public static void Main(string[] args)
        {
            int answer = 0;
            
            string input = Console.ReadLine();
            
            string[] check = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
       
            foreach (string s in check)
            {
                answer += 1;
            }
            
            Console.WriteLine(answer);
        }
    }
}