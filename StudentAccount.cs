using System;

namespace BankAccount
{
	public class StudentAccount : BankAccount
	{
		public override void StartAccountMenu()
		{
			base.StartAccountMenu();

			Console.WriteLine("4. Student loan");
			var result = Console.ReadLine();

			int val;
			bool ifSuccess = int.TryParse(result, out val);

			if (ifSuccess)
			{
				Selecter(val);
			}
		}

		public void StudentLoan()
		{
			Console.WriteLine("You fool, can't believe you're paying £9,000 a year for this XD");
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
					StudentLoan();
					break;
			}

		}
	}
}
