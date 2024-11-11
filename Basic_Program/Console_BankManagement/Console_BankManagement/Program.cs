public class BankAccount
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
        Console.WriteLine($"Account created for {AccountHolder} with an initial balance of {Balance:tk}");

    }
    public void Deposit(decimal amount)
    {
        if(amount >0)
        {
            Balance += amount;
            Console.WriteLine($"{amount:tk} deposited successfully! New Balance: {Balance:tk}");
        }
        else
        {
            Console.WriteLine($" Deposit Amount must be in positive ");
        }
    }
    public void WithDraw(decimal amount)
    {
        if (amount > 0 && amount<=Balance)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:tk} withdrawn successfully! New Balance: {Balance:tk}");

        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
        }
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Cuurent balance for {AccountHolder} :{Balance}");
    }
}
class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Account holder name : ");
        string name= Console.ReadLine();
        Console.Write("Enter initial Balance : ");
        decimal InitialBalance= decimal.Parse( Console.ReadLine() );
        BankAccount account = new BankAccount(name , InitialBalance);
        while (true)
        {
            Console.WriteLine($"\n Bank Account Management System");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. WithDraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");


            string choice= Console.ReadLine();
            switch(choice) 
            {
                case "1":
                    Console.Write("Enter deposit amount: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                    case "2":
                    Console.Write("Enter Withdraw amount :");
                    decimal WithdrawAmount= decimal.Parse(Console.ReadLine());
                    account.WithDraw(WithdrawAmount);
                    break;
                    case "3":
                    account.ShowBalance();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Bank Account Management System.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }

        }
    }
}
