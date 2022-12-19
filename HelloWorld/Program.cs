using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string myString = "15d";
			string mySecondString = "13";
			int num1 = Int32.Parse(myString);
			int num2 = Int32.Parse(mySecondString);
			Console.WriteLine(num1 + num2);
		}
	}
}
