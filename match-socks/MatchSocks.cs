    class Program
    {
        static void Main(string[] args)
        {
            string sock = "ABBAA";

            Console.WriteLine(IsMatching(sock));
          

        }


        public static int IsMatching(string sock)
        {
            int count = 0;
            char[] array = sock.ToCharArray();
            Array.Sort(array);
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]==array[i-1])
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

    }
