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
		public void Deposit (int deposit) 
		{
			balance += deposit;
			Console.WriteLine("Your balance is now: " + balance);
		}
		public void Withdrawl (int withdrawl){}
	}
}
