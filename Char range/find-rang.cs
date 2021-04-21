using System;

namespace find_rang
{
    class Program
    {
        static void Main(string[] args)
        {

            string m = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine(rangreturn('h', 'a', 'z'));
        }

        static bool rangreturn(Char x, char y, char z)
        {
            if (x >= y && x <= z)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
