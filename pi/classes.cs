using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi{
	class Utilities{
		public int menu(){
			Console.WriteLine("Choose an option: ");
			Console.WriteLine("0-Close");
			Console.WriteLine("1-Iterate until key is pressed");
			int option;
			if(int.TryParse(Console.ReadLine(), out option)) return option;
			else return -1;
		}
		public decimal loop()
		{
			Console.WriteLine("This will run an infinite loop until a key is pressed! Press any key to start!)");
			Console.ReadLine();
			int dividend = 4;
			decimal pi = 0m;
			int divider;
			int counter = 0;
			for (divider = 1; !Console.KeyAvailable; divider += 2, dividend *= -1, counter++) 
			{
				pi += (decimal)dividend / (decimal)divider;
   				Console.WriteLine(pi);
 			}
			Console.WriteLine("Loop ended after {0} iterations!", counter);
			Console.WriteLine("Your pi value is: " + pi);
			Console.WriteLine("Your divider reached: " + divider + " with {0} as the dividend!", dividend);
			Console.ReadLine();
			return pi;
		}
	}
}
