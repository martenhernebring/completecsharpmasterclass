using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Write your current temperature: ");
			string input = Console.ReadLine();
			if (int.TryParse(input, out int temperature))

				Console.WriteLine("That is a valid temperature: {0}", temperature);

			else

				Console.WriteLine("Enter a number next time");

		}

	}
}
