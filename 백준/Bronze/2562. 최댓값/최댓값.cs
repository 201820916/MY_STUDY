using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int max = 0;
            int max_index = 0;
            
            for (i = 0 ; i < 9 ; i++)
            {
                int current_number = int.Parse(Console.ReadLine());

                if (i == 0 || current_number > max) 
                {
                    max = current_number;
                    
                    max_index = i + 1; 
                }
            }
            
            Console.WriteLine(max);
            Console.WriteLine(max_index);
        }
    }
}