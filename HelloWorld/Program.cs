using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int temp = 105;
			string state;
			state = temp < 0 ? "solid" : (temp > 99 ? "gas" : "liquid");
			Console.WriteLine("State of matter is {0}", state);
		}
	}
}
