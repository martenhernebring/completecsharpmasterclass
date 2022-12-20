using System;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int dividend = 1;
			int divisor = 0;
			try
			{
				int divideByZero = dividend / divisor;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Internal error: Divide by zero");
			}
			finally
			{
				//close open connections
			}
		}

	}
}
