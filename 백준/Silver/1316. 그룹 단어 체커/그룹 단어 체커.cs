using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int count_all = int.Parse(Console.ReadLine());
            int answer = 0;
            
            for ( int i = 0 ; i < count_all ; i++ )
            {
                string input = Console.ReadLine();
                char[] c_input = input.ToCharArray();
                
                bool isAnswer = true;
                
                for ( int j = 0 ; j < c_input.Length - 1 ; j++ )
                {
                    if (isAnswer == false )
                    {
                        break;
                    }
                    
                    for ( int k = j + 1 ; k < c_input.Length ; k++ ) 
                    {
                        if (c_input[j] == c_input[k] && c_input[k-1] != c_input[k])
                        {
                            isAnswer = false;
                            break;
                        }
                    }
                } 
                if ( isAnswer == true ) 
                {
                    answer += 1;
                }
            }
            
            Console.WriteLine(answer);
        }
    }
}