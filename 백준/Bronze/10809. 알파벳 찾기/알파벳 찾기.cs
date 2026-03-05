using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] positions = new int[26];
        
        // 배열을 -1로 초기화
        for (int i = 0; i < 26; i++)
        {
            positions[i] = -1;
        }
        
        // 입력 문자열 순회
        for (int i = 0; i < input.Length; i++)
        {
            int index = input[i] - 'a'; // 'a'를 기준으로 인덱스 계산
            if (positions[index] == -1) // 처음 등장한 경우에만 저장
            {
                positions[index] = i;
            }
        }
        
        // 결과 출력
        Console.WriteLine(string.Join(" ", positions));
    }
}