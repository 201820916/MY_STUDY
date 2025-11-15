using System;

namespace beakjoon
{
    class project
    {
        public static void Main(String[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            
            int B1 = B/100;
            int B2 = B/10 - B1*10;
            int B3 = B - (B1*100 + B2*10);
            
            int answer3 = A*B3;
            int answer4 = A*B2;
            int answer5 = A*B1;
            int answer6 = (answer3+(answer4*10)+(answer5*100));
            
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            Console.WriteLine(answer5);
            Console.WriteLine(answer6);
        }
    }
}