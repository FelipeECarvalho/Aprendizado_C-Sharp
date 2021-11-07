using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_06.Entities
{
	class BusinessAccount : Account
	{
		public double LoanLimit { get; set; } = 1000;

		public BusinessAccount() 
		{
		}

		public BusinessAccount(int number, string holder, double balance) :	base(number, holder, balance) 
		{
		}

		public void Loan(double amount) {
			if (!(amount >= LoanLimit))
			{
				Balance += amount;
				LoanLimit -= amount;
			}
		}
	}
}
