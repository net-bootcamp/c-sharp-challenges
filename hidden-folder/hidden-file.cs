using System;

namespace ConsoleApp_4_211
{
    class Program
    {
        static void Main(string[] args)
        {
            // التحدي الأول
            Console.WriteLine("Enter your Folder :");
            string input = Console.ReadLine();
            if (input.StartsWith('.'))
            {
                Console.WriteLine("Hidden folder : your folder ( {0} )", input);

            }
            else
            {
                Console.WriteLine("not Hidden : your folder  ( {0} )", input);
            }
        }
    }
}