using Coding.Exercise;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			var evenNumbers = ListsExercise.Solution();
			foreach (int number in evenNumbers)
			{
				Console.Write(number + " ");
			}
		}

	}
}