using System;
using System.Globalization;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "Morten";
			string job = "Developer";
			int age = 36;
			Console.WriteLine("Hello my name is {0}, I am {1} years old. I'm a {2}", name, age, job);
			Console.WriteLine($"Hello my name is {name}, I am {age} years old. I'm a {job}");
		}
	}
}
