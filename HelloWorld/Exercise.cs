using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static void GetOdd(int[] Array)
		{
			for (int i = 0; i < Array.Length; i++) 
			{
				if (Array[i] % 2 != 0)
				{
					Console.WriteLine(Array[i]);
				}
			}
		}

		public static void GetEven(int[] Array)
		{
			foreach (int current in Array)
			{
				if (current % 2 == 0)
				{
					Console.WriteLine(current);
				}
			}
		}

		public static void Run()
		{
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			GetOdd(array);
			GetEven(array);

		}
	}
}
