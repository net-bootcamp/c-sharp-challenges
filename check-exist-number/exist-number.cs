using System;

namespace ConsoleApp_4_211
{
    class Program
    {
        static void Main(string[] args)
        {
            // التحدي الثاني

            string text = "hello mohammed"; // output = there are no number
            string check = "0123456789";
            bool status = false;

            foreach (var item in check)
            {
                if (text.Contains(item))
                {
                    status = true;
                }
            }

            if (status)
                Console.WriteLine("there are number");
            else
                Console.WriteLine("there are no number");

        }
    }
}