using System;

namespace HelloWorld
{
	public class Program
	{
		private static int[,] matrix =
		{
			{ 1, 2, 3 },
			{4, 5, 6 },
			{7, 8, 9 }
		};

		public static void Main(string[] args)
		{
			int max = matrix.GetLength(0) - 1;
			for (int i = 0; i <= max; i++)
			{
				Console.WriteLine(matrix[i, max - i] + " ");
			}
		}
	}
}
