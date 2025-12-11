using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int try_number = int.Parse(Console.ReadLine());
            
            for ( int i = 0 ; i < 3 ; i++ )
            {
                string s = Console.ReadLine();
                
                if ( s.Length == 1 )
                {
                    Console.WriteLine(""+s+s);
                }
                
                else
                {
                    char[] s2 = s.ToCharArray();
                    
                    char first = s2[0];
                    char last = s2[s.Length - 1];
                    
                    Console.WriteLine(""+first+last);
                }
            }
        }
    }
}