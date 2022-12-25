using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Console.Write("Enter current Celcius degrees in numbers: ");
			if (int.TryParse(Console.ReadLine(), out int degrees))
			{
				string feedback = degrees <= 15 ? "it is too cold here" : degrees <= 24 ? "it is ok" : "it is hot here";
				Console.WriteLine(feedback);
			}
			else
			{
				Console.WriteLine("Not a valid Temperature");
			}
		}
	}
}
