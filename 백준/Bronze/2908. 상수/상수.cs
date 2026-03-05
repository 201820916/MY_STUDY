using System;

namespace beakjoon
{
    class project
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string[] strArray = input.Split(' ');
            
            for ( int i = 0 ; i < strArray.Length ; i++ )
            {
                char[] charArray = strArray[i].ToCharArray();
                
                Array.Reverse(charArray);
                
                strArray[i] = new string(charArray);
            }
            
            int[] newNumber = new int[strArray.Length]; 
            
            for (int i = 0; i < strArray.Length; i++)
            {
                newNumber[i] = int.Parse(strArray[i]);
            }
            
            
            Array.Sort(newNumber);
            Array.Reverse(newNumber);
            
            Console.WriteLine(newNumber[0]);
            
        }
    }
}