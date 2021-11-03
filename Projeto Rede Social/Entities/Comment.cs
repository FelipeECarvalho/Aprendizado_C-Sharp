using System;
using Projeto_Rede_Social.Entities;
using System.Text;

namespace Projeto_Rede_Social.Entities
{
	class Comment
	{
		public string Name { get; private set; }
		public string Content { get; set; }
		public int Avaliation { get; set; }
		public DateTime Moment { get; private set; }


		public Comment() 
		{
		}

		public Comment(string nome, string content, int avaliation)
		{
			Name = nome;
			Content = content;
			Avaliation = avaliation;
			Moment = DateTime.Now;
		}


		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Comment: ");
			sb.AppendLine(Content);
			sb.Append("Avaliation: ");
			sb.AppendLine((Avaliation == 1) ? "Like - ":"Dislike - " );
			sb.Append(Name);
			sb.Append(" - ");
			sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm"));
			return sb.ToString();
		}

	}
}
