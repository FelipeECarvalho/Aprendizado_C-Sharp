using System;
using Projeto_05.Entities;
using Projeto_05.Entities.Enums;

namespace Projeto_05
{
	class Program
	{
		static void Main(string[] args)
		{
			Order product = new Order
			{
				Id = 1080,
				Moment = DateTime.Now,
				Status = 0
			};

			Console.WriteLine(product);
			string txt = OrderStatus.PendingPayment.ToString();
			OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
			Console.WriteLine(txt);
			Console.WriteLine(os);
		}
	}
}
