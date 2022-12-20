using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter factor one: ");
			string factor1 = Console.ReadLine();
			Console.Write("Enter factor two: ");
			string factor2 = Console.ReadLine();
			Console.WriteLine("The sum is {0}", Add(factor1, factor2));
		}

		private static int Add(string factor1, string factor2)
		{
			return Int32.Parse(factor1) + Int32.Parse(factor2);
		}
	}
}
