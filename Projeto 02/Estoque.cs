namespace Projeto_02 {
	class Estoque {
		private string _nome;
		public double Preco {get; private set;}
		public int Quantidade { get; private set; }


		public string Nome {
			get { return _nome;}
			set {
				if (value != null && value.Length > 1) {
					_nome = value;
				}
			}
		}


		public Estoque(string nome, double preco) {
			_nome = nome;
			Preco = preco;
		}

		public Estoque(string nome, double preco, int quantidade) : this(nome, preco) {
			Quantidade = quantidade;
		}


		public double ValorTotal() {
			return Preco * Quantidade;
		}

		public void AdicionarEstoque(int quant) {
			Quantidade += quant;
		}

		public void RemoverEstoque(int quant) {
			Quantidade -= quant;
		}

		public override string ToString() {
			return _nome + ", R$" + Preco.ToString("F2") + ", " + Quantidade + " unidades, valor total: R$" + ValorTotal().ToString("F2");
		}

	}
}
