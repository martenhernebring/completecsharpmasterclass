using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Register new user.");
			Console.Write("Please enter your new username: ");
			string registeredUser = Console.ReadLine();
			Console.Write("Please enter your new password: ");
			string registeredPassword = Console.ReadLine();
			Console.WriteLine("Login");
			Console.Write("Please enter your username: ");
			string userName = Console.ReadLine();
			if (userName.Equals(registeredUser))
			{
				Console.Write("Please enter your password: ");
				string userPassword = Console.ReadLine();
				if (userPassword.Equals(registeredPassword))
				
					Greet(userName);
				
			}
		}

		private static void Greet(string userName)
		{
			Console.Write("Hi there, ");
			if (userName.ToLower().Equals("admin"))

				Console.WriteLine("admin user");

			else if (userName != "")

				Console.WriteLine(userName);

			else

				Console.WriteLine("registered user");

		}
	}
}
