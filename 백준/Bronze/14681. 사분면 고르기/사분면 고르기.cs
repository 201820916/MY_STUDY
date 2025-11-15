using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            if ( 0<x && 0<y )
            {
                Console.WriteLine("1");
            }
            
            if ( x<0 && 0<y )
            {
                Console.WriteLine("2");
            }
            
            if ( x<0 && y<0 )
            {
                Console.WriteLine("3");
            }
            
            if ( 0<x && y<0)
            {
                Console.WriteLine("4");
            }
        }
    }
}