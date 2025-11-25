using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] parts = input.Split(' ');
            
            int N = int.Parse(parts[0]);
            
            int X = int.Parse(parts[1]);
            
            int i = 0;
           
            
            string input2 = Console.ReadLine();
            string[] parts2 = input2.Split(' ');
                                          

            string answer = "";
            

            for ( i = 0 ; i < N ; i++ )
            {
                if ( int.Parse(parts2[i]) < X)
                {
                    answer += parts2[i] + " ";
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}