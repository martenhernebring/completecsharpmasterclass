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
				Console.Write("Enter current student score or -1 to stop: ");
				if(int.TryParse(Console.ReadLine(), out current))
				{
					if (current == -1)
					{
						break;
					}
					else if (current < 1)
					{
						Console.WriteLine("Please enter a positive value");
						continue;
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
