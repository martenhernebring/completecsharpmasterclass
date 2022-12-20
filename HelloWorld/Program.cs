using System;
using System.Globalization;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			byte ub = 4;
			sbyte sb = -1;
			ushort us = 5000;
			short ss = -300;
			uint ui = 80000;
			int si = -80000;
			ulong ul = 5000000000;
			long sl = -5000000000;
			float fpi = 3.14F;
			double dpi = 3.1415927;
			char letter = 'A';
			bool dayLight = false;
			decimal cents50 = 0.50M;
			string text = "I control text";
			string wholeNumber = "15";
			int number = Int32.Parse(wholeNumber);
			Console.WriteLine(ub);
			Console.WriteLine(sb);
			Console.WriteLine(us);
			Console.WriteLine(ss);
			Console.WriteLine(ui);
			Console.WriteLine(si);
			Console.WriteLine(ul);
			Console.WriteLine(sl);
			Console.WriteLine(fpi);
			Console.WriteLine(dpi);
			Console.WriteLine(letter);
			Console.WriteLine(dayLight);
			Console.WriteLine(cents50);
			Console.WriteLine(number);
		}
	}
}
