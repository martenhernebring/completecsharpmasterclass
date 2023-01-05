using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
	public class Speller
	{

		public static string Convert(int i)
		{
			Dictionary<int, string> numberWords = new Dictionary<int, string>()
			{
				{ 0, "zero"},
				{ 1, "one"},
				{ 2, "two"},
				{ 3, "three"},
				{ 4, "four"},
				{ 5, "five"}
			};
			string word;
			if (numberWords.TryGetValue(i, out word))
				return word;
			else
				return "nope";
		}
	}
}
