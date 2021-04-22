using System;

namespace csession
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "hello,world this is.me";
            char[] c = { ' ', ',', '.' };
            string[] MyStrings = text.Split(c);

            foreach (var item in MyStrings)
            {
                Console.WriteLine(item);
            }

        }

    }
}
