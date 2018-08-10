using System;

namespace BankAccount
{
	public class NationwideRegularSavers : BankAccount
	{
		public override void StartAccountMenu()
		{
			base.StartAccountMenu();

			Console.WriteLine("4. Request access stats");
			var result = Console.ReadLine();

			int val;
			bool ifSuccess = int.TryParse(result, out val);

			if (ifSuccess)
			{
				Selecter(val);
			}
		}
	
		public void AccessStats()
		{
			Console.WriteLine("Access restricted, account still in probationary state.");
			Console.ReadLine();
		}

		public void Selecter(int option)
		{
			switch (option)
			{
				case 1:
					GetBalance();
					break;

				case 2:
					Deposit();
					break;

				case 3:
					Withdraw();
					break;

				case 4:
					AccessStats();
					break;

			}
		}
	}
}
