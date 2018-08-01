using System;

namespace BankAccount
{
	public class BankAccount : IBankAccount
	{
		int ID = 0;
		double AccountBalance;
		string AccountHolderName = "";

		public double GetBalance()
		{
			Console.WriteLine("Your Balance is: " + AccountBalance);
			Console.ReadLine();
			return AccountBalance;
		}

		public void Deposit()
		{
			double amount;
			Console.WriteLine("Enter the amount you would like to deposit...");
			amount = Convert.ToDouble(Console.ReadLine());

			AccountBalance = AccountBalance + amount;

			Console.WriteLine("Your new total is: " + AccountBalance);
			Console.ReadLine();
		}

		public void Withdraw()
		{
			double amount;
			Console.WriteLine("Enter the amount you would like to Withdraw...");
			amount = Convert.ToDouble(Console.ReadLine());

			AccountBalance = AccountBalance - amount;

			Console.WriteLine("Your new total is: " + AccountBalance);
			Console.ReadLine();
		}

		public virtual void StartAccountMenu()
		{
			Console.WriteLine("Please select one of the following options...");
			Console.WriteLine("1. Balance");
			Console.WriteLine("2. Deposit");
			Console.WriteLine("3. Withdraw");
		}
	}
}

