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
				if(int.TryParse(Console.ReadLine(), out deposit) && deposit > 0)
				{
					return deposit;
					break;
				} else if (deposit < 1) Console.WriteLine("The deposit must be above 1");
				else Console.WriteLine("Invalid Amount!!");
			}
		}
		public int Withdrawal(int balance)
		{
			Login login = new Login(balance);
			int withdrawal;
			Console.Write("-How much do you wish to withdrawal?: ");
			for(;;)
			{
				if(int.TryParse(Console.ReadLine(), out withdrawal) && withdrawal <= login.Balance && withdrawal > 0)
				{
					return withdrawal;
					
				} else if (withdrawal < 1) Console.WriteLine("The withdrawal must be above 1");
				else Console.WriteLine("Invalid Amount!!");
			}
		}
		public int Bet(int balance)
		{
			Login login = new Login(balance);
			int bet;
			Console.Write("-How much do you wish to bet?: ");
			for(;;)
			{
				if(int.TryParse(Console.ReadLine(), out bet) && bet <= login.Balance && bet > 0)
				{
					return bet;
				} else if (bet < 1) Console.WriteLine("The bet must be above 1");
				else Console.WriteLine("Invalid Amount!!");
			}
		}
		public int GuessGame()
		{
			int guess;
			Console.WriteLine("Guess a number from 0 to 9, you win your bet times your guess if you get it right!! 0 mutiplies by 10!!");
			for(;;){
				if(int.TryParse(Console.ReadLine(), out guess) && guess >=0 && guess <=9)
				{
					return guess;
				} else Console.WriteLine("invalid Guess");
			}
		}

		public void Selection()
		{
			Console.WriteLine("\nPlease Choose an option!\n");
			Console.WriteLine("0 - Close");
			Console.WriteLine("1 - Check Username");
			Console.WriteLine("2 - Check Balance");
			Console.WriteLine("3 - Make Deposit");
			Console.WriteLine("4 - Withdrawal");
			Console.WriteLine("5 - Guess game");
			Console.WriteLine("6 - Lucky Slot");
		}
	}
}
