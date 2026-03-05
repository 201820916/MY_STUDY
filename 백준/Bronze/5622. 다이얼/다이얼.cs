using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            int use_second = 0;
               
            string input = Console.ReadLine();
               
            char[] cArray = input.ToCharArray();
               
            foreach ( char c in cArray)
            {
                switch (c)
                {
                    case 'A' or 'B' or 'C':
                        use_second += 3;
                        break;
                    case 'D' or 'E' or 'F':
                        use_second += 4;
                        break;
                    case 'G' or 'H' or 'I':
                        use_second += 5;
                        break;
                    case 'J' or 'K' or 'L':
                        use_second += 6;
                        break;
                    case 'M' or 'N' or 'O':
                        use_second += 7;
                        break;
                    case 'P' or 'Q' or 'R' or 'S':
                        use_second += 8;
                        break;
                    case 'T' or 'U' or 'V':
                        use_second += 9;
                        break;
                    case 'W' or 'X' or 'Y' or 'Z':
                        use_second += 10;
                        break;
                   }
                   
               }
               
               Console.WriteLine(use_second);
        }
    }
}
