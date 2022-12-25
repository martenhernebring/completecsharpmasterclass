﻿using System;

namespace Coding.Exercise
{
	public class Phone
	{
		public string Company;
		public string Model;
		public string ReleaseDay;

		public Phone() 
		{
			Company = "unknown";
			Model = "unknown";
			ReleaseDay = "unknown";
		}

		public Phone(string Company, string Model)
		{
			this.Company = Company;
			this.Model = Model;
			ReleaseDay = "unknown";
		}

		public Phone(string company, string model, string releaseDay) : this(company, model)
		{
			ReleaseDay = releaseDay;
		}	

		public void Introduce()
		{
			Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
		}

	}

	public class Run
	{
		public static void RunExercise()
		{
			Phone one = new Phone();
			Phone two = new Phone("Apple", "IPhone 12");
			Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

			one.Introduce();
			two.Introduce();
			three.Introduce();
		}

	}
}
