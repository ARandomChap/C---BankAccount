using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
	class CurrentAccount
	{
		//double balance = 1234;

		public double Account()
		{
			var account = new BankAccount();

			double Balance = Convert.ToDouble(account.GetBalance());

			return Balance;
		}
		
	}
}
