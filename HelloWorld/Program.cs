using Coding.Exercise;
using System;

namespace HelloWorld
{
	public class Program
	{
		private static string[,] matrix =
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"}
		};
		private static string current;
		private static bool alreadyTaken = false;
		private static char input;
		private static int turn;

		public static void Main(string[] args)
		{
			turn = 1;
			bool player1 = true;
			while (true) { 
				for (int i = 0; i < 11; i++)
				{
					for (int j = 0; j < 21; j++)
					{
						if (i == 3 | i == 7)
						{
							Console.Write("-");
						}
						else if (j == 6 | j == 13)
						{
							Console.Write("|");
						}
						else if ((i == 1 | i == 5 | i == 9) & (j == 2 | j == 9 | j == 16))
						{
							Console.Write(matrix[(i - 1) / 4, (j - 2) / 7]); 
						}
						else
						{
							Console.Write(" ");
						}
					}
					Console.WriteLine();
				}
				current = player1 ? "O" : "X";
				alreadyTaken = false;
				do
				{
					Console.Write("Player {0}: Choose your field!", player1 ? 1 : 2);
					input = Console.ReadKey().KeyChar;
					Console.WriteLine();
					switch (input)
					{
						case '1':
							checkIfTaken(0, 0);
							break;
						case '2':
							checkIfTaken(0, 1);
							break;
						case '3':
							checkIfTaken(0, 2);
							break;
						case '4':
							checkIfTaken(1, 0);
							break;
						case '5':
							checkIfTaken(1, 1);
							break;
						case '6':
							checkIfTaken(1, 2);
							break;
						case '7':
							checkIfTaken(2, 0);
							break;
						case '8':
							checkIfTaken(2, 1);
							break;
						case '9':
							checkIfTaken(2, 2);
							break;
						default: 
							alreadyTaken = true;
							Console.WriteLine("Please enter a number between 1 and 9!");
							break;
					}
				} while (alreadyTaken == true);
				if (TicTacToe.Checker(matrix))
				{
					Console.WriteLine("Player {0} has won!", player1 ? 1 : 2);
					Reset();
					player1 = true;

				}
				else if (turn > 8)
				{
					Console.WriteLine("Draw!");
					Reset();
					player1 = true;
				}
				else 
				{
					turn++;
					player1 = !player1;
				}
			}
		}

		private static void Reset()
		{
			Console.WriteLine("Press any Key to Reset the Game");
			Console.ReadKey();
			Console.WriteLine();
			matrix[0, 0] = "1";
			matrix[0, 1] = "2";
			matrix[0, 2] = "3";
			matrix[1, 0] = "4";
			matrix[1, 1] = "5";
			matrix[1, 2] = "6";
			matrix[2, 0] = "7";
			matrix[2, 1] = "8";
			matrix[2, 2] = "9";
			turn = 1;
		}

		private static void checkIfTaken(int row, int column)
		{
			if (matrix[row, column][0].Equals(input))
			{
				alreadyTaken = false;
				matrix[row, column] = current;
			}
			else
			{
				alreadyTaken = true;
				Console.WriteLine("Incorrect input! Please use another field!");
			}
		}
	}
}
