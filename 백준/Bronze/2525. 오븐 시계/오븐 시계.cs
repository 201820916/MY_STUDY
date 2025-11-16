using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            
            int cook_time = int.Parse(Console.ReadLine());
         
            
            int hour = int.Parse(parts[0]);
            int min = int.Parse(parts[1]);
            
            int total_min = hour*60 + min + cook_time;
            
            total_min = total_min % 1440;
            
            int new_hour = total_min / 60;
            int new_min = total_min % 60;
            
            
            Console.WriteLine(new_hour + " " + new_min);
        }
    }
}