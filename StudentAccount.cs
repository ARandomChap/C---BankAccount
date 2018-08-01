using System;

namespace BankAccount
{
	public class StudentAccount : BankAccount
	{
		public override void StartAccountMenu()
		{
			Console.WriteLine("Please select option 1 (Balance), 2 (Deposit) or 3 (Withdraw).");
			var result = Console.ReadLine();

			int val;
			bool ifSuccess = int.TryParse(result, out val);


			if (ifSuccess)
			{
				Selecter(val);
			}
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
			}

		}
	}
}
