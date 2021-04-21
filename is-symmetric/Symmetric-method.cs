using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp

{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Symmetric(990099));
    }

    public static bool Symmetric(int num)
    {    //1. check  input 
        String opposite = num.ToString();



        //2. do action
        if (String.Concat(opposite.Reverse()) == opposite)
        {
            //3. get output
            return true;
        }

        return false;
    }
}
}
