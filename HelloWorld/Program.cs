using System;

namespace HelloWorld
{
	internal class Program
	{
		private static string _highScorePlayer;
		private static int _highScore;

		static void Main(string[] args)
		{
			_highScorePlayer = "Morten";
			_highScore = 300;
			Save(250, "Maria");
			Save(315, "Michael");
			Save(350, "Morten");
		}

		private static void Save(int score, string playerName)
		{
			if (score > _highScore)
			{
				_highScore = score;
				_highScorePlayer = playerName;
				Console.WriteLine("New highscore is " + score);
				Console.WriteLine("New highscore holder is " + playerName);
			}
			else
			{
				Console.WriteLine("The old highscore of " + _highScore + 
					" could not be broken and is still held by " + _highScorePlayer + ".");
			}
		}
	}
}
