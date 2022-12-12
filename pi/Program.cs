using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi 
{
	internal class Program
	{
		static void Main(string [] args)
		{
			Utilities utilities = new Utilities();
			int runTime;
			decimal pi;
			Console.Clear();
			for(;;)
			{
				Console.Clear();
				runTime = utilities.menu();
				Console.Clear();
				if (runTime == 0) break;
				switch (runTime)
				{
					case -1:
						Console.WriteLine("Invalid input");
						break;
					case 1:
						pi = utilities.loop();
						break;
					default:
						Console.WriteLine("Option not found");
						break;
						
				}
				Console.ReadLine();
			}

		}
	}
}

