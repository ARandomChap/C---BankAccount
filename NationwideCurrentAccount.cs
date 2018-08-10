using System;

namespace BankAccount
{
	public class NationwideCurrentAccount : BankAccount
	{
		double Interest = 1.0253; /* Interest % for one year */
		int Period = 1; /* one year */

		public override void StartAccountMenu()
		{
			base.StartAccountMenu();

			Console.WriteLine("4. Overdraft");
			var result = Console.ReadLine();

			int val;
			bool ifSuccess = int.TryParse(result, out val);

			if (ifSuccess)
			{
				Selecter(val);
			}
		}

		public void Overdraft()
		{
			Console.WriteLine("Overdraft Added.");
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
					Overdraft();
					break;
			}
		}
	}
}
