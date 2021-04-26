using System;
using System.Collections.Generic;

namespace LV2 {
	class Program {	
		static void Main(string[] args) {
			DiceRoller diceRoller = new DiceRoller();
			for (int i = 0; i < 20; i++)
				diceRoller.InsertDie(new Die(6));
			diceRoller.RollAllDice();

			//FileLogger logger = new FileLogger("test.txt");
			ConsoleLogger logger = new ConsoleLogger();
			logger.Log(diceRoller);
		}
	}
}
