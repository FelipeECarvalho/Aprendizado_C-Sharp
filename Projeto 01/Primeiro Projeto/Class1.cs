using System;

namespace Primeiro_Projeto {
	class Triangulo {
		public double A;
		public double B;
		public double C; 
		public double Calculo_area() {
			double p = (A + B + C) / 2;
			return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
		}
	}
}