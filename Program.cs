using System;
using System.Linq;

namespace csBasics
{
    class Program
    {

        static void Main(string[] args)
        {

            string str = "welcome";
            Console.WriteLine(GetMiddle(str));


            /* object[] MyVals = new object[] { "abc", 123, "def", 456 };

             ParseArray(MyVals);

             CountOnes(999);*/

            //Console.WriteLine(IsSymmetrical(7227));
            

            /*
            const double pi = 3.14;

            DateTime DOB = new DateTime(1998, 6, 18); //challenge 1

            int grade = 60; //1
            if (grade >= 60)
            {
                Console.WriteLine("passed");
            }

            if (grade >= 60) //2
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("failed");
            }

            int number = 0;
            if (number > 0) //3
            {
                Console.WriteLine("+");
            }
            else if (number > 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }


            int age = 19;
            if (age >= 18)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("under age");
            }



            int num = -1; //challenge 2

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("odd");

            }
            else
            {
                Console.WriteLine("invalid value");

            }


            int myNum = 1; //1
            while (myNum <= 100)
            {
                Console.WriteLine(myNum);
                myNum++;
            }



            int sum = 0; //2
            Console.WriteLine("The first 10 numbers are :");
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine("\nThe Sum is : " + sum);


            int MySum = 0; //3
            int input = 0;

            for (int i = 1; i <= 10; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());
                MySum += input;
            }
            double avg = MySum / 10.0;
            Console.Write("The sum of 10 no is : {0} The Average is : {1} ", MySum, avg);




            for (int i = 0; i < 10; i++) //challenge 3
            {
                Console.Write("*");
                if (i == 4)
                    Console.WriteLine();
            }
            Console.WriteLine();



            string[] arr = new string[] { "Ahmed", "Khalid", "Nouf" }; //challenge 4


            //retrieving value using foreach loop
            foreach (string name in arr)
            {
                Console.WriteLine("Hello " + name);
            }

            Console.WriteLine(isMax(1, 2));



            static int isMax(int a, int b) //challenge 5
            {
                int max;
                if (a > b)
                {
                    max = a;
                }
                else
                {
                    max = b;
                }

                return max; 

        }*/
            /*

            static void ParseArray(object[] arr)
            {
                string[] output = new string[arr.Length];

                int i = 0;
                foreach (object o in arr)
                {
                    output[i] = o.ToString();
                    Console.WriteLine(output[i]);
                    i++;
                }
                
            }

            static int CountOnes(int i)
            {
                int db = 0;
                while (i > 0)
                {
                    if (i % 2 == 1) db++;
                    i = i / 2;
                }
                return db;
            }*/

            static bool IsSymmetrical(int num)
            {
                bool result = false;
                string numm = num.ToString(); //to string so i can revers it
                if (string.Concat(numm.Reverse()) == numm) //concat to join the chars due to reverse method
                {
                    result = true;
                }
                return result;
            }

            static string GetMiddle(string str)
            {
                return str.Substring((str.Length - 1) / 2, 2 - (str.Length % 2));
            }
        }
    }
}