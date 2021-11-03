using System;
using System.Collections.Generic;
namespace Projeto_04 {
	class Program {
		static void Main(string[] args) {
			double x = 3;
			Console.WriteLine(Calculadora.Soma(10, 10, 12, 20, 13));
			Console.WriteLine(Calculadora.Multi(2, 5));
			Calculadora.SomaVariavel(ref x, 10);
			Console.WriteLine(x);
			List<double> resultados = new List<double>();
			
		}
	}
}
