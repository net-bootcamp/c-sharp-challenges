class program{
        //ميثود تستقبل Tuple as parameter 
        static void Display(Tuple<int, string, string> person)
        {
            Console.WriteLine("id : " + person.Item1);
            Console.WriteLine("First name : " + person.Item2);
            Console.WriteLine("Last name :  " + person.Item3);
        }

        // الميثود ترجع Tuple
        static Tuple<int, string, string> Display()
        {

            return Tuple.Create(1, "TAIF", "EID");
        }

        static Tuple<int, string> printInfo(int id, String name)
        {
            return Tuple.Create(id, name);


        }
        
        static void Main(string[] args)
        {

            //Way-1

            Tuple<int, string, bool> tuply = new Tuple<int, string, bool>(1, "taif", true);
            var tuples = Tuple.Create(1, "taif", true);
            // Console.WriteLine(tuples.Item2);
            // Console.WriteLine(tuples.Item3);

            // item 1 = first truple exits


            //Way-2

            var tupls = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

            //Console.WriteLine(tupls.Rest.Item1.Item2);

            var person = Tuple.Create(9, "TAIF", "EID");

             // Display(person);

            // Console.WriteLine( Display());

             string name = "Taif Eid";
             int id = 9;

             var tupele = printInfo(id, name);

            //  Console.WriteLine(tupele.Item1);
            //  Console.WriteLine(tupele.Item2);
            }
            }
