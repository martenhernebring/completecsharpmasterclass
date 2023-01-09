using System;
using System.Collections;
using System.Collections.Generic;

namespace Coding.Exercise
{
	public class Contact 
	{
		public string Name { get; set; }
		public string PhoneNumber { get; set; }

		public Contact(string name, string phoneNumber) 
		{
			Name = name;
			PhoneNumber = phoneNumber;
		}

		public void Call() 
		{
			Console.WriteLine("Calling to {0}. Phone number is {1}", Name, PhoneNumber);
		}
	}

	public class PhoneBook : IEnumerable<Contact>
	{
		private List<Contact> contacts;
		public PhoneBook() 
		{
			contacts = new List<Contact>{
				new Contact("Andre", "435797087"),
				new Contact("Lisa", "435677087"),
				new Contact("Dine", "3457697087"),
				new Contact("Sofi", "4367697087")
			};
		}

		public IEnumerator<Contact> GetEnumerator()
		{
			return contacts.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}

	public static class Program
	{
		static public void Main(string[] args)
		{
			PhoneBook MyPhoneBook = new PhoneBook();

			foreach (Contact contact in MyPhoneBook)
			{
				contact.Call();
			}
		}
	}
}
