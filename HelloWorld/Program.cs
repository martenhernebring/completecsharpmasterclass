using System;

namespace HelloWorld
{
	internal class Program
	{

		static void Main(string[] args)
		{
			//declare 2D array
			int[,] matrix = new int[,] 
			{
				{1,2,3}, {4,5,6}, {7,8,9}
			};
			Console.WriteLine("Central value is {0}", matrix[2,0]);
			//declare 3D array
			//int[,,] threeD;
		}
	}
}
