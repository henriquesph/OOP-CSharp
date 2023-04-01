using System;
using System.Globalization;
using System.Net.Http.Headers;
using Ex155.Entities.Exeptions;
using Ex155.Entities;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter account data");
            
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit:  ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance, withDrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            acc.WithDraw(amount);
            Console.Write("New Balance: " + acc.Balance, CultureInfo.InvariantCulture);
        }
        catch (DomainExeptions e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.Write("Unexpected error: " + e.Message);
        }
    }
}
