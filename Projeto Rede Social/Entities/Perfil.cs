using System;
using System.Collections.Generic;


namespace Projeto_Rede_Social.Entities
{
	class Perfil
	{
		public string Name { get; private set; }
		public string Email { get; private set; }
		public DateTime BirthDate { get; private set; }
		public List<Post> Posts { get; private set; } = new List<Post>();

		public Perfil() 
		{
		}

		public Perfil(string name, string email, DateTime birthDate) {
			Name = name;
			Email = email;
			BirthDate = birthDate;
		}

		public void AddPost(Post post) {
			Posts.Add(post);
		}

		public override string ToString()
		{
			return $"Name: {Name}, Email: {Email}, Birthdate: {BirthDate}";
		}
	}
}
