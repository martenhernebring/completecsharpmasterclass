using System;

namespace Coding.Exercise
{
	public class TicTacToe
	{
		public static bool Checker(string[,] board)
		{
			for (int i = 0; i < board.GetLength(0); i++)
			{
				bool sameRow = true;
				bool sameColumn = true;
				for (int j = 1; j < board.GetLength(1); j++)
				{
					if (!board[i, j].Equals(board[i, j - 1]))
						sameRow = false;

					if (!board[j, i].Equals(board[j - 1, i]))
						sameColumn = false;

				}
				if (sameRow | sameColumn)
					return true;

			}
			bool sameLeftToRightDiagonal = true;
			bool sameRightToLeftDiagonal = true;
			for (int i = 1; i < board.GetLength(0); i++)
			{
				if (!board[i, i].Equals(board[i - 1, i - 1]))
					sameLeftToRightDiagonal = false;

				if (!board[i, board.GetLength(0) - i - 1].Equals(board[i - 1, board.GetLength(0) - i]))
					sameRightToLeftDiagonal = false;

			}
			return sameLeftToRightDiagonal | sameRightToLeftDiagonal;
		}
	}
}
