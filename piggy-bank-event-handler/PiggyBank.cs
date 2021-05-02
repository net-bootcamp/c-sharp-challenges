      class Program
    {
        static void Main(string[] args)
        {
            PiggyBank pb = new PiggyBank();
            BalanceLogger bl = new BalanceLogger();
            BalanceWatcher bw = new BalanceWatcher();

            pb.balaneChanged += bl.balanceLog; 
            pb.balaneChanged += bw.balanceWatch; 

            string theStr;
            do
            {
                Console.WriteLine("How much to deposit?");
                theStr = Console.ReadLine();
                if (!theStr.Equals("exit"))
                {
                decimal newValue = decimal.Parse(theStr);//يحول القيمه الي يدخله المستخدم الى ديسمل 
                    pb.theBalance += newValue; // هنا في كل مره يزود قيمه البلنس الي بالكلاس الاساسي

                }
            }
            while (!theStr.Equals("exit")); 

            }
        }
     public delegate void BankEventHandler(decimal theValue);
    class PiggyBank
    {
        private decimal m_bankBalance;
        public event BankEventHandler balaneChanged; // event any change will be here .
        public decimal theBalance
        {
            set
            {
                m_bankBalance = value;
                balaneChanged(value);
            }
            get
            {
                return m_bankBalance;
            }
        } }
        class BalanceLogger
    {
        public void balanceLog(decimal amount)
        { //event handler
            Console.WriteLine("The balance amount is {0}", amount);
        }
    }
    class BalanceWatcher
    {
        public void balanceWatch(decimal amount)
        {//event handelr
            if (amount > 500.0m)
                Console.WriteLine("You reached your savings goal ! you have {0}", amount);
        }
    }
