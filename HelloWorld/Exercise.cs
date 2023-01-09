using System;

namespace Coding.Exercise
{

	public interface IShootable
	{
		void Shoot();
	}

	public class Weapon
	{
		public string Name { get; set; }
		public Weapon(string name) 
		{
			Name = name;
		}
		public void Label() 
		{
			Console.WriteLine("This is {0}!", Name);
		} 
	}

	public class Gun : Weapon, IShootable
	{
		public Gun() : base ("Gun") { }

		public void Shoot()
		{
			Console.WriteLine("Bang!");
		}
	}

	public static class Program
	{
		static public void Main(string[] args)
		{
			// new instance 
			Gun pist = new Gun();

			// test for methods
			pist.Label();
			pist.Shoot();

			// verifying the interface and the parent class
			if (pist is IShootable && pist is Weapon)
				System.Console.WriteLine("Yes, it is my parents.");
		}
	}
}
