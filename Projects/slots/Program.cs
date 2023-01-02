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
			int withdrawal;
			int bet;
			int prize;
			Login login = new Login (username, deposit);
			Game game = new Game();
			for(int selector = -1; selector != 0; prize = 0) 
			{
				Console.Clear();
				if (login.Balance <= 0) Console.WriteLine("\n\b WARNING!!! \n Your Balance is {0} you should make a DEPOSIT", login.Balance);
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
						Console.WriteLine("You deposited " + deposit);
						Console.WriteLine("Your Balance is: " + login.Balance);
						break;
					case 4:
						withdrawal = menu.Withdrawal(login.Balance);
						login.Withdrawal(withdrawal);
						Console.WriteLine("You've withdrawn: " + withdrawal);
						Console.WriteLine("Your Balance is: " + login.Balance);
						break;
					case 5:
						Console.Clear();
						bet = menu.Bet(login.Balance);							
						for(bool runTime=true;runTime == true && bet <= login.Balance;)
						{
							login.Withdrawal(bet);
							int guess = menu.GuessGame();
							if (game.Guess(guess) == true)
							{
								if (guess == 0) guess = 10;
								prize = bet * guess;
								login.Deposit(prize);
							} else prize = 0;
							game.Prize(prize);
							Console.WriteLine("Play again with same Bet??Press Enter for Yes");
							if (Console.ReadKey().Key != ConsoleKey.Enter) runTime = false;
						}
						break;
					case 6:
						Console.Clear();
						bet = menu.Bet(login.Balance);
						for(bool runTime=true;runTime == true && bet <= login.Balance;)
						{
							login.Withdrawal(bet);
							prize = game.SlotMachine(bet);
							game.Prize(prize);
							login.Deposit(prize);
							Console.WriteLine("Play again with same Bet? Press Enter for Yes");
							if (Console.ReadKey().Key != ConsoleKey.Enter) runTime = false;
						}
						break;
					default:
						Console.WriteLine("Invalid Option!");
						break;
				} 
			}
		}	
	}
}
