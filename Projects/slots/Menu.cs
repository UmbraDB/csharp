using System;
using System.Threading;

namespace Slots
{
	class Menu
	{
		public string Logon()
		{
			Console.Write("-Please input your name: ");
			string name = Console.ReadLine();
			return name;
		}
		public int Deposit()
		{
			int deposit;
			Console.Write("-Please make a deposit: ");
			for(;;)
			{
				if(int.TryParse(Console.ReadLine(), out deposit))
				{
					return deposit;
					break;
				} else if (deposit < 1) Console.WriteLine("The deposit must be above 1");
				else Console.WriteLine("Invalid Amount!!");
			}
		}
		public void Selection()
		{
			Console.WriteLine("\nPlease Choose an option!\n");
			Console.WriteLine("0 - Close");
			Console.WriteLine("1 - Check Username");
			Console.WriteLine("2 - Check Balance");
			Console.WriteLine("3 - Make Deposit");
		}
	}
}
