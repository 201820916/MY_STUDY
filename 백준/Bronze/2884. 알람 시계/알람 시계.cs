using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            
            int hour = int.Parse(parts[0]);
            int min = int.Parse(parts[1]);
            
            int all_min = (hour*60)+min;
            
            int answer_all_min = all_min - 45;
            
            if (answer_all_min < 0 )
            {
                answer_all_min += 24*60;
            }
            
            int answer_hour = answer_all_min / 60;
            int answer_min = answer_all_min % 60;

            Console.WriteLine(answer_hour + " " + answer_min);

        }
    }
}