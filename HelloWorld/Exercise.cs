using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
	public class Run
	{
		private static Func<float, float, float> plus = (lf, rf) => lf + rf;
		private static Func<float, float, float> minus = (lf, rf) => lf - rf;
		private static Func<float, float, float> divide = (lf, rf) => lf / rf;
		private static Func<float, float, float> multiply = (lf, rf) => lf * rf;

		private static Dictionary<string, Func<float, float, float>> operators = new Dictionary<string, Func<float, float, float>>()
		{
			{"+", plus },
			{"-", minus },
			{"/", divide },
			{"*", multiply }
		};

		public static Func<float, float, float> OperationGet(string input)
		{
			if (operators.ContainsKey(input))
			{
				return operators[input];
			}
			else
			{
				return null;
			}
		}
	}
}
