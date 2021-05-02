using System;
namespace BasicEvents
{ // فكرة هالبرنامج ان كل مره يغير القيمه الي يدخله اليوزر ويعرضها يعني مثلا يدخل واحد يحدث ويغير القيمه بواحد وهكذا 
    // define the delegate for the event handler
    public delegate void myEventHandler(string value);
    class EventPublisher
    {
        private string theVal;
        // declare the event
        public event myEventHandler valueChanged;
        public string Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher obj = new EventPublisher();
            // use a named function as an event handler
            obj.valueChanged += obj_valueChanged;
            string str;
            do
            {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }
        static void obj_valueChanged(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
    }
}
