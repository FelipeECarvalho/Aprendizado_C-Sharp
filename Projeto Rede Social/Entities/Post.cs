using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Rede_Social.Entities
{
	class Post
	{
		public Perfil Perfil { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int Avaliation { get; set; }
		public DateTime Moment { get; set; }
		public List<Comment> Comments { get; set; } = new List<Comment>();

		public Post()
		{ 
		}

		public void AddComment(Comment comment) {
			Comments.Add(comment);
		}

		public void Like() {
			Avaliation += 1;
		}

		public void Deslike()
		{
			Avaliation -= 1;
		}

		public Post(Perfil perfil, string title, string content)  
		{
			Perfil = perfil;
			Title = title;
			Content = content;
			Moment = DateTime.Now;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine();
			sb.Append("Title: ");
			sb.AppendLine(Title);
			sb.AppendLine();
			sb.Append("Content: ");
			sb.AppendLine(Content);
			sb.AppendLine();
			sb.Append("Likes: ");
			sb.Append(Avaliation);
			sb.Append(" - ");
			sb.Append(Perfil.Name);
			sb.Append(", ");
			sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm"));
			sb.AppendLine();
			return sb.ToString();
		}

	}
}
