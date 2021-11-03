using System;
using System.Globalization;

namespace Primeiro_Projeto {
	class Program {
		static void Main(string[] args) {
			Triangulo x, y;
			x = new Triangulo();
			y = new Triangulo();
			Console.WriteLine("Entre com as medidas do triângulo X: ");
			x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Entre com as medidas do triângulo Y: ");
			y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			double areax, areay;
			areax = x.Calculo_area();
			areay = y.Calculo_area();
			Console.WriteLine("Área de X = " + areax.ToString("F4", CultureInfo.InvariantCulture));
			Console.WriteLine("Área de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));
			if (areax > areay) {
				Console.WriteLine("Maior: X");
			}
			else {
				Console.WriteLine("Maior: Y");
			}
		}
	}
}
