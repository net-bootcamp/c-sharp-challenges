using System;

namespace cupSwap
{
    class Program
    {
        public static string CupSwap(string [] swap)
        {
            string position="B";
      
            
            for (int i = 0; i < swap.Length ; i++)
            {
                if (swap[i].Contains (position ) )
                {
                    position = swap[i].Replace(position, "");

                }
            }
            return position;
        
        }

        static void Main(string[] args)
        {
            string[] swaps= { "AB", "CA", "CA", "AC" };
            Console.WriteLine($"Current cup contains the ball is : {CupSwap(swaps)} ");
        }
    }
}
