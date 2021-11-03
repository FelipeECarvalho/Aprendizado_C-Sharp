using System.Text;

namespace Projeto_Rede_Social.Entities
{
	class Menu
	{
		public int Opcao = 0;
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("------=== MENU ===------");
			sb.AppendLine("1 - Write a post");
			sb.AppendLine("2 - Visualize a post");
			sb.AppendLine("3 - Comment a post");
			sb.AppendLine("4 - End");
			sb.AppendLine("------===      ===------");
			return sb.ToString();
		}
	}
}
