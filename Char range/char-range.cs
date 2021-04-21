using System;

namespace Class0204_6
{
    class Program
    {
        public static bool insideTheRange(char lookingForChar, char firstRange, char secondRange)
        {
            int firstCount = 0;
            int secondCount = 0;
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            //input give me the first char
            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha[i] == firstRange)
                {
                    firstCount = i;
                }
                if (alpha[i] == secondRange)
                {
                    secondCount = i;
                }
            }
            string subS = alpha.Substring(firstCount, secondCount - firstCount);
            foreach (var item in subS)
            {
                if (subS.Contains(lookingForChar))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(insideTheRange('y','x','z'));
        }
    }
}
