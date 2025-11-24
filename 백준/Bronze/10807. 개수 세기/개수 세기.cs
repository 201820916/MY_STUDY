using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int i = 0;
            
            string input_number = Console.ReadLine();
            string[] parts = input_number.Split(' ');
            
            int search_number = int.Parse(Console.ReadLine());
            
            int number = 0;
            
            for ( i = 0 ; i < input ; i++)
            {
                if (int.Parse(parts[i]) == search_number)
                {
                    number += 1;
                }
            }
            
            Console.WriteLine(number);
        }
    }
}