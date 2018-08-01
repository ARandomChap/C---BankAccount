using System;

namespace BankAccount
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Press enter to start...");
			//var something = Console.ReadLine();

			while (true)
			{
				Console.WriteLine("Please select option 1 (Current Account), 2 (Savings Account) or 3 (Student Account).");
				var result = Console.ReadLine();

				int val;
				bool ifSuccess = int.TryParse(result, out val);

				if (ifSuccess)
				{
					var account = Selecter(val);

					account.StartAccountMenu();
				}
			}
		}

		public static IBankAccount Selecter(int account)
		{
			switch(account)
			{
				case 1:
					return new CurrentAccount();

				case 2:
					return new SavingsAccount();

				case 3:
					return new StudentAccount();
			}
			return null;
		}
	}
}