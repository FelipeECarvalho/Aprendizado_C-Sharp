using System;
using Projeto_06.Entities;

namespace Projeto_06
{
	class Program
	{
		static void Main(string[] args)
		{
			Account acc = new Account(8001, "Alberto", 700);
			Account sacc = new SavingsAccount(567, "Mria", 700, 1);
			SavingsAccount sacc1 = new SavingsAccount(564, "Alex", 700, 1);
			acc.Withdraw(10);
			sacc.Withdraw(10);
			sacc1.Withdraw(10);
			Console.WriteLine(acc.Balance);
			Console.WriteLine(sacc.Balance);
			Console.WriteLine(sacc1.Balance);


		}
	}
}
