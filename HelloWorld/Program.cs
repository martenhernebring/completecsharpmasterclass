using School;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			string[] lines = File.ReadAllLines(@"C:\Users\HP\Downloads\input.txt");
			using (StreamWriter sw = new StreamWriter(@"C:\Users\HP\Downloads\output.txt")) 
			{
				foreach (string line in lines)
				{
					if (line.Contains("split"))
					{
						var words = line.Split(' ');
						sw.Write(words[4]);
						sw.Write(" ");
					}
				}
			}
		}

	}
}