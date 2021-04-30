class Program {

// "params" keyword  allows a method to accept a variable number of arguments.


        // method takes any type of data > object
        public static void UseParams(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
        
        // method hold int type just of data 
        public static void UseParams2(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            // we can pass any type of data because is array of object 
             UseParams(1, 2, 3, 4);
             UseParams("1", 7, "Taif");


            
             int[] myArray = { 5, 6, 7, 8, 9 };
             UseParams2(myArray); // just pass int value 
}
}
