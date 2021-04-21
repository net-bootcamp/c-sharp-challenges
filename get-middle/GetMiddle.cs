using System;

namespace GetMiddle
{
    class Program
    {
        public static void GetMiddle(string word)
        {
            if (word.Length % 2 == 0)
                Console.WriteLine(word.Substring((word.Length - 1) / 2, 2));
            else
                Console.WriteLine(word.Length / 2);
        }

        static void Main(string[] args)
        {
            GetMiddle("rawabe");
        }
    }
}
