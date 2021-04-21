 using System;


namespace apr21ex2
{
    class check
    {

 static void Main(string[] args) { 

            Console.WriteLine("Enter String");
             string Stirng = Console.ReadLine();

             Console.Write("The string without E is: ");
             foreach (var item in Stirng)
             {
                 if (item == 'e' || item == 'E')
                 {
                     continue;
                 }
                 Console.Write(item);

             }
