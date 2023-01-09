using System;

namespace Coding.Exercise
{

	public class Exercise
	{
		public static double ConvertToRadians(double angle)
		{
			return (Math.PI / 180) * angle;
		}

		public static void Run(string line)
		{
			int degrees;
			if (int.TryParse(line, out degrees) && degrees >= 0 && degrees <= 180)
			{
				double radians = ConvertToRadians(degrees);
				Console.WriteLine("Cos = {0}", Math.Cos(radians));
				Console.WriteLine("Sin = {0}", Math.Sin(radians));
				Console.WriteLine("Tg = {0}", Math.Tan(radians));
			}
			else
			{
				Console.WriteLine("Check the input!");
			}
		}
	}
}
