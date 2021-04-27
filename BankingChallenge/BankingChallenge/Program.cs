using System;
//continue
namespace BankingChallenge
{

    public  class BankAccount
    {
        //fieled Name start with small and second word capital or strat with underscore
        private string _firstName;
        private string _lastName;
        public decimal Balance
        {
            get; set;

        }
        public BankAccount(string fname, string lname, decimal initial = 0.0m)
        {
            _firstName = fname;
            _lastName = lname;
            Balance = initial;
        }
        
        public string AccountOwnwr
        {

            get => $"{_firstName} {_lastName}";
        }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;

        }
        public virtual void Withdraw(decimal amount) 
        {

            Balance -= amount;
        }

        
        
    }
    public class CheckingAcct : BankAccount
    {
        public CheckingAcct(string fname, string lname, decimal initial) : 
            base(fname, lname, initial)
        {
        }
        public override void Withdraw(decimal amount)
        {

            if (amount > Balance)
            {
                Console.WriteLine("Attempt to overdraw saving - denied");
            }
            else
            {
                base.Withdraw(amount);
            }
        }

    }
    public class SavingsAcct : BankAccount
    {
        private int _withdrawcount = 0;
        private const decimal WITHDRAW_CHARGE= 2.0m;
        private const int WITHDRAW_LIMIT = 3;
        public SavingsAcct(string fname, string lname, decimal initial) 
            :base (fname, lname , initial)
        {
            
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Attempt to overdraw saving - denied");

            }
            else
            {
                base.Withdraw(amount);
            }
            _withdrawcount++;
            if (_withdrawcount > WITHDRAW_LIMIT)
            {
                Console.WriteLine("More than 3 withdrawls - extra charge");
                base.Withdraw(WITHDRAW_CHARGE);
            }

            
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Checking Account with initial balance
            CheckingAcct checking = new CheckingAcct("Ahmad", "Nasser", 2500.0m);
            // Create the Savings Account with interest and initial balance
            SavingsAcct saving = new SavingsAcct("Ahmad", "Nasser", 1000.0m);
            // Check the balances
            // Expected output should be 2500 and 1000 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // Print the account owner information. Expected output: 
            // "Checking owner: Ahmad Nasser"
            // "Savings owner: Ahmad Nasser"
            Console.WriteLine($"Checking owner: {checking.AccountOwnwr}");
            Console.WriteLine($"Savings owner: {saving.AccountOwnwr}");
            // Deposit some money in each account
            checking.Deposit(200.0m);
            saving.Deposit(150.0m);
            // Check the balances
            // Expected output should be 2700 and 1150 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // Make some withdrawals from each account
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);
            // Check the balances
            // Expected output should be 2650 and 1025 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // More than 3 Savings withdrawals should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
            // Savings balance should now be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // try to overdraw savings - this should be denied and print message
            saving.Withdraw(2000.0m);
            // try to overdraw checking - this should be denied and print message
            checking.Withdraw(3000.0m);
            // Expected output should be -2650 and 988.63
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
        }
    }
}
