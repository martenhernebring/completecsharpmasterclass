using Coding.Exercise;
using System;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			int[] grades = { 1, 2, 3, 4, 5, 6, 7, 8, };
			double averageResult = GetAverage(grades);
			Console.WriteLine(averageResult);
		}

		public static double GetAverage(int[] grades) 
		{
			int sum = 0;
			for (int i = 0; i < grades.Length; i++)
			{
				sum += grades[i];
			}
			return (double) sum / grades.Length;
		}

	}
}