using School;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			string text = File.ReadAllText(@"C:\Users\HP\Downloads\input2.txt");
			string pattern = @"\d{2,3}";
			Regex regex = new Regex(pattern);
			var matchCollection = regex.Matches(text);
			using (StreamWriter file = new StreamWriter(@"C:\Users\HP\Downloads\output.txt", true))
			{
				foreach (Match match in matchCollection)
				{
					int value = int.Parse(match.Value);
					file.Write((char) value);

				}

			}
		}

	}
}