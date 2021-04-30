class Program {



        static void Main(string[] args)
        {
             //anonymous  used as a parameter for the delegate.
             
            // anonymous method-1
            cal calculate = (int num1, int num2) =>  num1 + num2 ;
            
             Console.WriteLine(calculate(4, 5));


            // anonymous method-2
            cal[] operation = { (int a, int b) => a * b ,
                                 (int a, int b) => a + b ,
                                 (int a, int b) => a - b


             };

             foreach (var op in operation)
             {
                 Console.WriteLine(op(3, 2));
             }
}


        delegate int cal(int a, int b);
        
        }
