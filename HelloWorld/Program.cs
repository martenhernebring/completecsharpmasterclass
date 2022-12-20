using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WriteSomething();
			Write("test");
		}

		// access modifier (static) return type method name (par1, par2)
		private static void WriteSomething()
		{
			Console.WriteLine("Write something method");
		}

		private static void Write(string text)
		{
			Console.WriteLine(text);
		}
	}
}
