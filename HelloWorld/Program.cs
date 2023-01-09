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
			DateTime tomorrow = GetUtcTomorrow();
			Console.WriteLine(tomorrow);
			Console.WriteLine("Days since Mortens birthday is {0}", DateTime.Now.Subtract(new DateTime(1986, 4, 26)));
		}

		private static DateTime GetUtcTomorrow()
		{
			return DateTime.UtcNow.AddDays(1);
		}
	}
}