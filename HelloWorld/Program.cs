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
			DateTime myBirthday = new DateTime(1986, 4, 26);
			Console.WriteLine("My birthday is {0}", myBirthday);
			Console.WriteLine(DateTime.UtcNow);
		}

	}
}