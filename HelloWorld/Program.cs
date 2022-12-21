using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Please enter your username: ");
			string userName = Console.ReadLine();
			if (IsUserRegistered())
			{
				Console.Write("Hi there, ");
				if (userName.ToLower().Equals("admin"))
				
					Console.WriteLine("admin user");
					
				else if(userName != "")

					Console.WriteLine(userName);

				else

					Console.WriteLine("registered user");

			}
		}

		private static bool IsUserRegistered()
		{
			return true;
		}
	}
}
