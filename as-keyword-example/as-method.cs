class program{
       
       
       static void Main(string[] args)
        {

             // as keyword idea
             object value = "M";
             string anotherValue = value as string;

            //  Console.WriteLine(anotherValue);

            // Console.WriteLine(anotherValue.GetType());



            object[] o = new object[5] { "Hi", 1, "HELLO", 45.6, null };

              isNull(o);

}
// this method is take object and check if return is not null then print 
 public static void isNull(object[] o) {


            for (int i = 0; i < o.Length; i++)
            {
                String str = o[i] as string;

                if (str != null)
                {
                    Console.WriteLine(" , " + str + " ' ");
                }
                else
                {
                    Console.WriteLine("not a string");
                }
            }
            }
