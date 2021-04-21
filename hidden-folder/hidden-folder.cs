using System;

namespace hidden_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your folder name: ");
            string file = Console.ReadLine();
            if (file.StartsWith('.'))
            {
                Console.WriteLine("This is a hidden folder");
            }
            else
            {

                Console.WriteLine("Your folder is not a hidden folder");
            }
        }
    }
}
