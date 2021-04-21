using System;

namespace ConsoleApp_4_211_v2
{
    class Program
    {
        static bool withinTheScop(char a, char b, char c)
        {
            if (b >= a && b <= c)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(withinTheScop('z', 'a', 'c'));
        }

    }
}
