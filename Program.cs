/*****************************************************************
 * Name: Jason D'Oyley
 * Date: Oct. 6, 2022
 * Assignment CIS214 Week 1 GP - Account Class
 *
 * Main application (program) class.
 * In this application we will create (instantiate) objects of type
 * Account, use the Account object methods to modify the initial
 * Account data, and print the data to the console.
*/
public class AccountTest
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nJason D'Oyley - Week 1 GP Account Class\n");

        // Create 2 instances of the Account class
        Account acct1 = new Account("Jane Green", 50.00);
        Account acct2 = new Account("John Blue", -7.53);

        // Display the initial balances of each account
        Console.WriteLine("{0} balance: ${1:f2}", acct1.Name, acct1.Balance);
        Console.WriteLine("{0} balance: ${1:f2}", acct2.Name, acct2.Balance);

        // Get a deposit amount for each person's account
        Console.Write("\nEnter deposit amount for Jane's account: $");

        // Get the value from the user - note that we declare "val" as
        // string? rather than string - the ? means that the type can
        // be null; if we don't do that a warning is generated when
        // compiling
        string? val = Console.ReadLine();
        double deposit = Convert.ToDouble(val);
        Console.WriteLine("Adding ${0:F2} to Jane's account\n", deposit);
        acct1.Deposit(deposit);

        Console.Write("\nEnter deposit amount for John's account: $");
        val = Console.ReadLine();
        deposit = Convert.ToDouble(val);
        Console.WriteLine("Adding ${0:F2} to John's account\n", deposit);
        acct2.Deposit(deposit);

        // Display the balances of each account
        Console.WriteLine("{0} balance: ${1:F2}", acct1.Name, acct1.Balance);
        Console.WriteLine("{0} balance: ${1:F2}", acct2.Name, acct2.Balance);
    }
}