using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
	class BankAccount
	{
		int ID = 0;
		double AccountBalance = 0;
		string AccountHolderName = "";

		public double GetBalance()
		{
			return AccountBalance;
		}

		public void Deposit(double amount)
		{
			AccountBalance = AccountBalance + amount;
		}

		public void Withdraw(double amount)
		{
			AccountBalance = AccountBalance - amount;
		}

		public void StartAccountMenu(int account)
		{
			Console.WriteLine("Please select option 1 (Withdraw), 2 (Deposit) or 3 (Balance).");
			var result = Console.ReadLine();

			if (int.Parse(result) == 1)
			{
				Console.WriteLine("Please enter the amount you would like to withdraw.");
				double amount = Convert.ToDouble(Console.ReadLine());

				amount = AccountBalance - amount;

				Console.WriteLine("Your withdrawl has been procoseed.");
			}

			if (int.Parse(result) == 2)
			{
				Console.WriteLine("Please enter the amount you would like to deposit.");
				double amount = Convert.ToDouble(Console.ReadLine());

				amount = AccountBalance + amount;

				Console.WriteLine("Your deposit has been procoseed.");
			}

			if (int.Parse(result) == 3)
			{
				Console.WriteLine("Your balance: " + AccountBalance);
				Console.ReadLine();
			}
		}
	}
}
