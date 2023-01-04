using Coding.Exercise;
using System;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			int min = MinValue(new int[]{3, 2, 1, 0});
			Console.WriteLine(min);
		}

		public static int MinValue(params int[] numbers)
		{
			int min = int.MaxValue;
			foreach (int number in numbers)
			{
				if (number < min) 
				{
					min = number;
				}
			}
			return min;
		}

	}
}