using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int temp = -5;
			string state = "";
			//if (temp < 0)
			//{
			//	state = "solid";
			//}
			//else
			//{
			//	state = "liquid";
			//}
			state = temp < 0 ? "solid" : "liquid";
			Console.WriteLine("State of matter is {0}", state);
		}
	}
}
