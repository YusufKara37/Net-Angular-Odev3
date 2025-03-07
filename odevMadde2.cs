public class BankAccount
{
    public string AccountHolder {get; set;}

    public decimal Balance {get; set;}

    public BankAccount(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public virtual decimal CalculateInterest()
    {
        return 0;
    }
    
}


public class SavingsAccount:BankAccount{
public SavingsAccount(string accountHolder, decimal balance):base(accountHolder, balance)
{

}
    public override decimal CalculateInterest()
    {
        return Balance * 0.05m;
    }

}

public class CheckingAccount:BankAccount
{
      public CheckingAccount(string accountHolder, decimal balance): base(accountHolder, balance)
      {
        
      }    
      public override decimal CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest");
        return 0;
        
    }

}