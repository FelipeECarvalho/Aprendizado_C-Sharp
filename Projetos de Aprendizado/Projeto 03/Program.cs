using System;
using System.Globalization;

namespace Projeto_03 {
	class Program {
		static void Main(string[] args) {
			Teste primeiro = new Teste();
			int n = int.Parse(Console.ReadLine());
			double[] vet = new double[n];
			double altura = 0;
			for (int i = 0; i < n; i++) {
				vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				altura += vet[i];
			}
			Console.WriteLine($"AVERAGE HEIGHT = {(altura / n).ToString("F2")}");
			primeiro.Valor1 = altura;
			primeiro.Valor2 = altura / 3;
			Console.WriteLine($"Altura Total = {primeiro.Valor1}");
			Console.WriteLine($"Media = {(primeiro.Valor2).ToString("F2")}");
		}
	}
}
