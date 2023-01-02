using System;
using System.Threading;

namespace Slots
{
	class Game
	{
		static Random random = new Random();
		public bool Guess(int guess)
		{
			int randomNumber = random.Next(10);
			Console.WriteLine("And the PRIZED number is: {0} !!!", randomNumber);
			if (guess == randomNumber) return true;
			else return false;

		}
		public int SlotMachine(int bet) 
		{
			int prize, multiplier, slot1, slot2, slot3;
			Console.Clear();
			for (slot1 = random.Next(10), slot2 = random.Next(10), slot3 = random.Next(10);!Console.KeyAvailable;)
			{
				slot1 = random.Next(10);
				slot2 = random.Next(10);
				slot3 = random.Next(10);
				Console.SetCursorPosition(0, 0);
				Console.WriteLine("  _______________ ");
				Console.WriteLine(" /#*LUCKY  SLOT*#\\");
				Console.WriteLine("|  {0}  |  {1}  |  {2}  |", slot1, slot2, slot3);
				Console.WriteLine(" \\_______________/");
			}
			Console.ReadLine();
			if (slot1 == slot2 && slot2 == slot3)
			{
				if (slot1 == 0) multiplier = 100;
				else multiplier = slot1*10;
			} 
			else if (slot1 == slot2 || slot1 == slot3 || slot2 == slot3) multiplier = 2;
			else if (slot1 == slot2-1 && slot2 == slot3 -1)
			{
				multiplier = slot1+slot2+slot3;
			}
			else if (slot1 == slot2+1 && slot2 == slot3+1)
			{
				multiplier = slot1+slot2+slot3;
			}
			else multiplier = 0;
			prize = bet * multiplier;
			return prize;
		}
		public void Prize(int prize)
		{
			if (prize > 0){
				if (prize > 1000) Console.WriteLine("!!BIG WIN!!");
				Console.WriteLine("You WIN!! Your PRIZE: " + prize);
			}
			else Console.WriteLine("you LOST! :(");
		}
	}
}
