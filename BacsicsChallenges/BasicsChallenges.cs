using System;

namespace Challenges
{
    class Program
    {
        //for challnge4
        static string GetMiddel(string middleTxt)
        {
            return middleTxt.Substring((middleTxt.Length - 1) / 2, 2 - (middleTxt.Length % 2));

        }
        //for challnge5
        static bool isInRange(char first, char second, char letter)
        {
            if (letter >= first &&  letter <= second)
                return true;
            else
                return false;
        }
        
        public static string Trim(string secntence) {

            char[] split = {' ',',' };
            return secntence.Trim(split);
        }
        static void Main(string[] args)


        {
            Console.WriteLine("Welcome in .Net Bootcamp - C# Basics Challenges ");


            // Challenge 1:  Hidden Files Detection by name (.FileName)
            Console.WriteLine("Challenge 1:  Hidden Folders Detection by name (.FileName)");

            Console.WriteLine("Please Enter the Folder name:");
            string FolderName = Console.ReadLine();


            if (FolderName.StartsWith("."))
            {
                Console.WriteLine("This is a hidden Folder");

            }
            else
                Console.WriteLine("Your Folder is not hiiden");

            Console.WriteLine($" \n *******************");

            //Challenge 2: check if the string contains number or not

            Console.WriteLine("Challenge 2: check if the string contains number");

            Console.WriteLine("Please Enter the Text to check if it contains number or not:");
            string text = Console.ReadLine();
               
                
            if (text.Contains("0") || text.Contains("1") || text.Contains("2") ||
                   text.Contains("3") || text.Contains("4") || text.Contains("5") ||
                   text.Contains("6") || text.Contains("7") || text.Contains("8") ||
                   text.Contains("9"))
            {
                Console.Write("There are numbers in the text");
            }
            else
            {
                Console.Write("There are  \" no \" numbers in the text");
            }

            // Continue & Break Concept Examples

            /* for (int i = 1; i <= 10; i++)
              {
                  if (i == 3) continue; //skip for 3 {print all exept 3}
                  if (i == 3) break; //End befor 3 {print all members befor 3}
                  Console.Write(i +"");
              }*/

            Console.WriteLine($" \n *******************");


            // Challenge 3: Remove specific letter from text
            Console.WriteLine("Challenge 3: Remove a specific letter from text");

            Console.WriteLine("Please Enter the text to remove letter 'e' :");
                string txtch3 = Console.ReadLine();
                Console.Write("Yor text without 'e' is :");
                foreach (var item in txtch3)
                {
                    if (item == 'e' || item == 'E')
                    {
                        continue;
                    }
                    Console.Write(item);

                }
                Console.WriteLine($" \n *******************");

            //Challenge 4: how to return the middle from txt
            Console.WriteLine("Challenge 4: how to return the middel from txt");

            Console.WriteLine("Please Enter the Text to retrn middel from it :");
                string Textch4 = Console.ReadLine();
                Console.WriteLine($"The middle in your txt is {GetMiddel(Textch4)}");

            //Challenge 5: how to return the middle from txt
            Console.WriteLine("Challenge 5: Check if the input between the determined range or not");
            char rangeEntry;
            char rangeEnd;
            char letter;
            Console.WriteLine("Please Enter the entry of the range:");
            rangeEntry = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please Enter the end of the range:");
            rangeEnd = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please Enter the the letter you want to check if is in the range:");
            letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Result: 1- True (if within the range) \n" +
                              $"\t 2- (if without range) " +
                              $"\n {isInRange(rangeEntry, rangeEnd, letter)}");

            //challenge 6 : How to return substring depending in group of marks
            Console.WriteLine($" \n *******************");
            Console.WriteLine("challenge 6 : How to return substring depending by splitting the string depending in a group of marks");

            string textch6 = "Hello,world this is.me";


            string[] txtChain = textch6.Split(new char [] { ' ', ',', '.' });
            foreach (var word in txtChain)
            {
                Console.WriteLine(word);

            }


            //TO remove space use Trim use it in general (in input application form ex email)
            

         

            // Challenge 7: generate random number under specifuc number
            Console.WriteLine($" \n *******************");
            Console.WriteLine("Challenge 7: generate random number under specifuc number");
            Console.WriteLine("Generating 1 random number under 10:");
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(10)); //maximum value is 10

            //TO remove char use Trim use it in general (in input application form ex email)
            Console.WriteLine(Trim("  uyuyuyu"));
            



        }

    }
}
