using School;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			Dictionary<int, Student> idStudentDictionary = new Dictionary<int, Student>();
			Student student = new Student(1, "Jason", 55);
			idStudentDictionary.Add(student.Id, student);
			idStudentDictionary.Add(2, new Student(2, "Maria", 30));
			Student storedStudent = idStudentDictionary[student.Id];
			foreach (KeyValuePair<int, Student> keyValuePair in idStudentDictionary)
			{
				keyValuePair.Value.Print();
			}
			foreach (Student s in idStudentDictionary.Values)
			{
				s.Print();
			}
		}

	}
}