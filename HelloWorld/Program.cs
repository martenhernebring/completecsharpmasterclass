using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int age = 15;
			switch (age)
			{
				case 15:
					Console.WriteLine("Too young to party in the club");
					break;
				case 25:
					Console.WriteLine("Good to go");
					break;
				default:
					Console.WriteLine("How old are you then?");
					break;
			}
			string userName = "Morten";
			switch (userName)
			{
				case "Morten":
					Console.WriteLine("User name is Morten");
					break;
				case "root":
					Console.WriteLine("User name is root");
					break;
				default:
					Console.WriteLine("User name is unknown);
					break;
			}
		}
	}
}
