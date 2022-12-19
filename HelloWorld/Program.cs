using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a string a press enter:");
			string readInput = Console.ReadLine();
			Console.WriteLine("You have entered {0}", readInput);
			Console.Write("Enter any key and press enter");
			int asciiValue = Console.Read();
			Console.WriteLine("ASCII value is {0}", asciiValue);
			Console.ReadKey();
		}
	}
}
