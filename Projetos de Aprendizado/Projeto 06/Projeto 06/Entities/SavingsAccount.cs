using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_06.Entities
{
	class SavingsAccount : Account
	{
		public double InterestRate { get; set; }

		public SavingsAccount() 
		{
		}

		public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) 
		{
			InterestRate = interestRate;
		}

		public void AlterBalance(double amount) {
			Balance += (Balance * amount);
		}

		public override void Withdraw(double amount)
		{
			Balance -= amount; ;
		}
	}
}
