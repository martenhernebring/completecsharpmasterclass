using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Console.Write("Enter a string, integer or boolean: ");
			string input = Console.ReadLine();
			Console.WriteLine("You have entered a value: " + input);
			Console.WriteLine("Press 1 for String, 2 for Integer, 3 for Boolean");
			char key = Console.ReadKey().KeyChar;
			Console.WriteLine();
			bool valid = false;
			string type = "";
			switch (key) 
			{
				case '1':
					type = "String";
					valid = IsAllAlphabetic(input);
					break;
				case '2':
					type = "Integer";
					valid = int.TryParse(input, out int _);
					break;
				case '3':
					type = "Boolean";
					valid = bool.TryParse(input, out bool _);
					break;
				default:
					Console.WriteLine("Only enter a number 1 - 3 next time!");
					Environment.Exit(22);
					break;
			}
			Console.Write("It is {0} : {1}", valid ? "valid" : "invalid", type);
		}

		private static bool IsAllAlphabetic(string input)
		{
			foreach (char ch in input)
			{
				if (!char.IsLetter(ch))
				{
					return false;
				}
			}
			return true;
		}
	}
}
