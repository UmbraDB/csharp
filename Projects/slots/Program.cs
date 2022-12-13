using System;
using System.Threading;

namespace Slots
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			Console.WriteLine("\n\n****-|Welcome to DB Slots!|-****\n\n");
			
			Menu menu = new Menu();
			string username = menu.Logon();
			int deposit = menu.Deposit();
			Login login = new Login (username, deposit);
			for(int selector = -1; selector != 0; Console.ReadLine()) 
			{
				Console.Clear();
				menu.Selection();
				int.TryParse(Console.ReadLine(), out selector);
				if (selector == 0) break;
				switch (selector)
				{
					case 1:
						Console.WriteLine("Your Username is: " + login.Username);
						break;
					case 2:
						Console.WriteLine("Your Balance is: " + login.Balance);
						break;
					case 3:
						deposit = menu.Deposit();
						login.Deposit(deposit);
						break;
					default:
						Console.WriteLine("Invalid Option!");
						break;
				} 
			}
		}	
	}
}
