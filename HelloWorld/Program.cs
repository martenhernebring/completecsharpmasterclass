using System;
using System.Globalization;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string unknown;
			Console.Write("Please enter your name and press enter : ");
			unknown = Console.ReadLine();
			Console.WriteLine(string.Format("Upper case : {0}", unknown.ToUpper()));
			Console.WriteLine(string.Format("Lower case : {0}", unknown.ToLower()));
			Console.WriteLine(string.Format("Trimmed : {0}", unknown.Trim()));
			Console.WriteLine(string.Format("Without first char : {0}", unknown.Substring(1)));
		}
	}
}
