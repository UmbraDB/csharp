using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ficha {
	class Program{
		static void Main(string[] args){
			Classes classes = new Classes();
			int a;
			while (true){
				Console.Clear();
				int opt = classes.menu();
				if(opt == 0) break;
				else if(opt == -1) System.Console.WriteLine("----Bad value, choose a value from the list!---");
				else {
					switch (opt) {
						case 1:
							a = classes.twice();
							if (a == -1) System.Console.WriteLine("Invalid Number");
							System.Console.WriteLine("Result: " + a);
							break;
						case 2:
							a = classes.even();
							if (a == 1) System.Console.WriteLine("The number is odd.");
							else if (a == 0) System.Console.WriteLine("The number is even");
							else System.Console.WriteLine("Not an Interger");
							break;
						case 3:
							a = classes.sumFirst();
							if(a < 1) System.Console.WriteLine("Invalid Interger");
							else System.Console.Write(a);
							break;
						case 4:
							classes.sumPos();
							break;
						default:
							System.Console.WriteLine("----Bad value, choose a value from the list!---");
							break;
					}
					Console.ReadLine();
				}
			}
		}
	}
}
