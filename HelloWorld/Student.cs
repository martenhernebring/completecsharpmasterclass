using System;

namespace School
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float GPA { get; set; }

		public Student(int id, string name, float gpa)
		{
			Id = id;
			Name = name;
			GPA = gpa;
		}

		public void Print()
		{
			Console.WriteLine("Student ID:{0}, Name:{1}, GPA{2}", Id, Name, GPA);
		}
	}
}
