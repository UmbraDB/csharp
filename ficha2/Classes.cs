using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ficha {
	class Classes {
		public int menu() {
			Console.WriteLine("0-Close");
			System.Console.WriteLine("1-Double");
			System.Console.WriteLine("2-Even or odd");
			System.Console.WriteLine("3-Add \"x\" first numbers");
			System.Console.WriteLine("4-Add positive numbers until -1");
			System.Console.WriteLine("5-");
			int opt;
			if(int.TryParse(Console.ReadLine(), out opt)) return opt;
			else return -1;
		}
		public int twice() {
			int a;
			System.Console.WriteLine("Input a number to see its double: ");
			if(int.TryParse(Console.ReadLine(), out a)) return a*2;
			else return -1;
		}
		public int even() {
			int a;
			System.Console.WriteLine("Input a number to see if its even or odd: ");
			if(int.TryParse(Console.ReadLine(), out a))	return a%2;
			else return -1;
		}
		public int sumFirst(){
			int i;
			int a = 0;
			System.Console.WriteLine("Until what number do you wish to add?: ");
			if(int.TryParse(Console.ReadLine(), out i)){
				for (int b = 1; i > 0; i--, b++, System.Console.Write(" + ")){
					System.Console.Write(b);
					a += b;
				}
				System.Console.Write(" = ");
				return a;
			} else return -1;
		}
		public void sumPos(){
			System.Console.Write("Input a positive interger to start (-1 to close): \n");
			for(int a=0, b=0; a!=-1; b+=a, System.Console.Write(" = {0} \n", b)){
				if(!int.TryParse(Console.ReadLine(), out a) || a < -1){
					System.Console.WriteLine("Invalid interger");
					a = 0;
				}
				else if (a == -1){
					System.Console.Write("Total = " + b);
					break;
				} else {
					System.Console.Write(b + " + " + a);
				}
			}

		}
	}
}
