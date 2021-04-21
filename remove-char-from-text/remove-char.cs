using System;

namespace ConsoleApp_4_211
{
    class Program
    {
        static void Main(string[] args)
        {

            // التحدي الثالث 
            string text = "hello mohammed";
            string output = "";
            foreach (var item in text)
            {
                if (item == 'm')
                    continue;
                output += item;
            }
            Console.WriteLine(output);
        }
    }
}
