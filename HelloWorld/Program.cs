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
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int column = 0; column < matrix.GetLength(1); column++)
				{
					Console.Write(matrix[row, column] + " ");
				}
			}
		}
	}
}
