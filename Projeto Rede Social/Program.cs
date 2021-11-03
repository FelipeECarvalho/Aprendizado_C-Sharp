using System;
using Projeto_Rede_Social.Entities;

namespace Projeto_Rede_Social
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the login's data: ");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Email: ");
			string email = Console.ReadLine();
			Console.Write("BirthDate: ");
			DateTime birthDate = DateTime.Parse(Console.ReadLine());
			Perfil login = new Perfil(name, email, birthDate);

			Menu menu = new Menu();
			while (menu.Opcao != 4)
			{
				Console.WriteLine(menu);
				Console.Write("Sua opção: ");
				menu.Opcao = int.Parse(Console.ReadLine());
				switch (menu.Opcao)
				{
					case 1:
						Console.Write("Title: ");
						string title = Console.ReadLine();
						Console.Write("Content: ");
						string content = Console.ReadLine();
						Post posted = new Post(login, title, content);
						login.AddPost(posted);
						break;
					case 2:
						int i = 1;
						foreach (Post post in login.Posts) {
							Console.WriteLine($"Post #{i}");
							Console.WriteLine(post);
							foreach (Comment comment in post.Comments) {
								Console.WriteLine(comment);
							}
							Console.WriteLine();
							i++;
						}

						break;
					case 3:
						Console.Write("Title of post that will be commented: ");
						string commentedPost = Console.ReadLine().ToLower().Trim();
						foreach (Post post in login.Posts)
						{
							if (post.Title.ToLower().Trim() == commentedPost)
							{
								Console.Write("Your name: ");
								string commenterName = Console.ReadLine();
								Console.Write("Comment: ");
								string content1 = Console.ReadLine();
								Console.Write("Avaliation of the post (1 - Like/ 0 - Deslike): ");
								int avaliation = int.Parse(Console.ReadLine());
								if (avaliation == 1)
									post.Like();
								else if (avaliation == 0)
									post.Deslike();
								Comment comment = new Comment(commenterName, content1, avaliation);
								post.AddComment(comment);
							}
						}
						break;
					case 4:
						break;
					default:
						Console.WriteLine("Invalid value");
						break;
				}
			}

		}
	}
}
