using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine().ToUpper();
            char[] C_input = input.ToCharArray();
            
            Array.Sort(C_input);
            
            int answer = 0;
            int temp = 1; 
            int temp2 = 0; 
            int temp3 = 0; // 동점체크 (-1이면 동점)

            for ( int i = 0 ; i < C_input.Length - 1 ; i++ )
            {
                if ( C_input[i] == C_input[i+1] )
                {
                    temp += 1;
                }
                else
                {

                    if ( answer < temp )
                    {
                        answer = temp;
                        temp2 = i;
                        temp3 = 0; 
                    }
                    else if ( temp == answer )
                    {
                        temp3 = -1; // 동점 발생
                    }
                    
                    temp = 1; // 새로운 글자를 위해 개수 1로 초기화
                }
            }
            
            // 3. 누락된 마지막 구간 비교 (for문이 끝나고 마지막으로 모인 temp를 정산)
            if ( answer < temp )
            {
                temp2 = C_input.Length - 1;
                temp3 = 0;
            }
            else if ( temp == answer )
            {
                temp3 = -1;
            }
            
            // 결과 출력
            if ( temp3 == -1 )
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(C_input[temp2]);
            }
        }
    }
}