using System;

namespace class21apr
{
    class Program
    {

        static void method (string file)
        {
        
        //trim() to delete white space
        
            if (file.Trim().StartsWith(".")){
                Console.WriteLine("This is heddin folder"); }
            else {
                Console.WriteLine("The folder name is " + file);
  
            }

        }

        static void Main(string[] args)
        {

            method(".git");
        }
    }
}
