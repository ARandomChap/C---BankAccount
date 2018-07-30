using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("This Outputs onto a cmd screen");
			var something = Console.ReadLine();

			Console.WriteLine("Please select option 1 (Current Account), 2 (Savings Account) or 3 (Student Account).");
			var result = Console.ReadLine();

			if (int.Parse(result) == 1)
			{
				var account = new BankAccount();
				account.StartAccountMenu(1);
			}

			if (int.Parse(result) == 2)
			{
				var account = new BankAccount();
				account.StartAccountMenu(2);
			}

			if (int.Parse(result) == 3)
			{
				var account = new BankAccount();
				account.StartAccountMenu(3);
			}
		}
	}
}
