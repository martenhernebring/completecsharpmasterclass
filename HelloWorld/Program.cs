using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			int current, total = 0, count = 0;
			do
			{
				Console.Write("Enter current student score: ");
				if(int.TryParse(Console.ReadLine(), out current))
				{
					if (current == -1)
					{
						break;
					}
					Console.WriteLine("Score {0} was entered correctly", current);
					total += current;
					count++;
				}
				else
				{
					Console.WriteLine("Score wasn't entered correctly! Please try again");
				}
			} while (true);
			Console.WriteLine("The average score was {0}.", (double) total / count);
		}
	}
}
