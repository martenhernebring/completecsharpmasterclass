using System;
using System.Globalization;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string stringForFloat = "0.85"; // datatype should be float
			string stringForInt = "12345"; // datatype should be int
			int i1 = Int32.Parse(stringForInt);
			float f1 = float.Parse(stringForFloat, CultureInfo.InvariantCulture);
		}
	}
}
