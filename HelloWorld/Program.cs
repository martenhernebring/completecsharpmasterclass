using School;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace HelloWorld
{
	public class Program
	{

		public static void Main(string[] args)
		{
			Console.WriteLine("Main thread: starting a timer");
			Timer t = new Timer(ComputeBoundOp, 5, 0, 2000);
			Console.WriteLine("Main thread: Doing other work here...");
			Thread.Sleep(10000); // Simulating other work (10 seconds)
			t.Dispose(); // Cancel the timer now
		}
		// This method's signature must match the TimerCallback delegate
		private static void ComputeBoundOp(Object state)
		{
			// This method is executed by a thread pool thread 
			Console.WriteLine("In ComputeBoundOp: state={0}", state);
			Thread.Sleep(1000); // Simulates other work (1 second)
								// When this method returns, the thread goes back 
								// to the pool and waits for another task 
		}

	}
}