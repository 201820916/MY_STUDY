using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

        int T = int.Parse(sr.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] nums = sr.ReadLine().Split(' ');
            int A = int.Parse(nums[0]);
            int B = int.Parse(nums[1]);

            sw.WriteLine(A + B);
        }

        sw.Flush();  // 출력 비우기(중요)
        sw.Close();
        sr.Close();
    }
}
