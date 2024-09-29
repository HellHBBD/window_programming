using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_1_1
{
  class Account
  {
    static int balance;

    public Account()
    {
      balance = 10000;
    }

    public void check()
    {
      Console.WriteLine("balance: {0}", balance);
    }

    public void withdraw()
    {
      Console.Write("Enter amount: ");
      int amount = 0;
      try
      {
        amount = int.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Amount should be an integer");
        return;
      }

      if (amount < 0 || amount > 100000)
      {
        Console.WriteLine("Exceed the valid amount 0~100000");
        return;
      }
      if (amount > balance)
      {
        Console.WriteLine("Exceed the existing amount");
        return;
      }
      balance -= amount;
      Console.WriteLine("Successfully withdraw");
      check();
    }

    public void deposit()
    {
      Console.Write("Enter amount: ");
      int amount = 0;
      try
      {
        amount = int.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Amount should be an integer");
        return;
      }
      if (amount < 0 || amount > 100000)
      {
        Console.WriteLine("Exceed the valid amount 0~100000");
        return;
      }
      balance += amount;
      check();
    }

    public void transfer()
    {
      Console.Write("Enter account: ");
      int account = 0;
      try
      {
        account = int.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Account should be an integer");
        return;
      }

      Console.Write("Enter amount: ");
      int amount = 0;
      try
      {
        amount = int.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Account should be an integer");
        return;
      }

      amount = (int)(amount * 1.1);
      Console.WriteLine("Final cost (+10%) = {0}", amount);
      balance -= amount;

      if (amount < 0 || amount > 100000)
      {
        Console.WriteLine("Exceed the valid amount 0~100000");
        return;
      }
      if (amount > balance)
      {
        Console.WriteLine("Exceed the existing amount");
        return;
      }
      Console.WriteLine("Successfully transfer");
      check();
    }

  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to NiCKU ATM\n");
      Account account = new Account();
      int option = -1;
      while (true)
      {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("\t(0) check");
        Console.WriteLine("\t(1) withdraw");
        Console.WriteLine("\t(2) deposit");
        Console.WriteLine("\t(3) transfer");
        Console.WriteLine("\t(8) exit");
        try
        {
          option = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
          Console.WriteLine("Please enter a number");
          continue;
        }
        switch (option)
        {
          case 0: //check
            account.check();
            break;
          case 1: //withdraw
            account.withdraw();
            break;
          case 2: //deposit
            account.deposit();
            break;
          case 3: //transfer
            account.transfer();
            break;
          case 8: //exit
            return;
          default:
            Console.WriteLine("There's no option");
            break;
        }
      }
    }
  }
}
