using System;
using System.Threading;

namespace Slots
{
	class Menu
	{
		enum Options //enum para as opções do menu 
		{
			Close,
			Check_Username,
			Check_Balance,
			Deposit,
			Withdrawal,
			Guess_Game,
			Lucky_Slots
		}
		public string Logon() //metodo para receber o input do username
		{
			Console.Write("-Please input your name: ");
			string name = Console.ReadLine();
			return name;
		}
		public int Deposit() //metodo para receber o input do deposito não permite um deposito menor que 1
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
		public int Withdrawal(int balance) // metodo para receber o input do levantamento, não permitido quando o saldo é 0 ou menor
		{
			if (balance <= 0)
			{
				Console.WriteLine("Your balance is 0. Please make a DEPOSIT");
				Console.ReadLine();
				return 0;
			} else{
				Login login = new Login(balance); //chama a class Login no construtor com apenas uma opção para que não se alterem os dados do utilizador
				int withdrawal;
				Console.Write("-How much do you wish to withdrawal?: ");
				for(;;)
				{
					if(int.TryParse(Console.ReadLine(), out withdrawal) && withdrawal <= login.Balance && withdrawal > 0)
					{
						login.Withdrawal(withdrawal);
						Console.WriteLine("You've withdrawn: " + withdrawal);
						Console.WriteLine("Your Balance is: " + login.Balance);
						Console.ReadLine();
						return withdrawal;
					} else if (withdrawal < 1) Console.WriteLine("The withdrawal must be above 1");
					else Console.WriteLine("Invalid Amount!!");
				}
			}
		}
		public int Bet(int balance) //semelhante ao withdrawal, usado para receber o input das apostas
		{
			if (balance <= 0)
			{
				Console.WriteLine("Your balance is 0. Please make a DEPOSIT"); //isto não deve aparecer, está colocado como redundancia, para impedir que algum erro num dos jogos ou menus permita fazer uma aposta com saldo 0 ou entre num loop de erro infinito
				Console.ReadLine();
				return 0;
			} 
			else 
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
			Console.WriteLine("0 - " + Options.Close);
			Console.WriteLine("1 - " + Options.Check_Username);
			Console.WriteLine("2 - " + Options.Check_Balance);
			Console.WriteLine("3 - " + Options.Deposit);
			Console.WriteLine("4 - " + Options.Withdrawal);
			Console.WriteLine("5 - " + Options.Guess_Game);
			Console.WriteLine("6 - " + Options.Lucky_Slots);
		}
	}
}
