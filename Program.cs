using System;
class program
{
    public static void Main()
    {
        int amount = 0, deposit, withdraw;
        int choice, pin = 0;
        Console.WriteLine("Skriv in din pin kod");
        pin = int.Parse(Console.ReadLine());
        var atm = new Atm();
        while (true)
        {
            MenuMethod();
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TackMethod();
                    break;
                case 2:
                    Console.WriteLine("\n Hur mycket vill du ta ut? : ");
                    withdraw = int.Parse(Console.ReadLine());
                    if (withdraw < 5000)
                    {
                        Console.WriteLine("\n Snälla skriv ett värde under 5000");
                    }
                    else if (withdraw > (amount - 1000))
                    {
                        Console.WriteLine("\n Förlåt, för lite pengar finns på kontot");
                    }
                    else
                    {
                        amount = amount - withdraw;
                        Console.WriteLine("\n Var snäll och ta pengarna");
                        TackMethod();
                    }
                    break;
                case 3:
                    Console.WriteLine("\n Hur mycket vill du ta ut från sparkkonto? : ");
                    withdraw = int.Parse(Console.ReadLine());
                    if (withdraw < 10000) { Console.WriteLine("\n Snälla skriv ett värde under 10000"); }
                    else if (withdraw > (amount - 1000))
                    {
                        Console.WriteLine("\n Förlåt, för lite pengar finns på kontot");
                    }
                    else
                    {
                        amount = amount - withdraw;
                        TackMethod();
                    }
                    break;
                case 4:
                    Console.WriteLine("\n Hur mycket vill du deposita?");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("/n Ditt värde har successfullt updaterats.");
                    TackMethod();
                    break;
                case 5:
                    Console.WriteLine("\n Hur mycket vill du deposera i sparkontot?");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("/n Ditt värde har successfullt updaterats.");
                    Console.WriteLine("\n Din nuvarande balance är sek : {0} ", amount);
                    TackMethod();
                    break;
                case 6:
                    TackMethod();
                    break;
                case 7:
                    atm.CreateAccount();
                    break;
            }
        }
    }
    public static void TackMethod()
    {
        Console.WriteLine("\n Tack för att du använt vår atm tjänst");
    }
    private static void MenuMethod()
    {
        Console.WriteLine("Välkommen till atm\n");
        Console.WriteLine("1. nuvarande Balance\n");
        Console.WriteLine("2. Ta ut från konto from \n");
        Console.WriteLine("3. Ta ut från sparkonto from \n");
        Console.WriteLine("4. Deposit i konto\n");
        Console.WriteLine("5. Deposit i sparkonto \n");
        Console.WriteLine("6. Cancel \n");
        Console.WriteLine("***************\n\n");
        Console.WriteLine("ENTER YOUR CHOICE : ");
    }
    internal class Atm

{
    public List<Account> Accounts { get; set; }
    public List<Adminaccount> Adminaccounts { get; set; }

    public Atm()
    {
        Accounts = new List<Account>();
        Adminaccounts = new List<Adminaccount>();
    }

    public void CreateAccount()
    {
        var account = new Account();

        Console.WriteLine("Skapar ett nytt konto!!!");
        Console.WriteLine();
        Console.Write("Skriv ditt förstanamn: ");
        account.FirstName = Console.ReadLine();
        Console.Write("Skriv ditt efternamn: ");
        account.LastName = Console.ReadLine();
        Console.Write("Skriv Födelsedatum: ");
        account.DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Skriv ditt telefonummer: ");
        account.PhoneNumber = Console.ReadLine();

        account.Balance = 0.0;
        account.Id = Accounts.Count + 1;

        Accounts.Add(account);
    }
    public void CreateAdminAccount()
    {
        var adminaccount = new Adminaccount();

        Console.WriteLine("Skapar ett nytt konto!!!");
        Console.WriteLine();
        Console.Write("Skriv ditt adminnamn: ");
        adminaccount.AdminName = Console.ReadLine();
        Console.Write("Skriv ditt förstanamn: ");
        adminaccount.FirstName = Console.ReadLine();
        Console.Write("Skriv ditt efternamn: ");
        adminaccount.LastName = Console.ReadLine();
        Console.Write("Skriv Födelsedatum: ");
        adminaccount.DateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Skriv ditt telefonummer: ");
        adminaccount.PhoneNumber = Console.ReadLine();

        adminaccount.Balance = 0.0;
        adminaccount.Id = 6969;

        Adminaccounts.Add(adminaccount);
    }
}
}
