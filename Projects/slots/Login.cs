using System;
using System.Threading;

namespace Slots
{
	class Login
	{
		private string username;
		protected int balance = 0;
		public string Username
		{
			get {return username;}
			private set 
			{
				if (value == "") username = "Player";
				else username = value;
			}
		}
		public int Balance
		{
			get {return balance;}
			private set
			{
				if (value < 0) balance =+ 0;
				else balance =+ value;
			}
		}
		public Login (string name, int deposit)
		{
			this.Username = name;
			this.Balance = deposit;
		}
		public Login (int balance)
		{
			this.Balance = balance;
		}

		public void Deposit (int deposit) 
		{
			if (deposit > 0) balance += deposit; //this exists as a failsafe in case some invalid numbar gets pass menu.Deposit
		}
		public void Withdrawal (int withdrawal)
		{
			if (withdrawal <= balance) balance -= withdrawal;
			else Console.WriteLine("Impossible to process withdrawal!");
		}
	}
}
