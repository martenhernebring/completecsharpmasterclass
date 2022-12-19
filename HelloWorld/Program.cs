using System;
using System.Globalization;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a string here: ");
			string enteredString = Console.ReadLine();
			Console.Write("Enter the character to search: ");
			int searchedCharAscii = Console.Read();
			//alternative Console.ReadLine()[0]
			Console.WriteLine(String.Format("First index of char is {0}", enteredString.IndexOf((char) searchedCharAscii)));
			//flush new lines
			Console.ReadLine();
			Console.Write("Enter first name: ");
			string fullName = Console.ReadLine();
			Console.Out.Flush();
			Console.Write("Enter last name: ");
			fullName = string.Concat(fullName, " ", Console.ReadLine());
			Console.WriteLine("Your full name is {0}", fullName);
		}
	}
}
