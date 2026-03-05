using System;

namespace Beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] input_chess = input.Split(' ');
            
            int[] int_chess = Array.ConvertAll(input_chess, int.Parse);
            
            int[] All_Chess = { 1, 1, 2, 2, 2, 8 };
            
            int[] answer_chess = new int[6];
            
            for ( int i = 0 ; i < All_Chess.Length ; i++ )
            {
                answer_chess[i] = All_Chess[i] - int_chess[i];
            }
            
            Console.WriteLine(string.Join(" ", answer_chess));
        }
    }
}