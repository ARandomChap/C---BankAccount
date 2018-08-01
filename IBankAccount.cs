namespace BankAccount
{
	public interface IBankAccount
	{
		void Deposit();

		double GetBalance();

		void Withdraw();

		void StartAccountMenu();
	}
}