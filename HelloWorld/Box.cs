using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	internal class Box
	{
		private int length = 1;
		private int height = 2;
		private int width = 3;

		public int Volume 
		{
			get { return length * height * width; }
		}
	}
}
