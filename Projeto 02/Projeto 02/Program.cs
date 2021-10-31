using System;
using System.Globalization;
namespace Projeto_02 {
	class Program {
		static void Main(string[] args) {
			Estoque produto = new Estoque("TV", 500, 3);

			Console.WriteLine(produto.Preco);
		}
	}
}
