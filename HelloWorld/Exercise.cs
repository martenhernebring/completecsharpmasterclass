using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static void Run()
		{
			int i = -10;

			while (true)
			{
				if (i >= 10)
				{
					break;
				}
				else if (i % 3 == 0)
				{
					i++;
					continue;
				}
				Console.WriteLine(i++);
			}
		}
	}
}
