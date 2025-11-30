using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            string[] parts = input.Split(' ');
            
            int N = int.Parse(parts[0]);
            int M = int.Parse(parts[1]);
            
            int[] baskets = new int[N]; 
            
            int temp = 0;
            
            for ( int i = 0 ; i < N ; i++ )
            {
                baskets[i] = i+1;
            }
            
            for ( int j = 0 ; j < M ; j++ )
            {
                string basket_input = Console.ReadLine();
                string[] b_parts = basket_input.Split(' ');
    
    
                int first_num = int.Parse(b_parts[0]);
                int second_num = int.Parse(b_parts[1]);
    

                int first_idx = first_num - 1;
                int second_idx = second_num - 1;
    

                temp = baskets[first_idx];
    

                baskets[first_idx] = baskets[second_idx];
    

                baskets[second_idx] = temp;
            }
            
            string answer = string.Join(" ", baskets);
            
            Console.WriteLine(answer);
        }
    }
}