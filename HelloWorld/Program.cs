using System;

namespace HelloWorld
{
	internal class Program
	{
		private static string _registeredUser;
		private static string _registeredPassword;

		static void Main(string[] args)
		{
			RegisterUser();
			string result = Login();
			if (result.Equals(""))

				Greet(_registeredUser);

			else

				Console.WriteLine(result);

		}

		private static void RegisterUser()
		{
			Console.WriteLine("Register new user.");
			Console.Write("Please enter your new username: ");
			_registeredUser = Console.ReadLine();
			Console.Write("Please enter your new password: ");
			_registeredPassword = Console.ReadLine();
			Console.WriteLine("Registration completed");
			Console.WriteLine("-------------------------------------------");
		}

		private static string Login()
		{
			Console.WriteLine("Login");
			Console.Write("Please enter your username: ");
			string userName = Console.ReadLine();
			if (userName.Equals(_registeredUser))
			{
				Console.Write("Please enter your password: ");
				string userPassword = Console.ReadLine();
				if (userPassword.Equals(_registeredPassword))

					return "";

				else

					return "Login failed, wrong password. Restart program";

			}
			else

				return "Login failed, wrong username. Restart program";

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
