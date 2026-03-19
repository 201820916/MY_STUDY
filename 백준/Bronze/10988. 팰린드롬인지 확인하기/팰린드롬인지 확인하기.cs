using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            
            int answer = 0;
            
            string input = Console.ReadLine();
            
            char[] C_input = input.ToCharArray();
            char[] RC_input = (char[])C_input.Clone(); 
            Array.Reverse(RC_input); 
            
            
            
            for ( int i = 0 ; i < C_input.Length ; i++ )
            {
                if ( C_input[i] != RC_input[i] )
                {
                    answer = 0;
                    break;
                }
                
                else
                {
                    answer = 1;
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}