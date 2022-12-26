using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			string[] friends = { "f1", "f2", "f3", "f4", "f5" };
			foreach (string friend in friends) 
			{
				Console.WriteLine("Hi {0}", friend);
			}
		}
	}
}
