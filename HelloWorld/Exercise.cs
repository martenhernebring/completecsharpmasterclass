﻿using System;

namespace Coding.Exercise
{
	public class Exercise
	{
		public static void NestedCheck(int number)
		{
			if (number % 3 == 0)
			
				Console.WriteLine("Divisible by 3.");
			
			else if (number % 7 == 0)
			
				Console.WriteLine("Divisible by 7.");
			
			else 
			
				Check(number);
			
		}

		public static void Check(int number)
		{
			if (number % 2 == 0)
			
				Console.WriteLine("Even number.");
			
			else
			
				Console.WriteLine("Odd number.");
			
		}
	}
}
