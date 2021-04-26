using System;
using System.Collections.Generic;
using System.Text;

namespace LV2 {
	interface IFlexibleRoller {
		void InsertDie(Die die);
		void RemoveAllDice();
	}
}
