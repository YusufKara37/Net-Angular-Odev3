
static void Main(string[] args)
{
    BankAccount savingsAcount= new SavingsAccount("Yusuf Kara",10000);
    decimal savingsInterest=savingsAcount.CalculateInterest();
    

    BankAccount checkingAccount = new CheckingAccount("Ahmet Kara", 50000);
    checkingAccount.CalculateInterest();
}



