using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            double totalCredit = 0; // 학점 총합
            double totalSum = 0; // 학점*과목평점
            
            for ( int i = 0 ; i < 20 ; i++ )
            {
                string input = Console.ReadLine();
                string[] s_temp = input.Split(' ');
                
                double credit = double.Parse(s_temp[1]);
                string grade = s_temp[2];
                
                // s_temp[0] : 강의명
                // s_temp[1] : 학점
                // s_temp[2] : 등급
                
                if(grade == "P")
                {
                    continue;
                }
                
                double gradeScore = 0; // 과목평점을 담을 변수
                
                switch (grade)
                {
                    case "A+" : gradeScore = 4.5;
                        break;
                    case "A0" : gradeScore = 4.0;
                        break;
                    case "B+" : gradeScore = 3.5;
                        break;
                    case "B0" : gradeScore = 3.0;
                        break;
                    case "C+" : gradeScore = 2.5;
                        break;
                    case "C0" : gradeScore = 2.0;
                        break;
                    case "D+" : gradeScore = 1.5;
                        break;
                    case "D0" : gradeScore = 1.0;
                        break;
                    case "F" : gradeScore = 0.0;
                        break;
                }
                
                totalCredit += credit;
                
                totalSum += (credit*gradeScore);
            }
            
            double answer = totalSum / totalCredit;
            
            Console.WriteLine(answer.ToString("0.000000"));
            
        }
        
    }
}