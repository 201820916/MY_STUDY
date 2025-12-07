using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int number_N = int.Parse(parts[0]);
            int number_M = int.Parse(parts[1]);
            int temp = 0;
            
            int[] baskets = new int[number_N];
            
            for(int i = 0 ; i < number_N ; i++)
            {
                baskets[i] = i+1;
            }
            
            for( int j = 0 ; j < number_M ; j++ )
            {
                string input2 = Console.ReadLine();
                string[] parts2 = input2.Split(' ');
                int first = int.Parse(parts2[0]);
                int second = int.Parse(parts2[1]);
                
                int left = first - 1;
                int right = second - 1;
                
                while (left < right)
                {
                    temp = baskets[left];
                    baskets[left] = baskets[right];
                    baskets[right] = temp;

                    left++;
                    right--;
                }
            }
            
            Console.WriteLine(string.Join(" ", baskets));
        }
    }
}