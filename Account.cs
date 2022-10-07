/*****************************************************************
 * Name: Jason D'Oyley
 * Date: Oct. 6, 2022
 * Assignment CIS214 Week 1 GP - Account Class
 *
 * Account class.
 * This cass represents an account, such as a bank account, with an
 * individual's name and the balance associated with the account. A
 * getter and setter are provided for the name property; a getter is
 * provided for the balance along with a deposit method to add an
 * amount to the balance.
 *
 * Note that error checking is done on the initial balance and the
 * deposit amounts to ensure they are greater than 0, and that the
 * balance cannot be set other that via the constructor - the only
 * way to modify the balance is via a deposit.
*/
public class Account
{
    // Class properties - in C#, there is no need to declare a separate,
    // private instance variable - creating the get and set on the property
    // implies private instance variables

    // Name is fully-accessible property; values may be read and updated
    // directly
    public string Name { get; set; }

    // Make Balance a read-only property - values may be read but cannot be
    // written to the property other than by class functions
    public double Balance { get; private set; }

    // Constructor takes 2 parameters to set the instance variables
    public Account(string name, double balance)
    {
        Name = name;

        // Validate the balance provided - if it is greater than 0,
        // set the instance variable to the value provided; otherwise
        // leave the instance variable as the default 0.0
        if (balance > 0.0)
        {
            Balance = balance;
        }
    }

    // Method to deposit (add) an amoount to the balance, if it is valid
    public void Deposit(double amount)
    {
        if (amount > 0.0)
        {
            Balance = Balance + amount;
        }
    }
}