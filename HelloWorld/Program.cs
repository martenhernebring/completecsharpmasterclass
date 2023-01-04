using Coding.Exercise;
using System;
using System.Collections;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			ArrayList myNonGenericList = new ArrayList(100);
			myNonGenericList.Add(25);
			myNonGenericList.Add("Hello");
			myNonGenericList.Add(3.14);
			myNonGenericList.Add(1.01f);
			//delete the first element with specific value
			myNonGenericList.Remove(3.14);
			//delete element at specific position
			myNonGenericList.RemoveAt(0);
			Console.WriteLine(myNonGenericList.Count);
			double sum = 0;
			foreach (object item in myNonGenericList)
			{
				if (item is float)
				{
					sum += Convert.ToDouble(item);
				}
				else if (item is string) {
					Console.WriteLine(item);
				}
			}
			Console.WriteLine(sum);
		}

	}
}