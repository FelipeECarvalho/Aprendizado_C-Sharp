using System;

namespace Projeto_05 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Frase do dia: ");
			foreach (char palavra in "Olá Mundo!") {
				Console.WriteLine(palavra);
			}

			DateTime hoje = DateTime.Now;
			string today = hoje.ToString();
			Console.WriteLine("Dia de hoje: ");
			foreach (char word in today) {
				Console.WriteLine(word);
			}
		}
	}
}
