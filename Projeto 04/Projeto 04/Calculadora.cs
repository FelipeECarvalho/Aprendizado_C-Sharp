using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_04 {
	class Calculadora {

		public static double Soma(params double[] valores) {
			double sum = 0;
			for (int i = 0; i < valores.Length; i++) {
				sum += valores[i];
			}
			return sum;
		}

		public static double Multi(params double[] valores) {
			double sum = 1;
			for (int i = 0; i < valores.Length; i++) {
				sum *= valores[i];
			}
			return sum;
		}

		public static void SomaVariavel(ref double valor, double soma) {
			valor += soma;
		}

	}
}
