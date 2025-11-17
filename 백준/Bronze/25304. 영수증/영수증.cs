using System;

namespace BeakJoon
{
    class Project
    {
        public static void Main(string[] args)
        {
            int all = int.Parse(Console.ReadLine());
            int entry = int.Parse(Console.ReadLine());
            
            int sum_price = 0;
            for (int i = 1 ; i <= entry ; i++ )
            {
                string buy = Console.ReadLine();
                string[] parts = buy.Split(' ');
                
                int price = int.Parse(parts[0]);
                int Quantity = int.Parse(parts[1]);
                
                sum_price += price*Quantity;
            }
            
            if ( all == sum_price )
            {
                Console.WriteLine("Yes");
            }
            
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}