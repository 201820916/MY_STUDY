using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.Write(new string(' ', N - i)); // 공백 (N-i개)
            Console.WriteLine(new string('*', i)); // 별 (i개)
        }
    }
}